using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MyFileSystemWatcher
{
    public partial class QueryForm : Form
    {
        private string _extension;
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_reader;

        public QueryForm(string ext, SQLiteConnection conn, SQLiteCommand cmd )
        {
            sqlite_conn = conn;
            sqlite_cmd = cmd;
            _extension = ext;

            InitializeComponent();
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            if ( _extension == "ALL" || _extension == "" )
            {
                sqlite_cmd.CommandText = "SELECT * FROM eventdata";
                
            }
            else
            {
                sqlite_cmd.CommandText = "SELECT extension, file, path, oldfile, oldpath, event, datetime " +
                    " FROM eventdata" +
                    " WHERE extension = @ext_param";
                sqlite_cmd.Parameters.AddWithValue("@ext_param", _extension);
            }

            sqlite_reader = sqlite_cmd.ExecuteReader();

            while (sqlite_reader.Read())
            {
                dtgrd_results.Rows.Add(dtgrd_results.RowCount,
                    sqlite_reader["extension"],
                    sqlite_reader["file"],
                    sqlite_reader["path"],
                    sqlite_reader["oldfile"],
                    sqlite_reader["oldpath"],
                    sqlite_reader["event"],
                   sqlite_reader["datetime"] ); 

            }

            sqlite_reader.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();

            box.ShowDialog();
        }
    }
}
