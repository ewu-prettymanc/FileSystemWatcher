using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;
using System.Data.SQLite;

/*Colton Prettyman 02-18-2013
 * Midterm Project
 * CSCD Easter Washington University
 * Professor Thomas Capual
 * 
 * This is a gui'd program which is specifically designed to use
 * the FileSystemWatcher Class in the .Net FrameWork 4.5, and stores 
 * the event data in a SQLite x64 bit Database.
 * 
 * *****Things possibly worth Extra Credit*****
 * -The status bar on the MainForm which shows program status
 *      for a specific interval of time.
 * -The ability for the user to use a browser box to find directories
 * -The option for the user to Write/Query/Clear the database by extension
 * -The ability for the user to clear the current eventbox/datagrid.
 * -The use of icons for About box, .exe icon, program icon...etc.
 * -The way the datagrid is update once the current events are saved to the Database
 *      which includes renumbering the rowids accordingly
 * -Extensions, and Filenames are parsed into specifics.
 * -The ability to have multiple query forms open at once.
 * -The windows can be resized and the form self-adjusts its contents
 * -Steps to speed up SQLite Inserting
 */

namespace MyFileSystemWatcher
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class MainForm : Form
    {
        #region Members
        private string _dbname;
        private FileSystemWatcher _watcher;
        private string _path;
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private bool _unsavedevents;
        private Timer myTimer;
        private int _status_interval;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            Closing += new CancelEventHandler(MainWindow_Closing);

            _unsavedevents = false;
            _dbname = "database.db";
            _status_interval = 5000;

            InitDB();
            myTimer = new Timer();
            _watcher = new FileSystemWatcher();
            _watcher.SynchronizingObject = this;
            cmbx_dbextension.Focus();
        }

        #region FileSystemWatcher Logic code
        // Run the watching operations
        public bool Start()
        {
            //Connect the FileWatcher
            SetFilter();
            if (!SetDirectory())
            {//the user didn't enter a good directory
                cmbx_directory.Focus();
                return false;
            }

            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            _watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            // Include all subdirectories
            _watcher.IncludeSubdirectories = true;

            // Add event handlers...When an event happens it calls the specific method
            _watcher.Changed += new FileSystemEventHandler(OnChanged);
            _watcher.Created += new FileSystemEventHandler(OnChanged);
            _watcher.Deleted += new FileSystemEventHandler(OnChanged);
            _watcher.Renamed += new RenamedEventHandler(OnRenamed);
            _watcher.Error += new ErrorEventHandler(OnError);

            return true;
        }

        //Sets the FileSystemWatcher Filter
        private bool SetFilter()
        {
            if (cmbx_extension.Text == "ALL")
            {
                _watcher.Filter = "";
                return false;
            }
            string s = "*";
            s += cmbx_extension.Text;
            _watcher.Filter = s;
            cmbx_extension.Enabled = true;
            return true;
        }

        // Gets and verifies user input
        private bool SetDirectory()
        {
            string path = cmbx_directory.Text;

            // We do not want the user watching the place where our logfile will be
            // stored so reprompt them if they choose otherwise.
            while ((!(Directory.Exists(path) || File.Exists(path))) ||
                (path == Application.StartupPath))
            {
                lbl_directory.Text = "Invalid Directory!";
                lbl_directory.ForeColor = System.Drawing.Color.Red;
                path = cmbx_dbextension.Text;
                return false;
            }

            _path = path;
            _watcher.Path = path;

            lbl_directory.ForeColor = System.Drawing.Color.Black;
            lbl_directory.Text = "Directory to Monitor";
            cmbx_directory.Enabled = false;
            return true;
        }

        // Prints the current parameter to the form's datagrid view
        private void PrintToForm(Event ev)
        {
            eventsgrid.Rows.Add(eventsgrid.RowCount, ev.Extension, ev.Name, 
                ev.Path, ev.OldName,ev.OldPath, ev.EventType, ev.Time);

            /* this.BeginInvoke( 
                 (MethodInvoker)delegate
             { txtbx_watchevents.AppendText(Environment.NewLine + output); }
             );*/

            btn_cleareventbox.Enabled = true;
            storeToolStripMenuItem.Checked = false;
            clearEventBoxToolStripMenuItem.Enabled = true;
            tsbtn_cleareventbox.Enabled = true;
            _unsavedevents = true;
        }

        // Saves datagrid view items with the passed in extension
        private void SaveToDB(string extension)
        {
            // Lets insert something into our new table:
            sqlite_cmd = new SQLiteCommand("BEGIN", sqlite_conn);
            sqlite_cmd.ExecuteNonQuery();

            foreach (DataGridViewRow row in eventsgrid.Rows)
            {
                //Make sure we store only selected extension...or ALL
                if (row.Cells["extension"].Value.ToString() == extension ||
                     extension == "ALL")
                {
                    sqlite_cmd.CommandText = "INSERT INTO eventdata (extension, file, path, oldfile, oldpath, event, datetime)" +
                        " VALUES (@extension, @file, @path, @oldfile, @oldpath, @event, @datetime)";
                    sqlite_cmd.Parameters.AddWithValue("@extension", row.Cells["extension"].Value.ToString());
                    sqlite_cmd.Parameters.AddWithValue("@file", row.Cells["name"].Value.ToString());
                    sqlite_cmd.Parameters.AddWithValue("@path", row.Cells["path"].Value.ToString());
                    sqlite_cmd.Parameters.AddWithValue("@oldfile", row.Cells["oldname"].Value.ToString());
                    sqlite_cmd.Parameters.AddWithValue("@oldpath", row.Cells["oldpath"].Value.ToString());
                    sqlite_cmd.Parameters.AddWithValue("@event", row.Cells["eventtype"].Value.ToString());
                    sqlite_cmd.Parameters.AddWithValue("@datetime", row.Cells["datetime"].Value.ToString());

                    sqlite_cmd.ExecuteNonQuery();
                }
            }

            sqlite_cmd = new SQLiteCommand("END", sqlite_conn);
            sqlite_cmd.ExecuteNonQuery();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            CleanEventBox(extension);
        }

        // Initialize the SQLite Database
        private void InitDB()
        {
            //Find the path to the current directory....Then Create a File There.
            string dbpath = Application.StartupPath;
            dbpath += @"\" + _dbname;

            if (File.Exists(dbpath))
                // create a new database connection:
                sqlite_conn = new SQLiteConnection("Data Source=" + _dbname +
                    ";Version=3;New=False;Compress=True;");
            else
                sqlite_conn = new SQLiteConnection("Data Source=" + _dbname +
                    ";Version=3;New=True;Compress=True;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS eventdata (" +
                " extension TEXT, file TEXT, path TEXT, oldfile TEXT, oldpath TEXT, event TEXT, datetime TEXT );";
            // Now lets execute the SQL ;D
            sqlite_cmd.ExecuteNonQuery();
        }

        // Parses through the path to find the extension of the directory
        private string ParseExtension(string s)
        {
            string ext = "";
            bool nodot = true;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                ext = s[i] + ext;
                if (s[i] == '.')
                {
                    nodot = false;
                    break;
                }
            }
            // means it wasn't a file but a folder
            if (nodot)
                ext = "FOLDER";

            return ext;
        }

        // Parses through the path to find strictly the name 
        private string ParseName(string s)
        {
            string name = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i].ToString() == @"\")
                    break;
                name = s[i] + name;
            }

            return name;
        }

        //Cleans items with this extension from the datagrid
        private void CleanEventBox(string ext)
        {
            int i, length = eventsgrid.Rows.Count;

            for (i = 0; i < length; i++)
            {
                if (eventsgrid.Rows[i].Cells["extension"].Value.ToString() == ext ||
                    ext == "ALL")
                {
                    eventsgrid.Rows.RemoveAt(i);
                    length--;
                    i--;
                }
            }

            if (eventsgrid.Rows.Count == 0)
                ClearEventbox();

            // Update the row id
            i = 0;
            foreach (DataGridViewRow row in eventsgrid.Rows )
            {
                row.Cells["rowid"].Value = i;
                i++;
            }
        }

        //Clears the ALL data from the datagrid
        private void ClearEventbox()
        {
            btn_dbwrite.Enabled = false;
            tsbtn_storeevents.Enabled = false;
            storeToolStripMenuItem.Enabled = false;
            storeToolStripMenuItem.Checked = true;

            btn_cleareventbox.Enabled = false;
            clearEventBoxToolStripMenuItem.Enabled = false;
            tsbtn_cleareventbox.Enabled = false;

            eventsgrid.Rows.Clear();
            _unsavedevents = false;
        }

        // Sets the paremeter as the form status specified amount of time.
        public void SetStatusBar(string s)
        {
            /* Adds the event and the event handler for the method that will 
               process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            // Sets the timer interval to 5 seconds.
            myTimer.Interval = _status_interval;
            tslbl_status.Text = s;
            tslbl_status.ForeColor = System.Drawing.Color.Green;
            myTimer.Start();
        }

        // Closes the database connection
        private void CloseDB()
        {
            sqlite_conn.Close();
        }
        #endregion


        #region General Form Event Handlers
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            CloseDB();
        }

        //Provid a closing dialog box...
        void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            if (_unsavedevents)
            {
                DialogResult dr = MessageBox.Show("Write Current Events to the Database?",
                    "File System Watcher", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                    SaveToDB("ALL");
            }

            CloseDB();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!Start())
            {
                btn_start.Focus();
                return;
            }
            _watcher.EnableRaisingEvents = true;

            startToolStripMenuItem.Enabled = false;
            startToolStripMenuItem.Checked = true;
            stopToolStripMenuItem.Enabled = true;
            tsbtn_stop.Enabled = true;
            btn_start.Enabled = false;
            tsbtn_start.Enabled = false;
            btn_stop.Enabled = true;
            tsbtn_stop.Enabled = true;
            cmbx_directory.Enabled = false;
            cmbx_extension.Enabled = false;
            btn_dbwrite.Enabled = false;
            tsbtn_storeevents.Enabled = false;
            storeToolStripMenuItem.Enabled = false;
            btn_browse.Enabled = false;
            btn_stop.Focus();

            SetStatusBar("Watching...");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            _watcher.EnableRaisingEvents = false;

            startToolStripMenuItem.Enabled = true;
            startToolStripMenuItem.Checked = false;
            stopToolStripMenuItem.Enabled = false;
            tsbtn_stop.Enabled = false;
            tsbtn_start.Checked = false;
            tsbtn_start.Enabled = true;
            btn_stop.Enabled = false;
            tsbtn_stop.Enabled = false;
            btn_start.Enabled = true;
            tsbtn_start.Enabled = true;
            cmbx_directory.Enabled = true;
            cmbx_extension.Enabled = true;
            btn_browse.Enabled = true;
            if (_unsavedevents)
            {
                btn_dbwrite.Enabled = true;
                tsbtn_storeevents.Enabled = true;
                storeToolStripMenuItem.Enabled = true;
            }
            btn_start.Focus();

            SetStatusBar("Stopped");
        }

        private void btn_clearevents_Click(object sender, EventArgs e)
        {
            ClearEventbox();
            SetStatusBar("EventBox Cleared");
        }

        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            tslbl_status.Text = "";
            myTimer.Tick -= TimerEventProcessor;
        }

        //Lets the user browse to a directory
        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.ShowNewFolderButton = true;
            browse.ShowDialog();

            cmbx_directory.Text = browse.SelectedPath.ToString();
        }
        #endregion


        #region FileSystemWatcher Event Handlers
        // Define the event handlers. 
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Event ev = new Event();

            ev.Extension = ParseExtension(e.Name);
            ev.Name = ParseName(e.Name);
            ev.Path = e.FullPath;
            ev.EventType = e.ChangeType.ToString();
            ev.Time = DateTime.Now;

            PrintToForm(ev);
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            Event ev = new Event();

            ev.Extension = ParseExtension(e.Name);
            ev.Name = ParseName(e.Name);
            ev.Path = e.FullPath;
            ev.OldName = ParseName( e.OldName );
            ev.OldPath = e.OldFullPath;
            ev.EventType = "Renamed";
            ev.Time = DateTime.Now;


            // Specify what is done when a file is renamed.
            PrintToForm(ev);
        }

        private void OnError(object source, ErrorEventArgs e)
        {
            Event ev = new Event();

            ev.EventType = "ERROR";
            // Show that an error has been detected...ie.. buffer overflow

            //Give more information on the error
            if (e.GetException().GetType() == typeof(InternalBufferOverflowException))
                ev.Name = String.Format("The file system watcher experianced an internal buffer " +
                                       "overflow: " + e);
            ev.Time = DateTime.Now;

            PrintToForm(ev);
        }
        #endregion


        #region Database Related Events
        private void btn_dbwrite_Click(object sender, EventArgs e)
        {
            SetStatusBar("Saving...");
            SaveToDB(cmbx_dbextension.Text);
            SetStatusBar("Saved to Database");
        }

        private void btn_dbquery_Click(object sender, EventArgs e)
        {
            QueryForm query = new QueryForm(cmbx_dbextension.Text, sqlite_conn, sqlite_cmd);

            query.Show();
        }

        private void btn_dbclear_Click(object sender, EventArgs e)
        {
            string ext = cmbx_dbextension.Text.ToString();

            if (ext == "ALL")
                sqlite_cmd.CommandText = "DELETE FROM eventdata";
            else
            {
                sqlite_cmd.CommandText = "DELETE FROM eventdata WHERE extension = @ext_param ";
                sqlite_cmd.Parameters.AddWithValue("@ext_param", ext);
            }

            sqlite_cmd.ExecuteNonQuery();

            SetStatusBar("Cleared " + cmbx_dbextension.Text + " from Database");
        }
        #endregion


        #region Help Menu Events
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s;

            s = "\t\t---FileSystemWatcher Usage---" +
                "\n\nFileSystemWatcher is a simple program for watching file events on a " +
                "\nspecific user defined directory. The user has the option to specify" +
                "\nwhat file extensions to filter when watching. The user can enter a" +
                "\ndesired type or use one of the preset extensions. Leaving this box blank" +
                "\nwill result in watching all file types. The user can then enter which" +
                "\ndirectory they would like to watch. Note that this watches not only this" +
                "\ndirectory but any subdirectories and files contained therein. Once" +
                "\nan event has occured the user can choose to store this event in a" +
                "\ndatabase, or they can clear the event results box and continue watching." +
                "\nThe user can perform store, query, or clear actions on the database. First" +
                "\nthey can select an extension of their choice and then they can press the" +
                "\ncooresponding action button.";

            MessageBox.Show(s);
        }
        #endregion

    }
}
