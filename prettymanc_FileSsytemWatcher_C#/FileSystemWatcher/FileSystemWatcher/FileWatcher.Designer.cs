namespace MyFileSystemWatcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEventBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_start = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_stop = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_cleareventbox = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_storeevents = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_query = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_help = new System.Windows.Forms.ToolStripButton();
            this.lbl_extension = new System.Windows.Forms.Label();
            this.lbl_directory = new System.Windows.Forms.Label();
            this.lbl_dbextension = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_dbwrite = new System.Windows.Forms.Button();
            this.btn_dbquery = new System.Windows.Forms.Button();
            this.btn_dbclear = new System.Windows.Forms.Button();
            this.cmbx_extension = new System.Windows.Forms.ComboBox();
            this.cmbx_dbextension = new System.Windows.Forms.ComboBox();
            this.grpbx_filewatcher = new System.Windows.Forms.GroupBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.cmbx_directory = new System.Windows.Forms.ComboBox();
            this.grpbx_database = new System.Windows.Forms.GroupBox();
            this.btn_cleareventbox = new System.Windows.Forms.Button();
            this.eventsgrid = new System.Windows.Forms.DataGridView();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_watcherresults = new System.Windows.Forms.Label();
            this.stsp_status = new System.Windows.Forms.StatusStrip();
            this.ts_statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpbx_filewatcher.SuspendLayout();
            this.grpbx_database.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsgrid)).BeginInit();
            this.stsp_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileSystemWatcherToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileSystemWatcherToolStripMenuItem
            // 
            this.fileSystemWatcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.clearEventBoxToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.fileSystemWatcherToolStripMenuItem.Name = "fileSystemWatcherToolStripMenuItem";
            this.fileSystemWatcherToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.fileSystemWatcherToolStripMenuItem.Text = "FileSystem&Watcher";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // clearEventBoxToolStripMenuItem
            // 
            this.clearEventBoxToolStripMenuItem.Enabled = false;
            this.clearEventBoxToolStripMenuItem.Name = "clearEventBoxToolStripMenuItem";
            this.clearEventBoxToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.clearEventBoxToolStripMenuItem.Text = "&Clear Event Box";
            this.clearEventBoxToolStripMenuItem.Click += new System.EventHandler(this.btn_clearevents_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.stopToolStripMenuItem.Text = "Sto&p";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.databaseToolStripMenuItem.Text = "&Database";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Enabled = false;
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.storeToolStripMenuItem.Text = "&Store Events";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.btn_dbwrite_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.queryToolStripMenuItem.Text = "&Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.btn_dbquery_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.btn_dbclear_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.usageToolStripMenuItem.Text = "&Usage";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_start,
            this.tsbtn_stop,
            this.tsbtn_cleareventbox,
            this.toolStripSeparator1,
            this.tsbtn_storeevents,
            this.tsbtn_query,
            this.tsbtn_clear,
            this.toolStripSeparator2,
            this.tsbtn_help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_start
            // 
            this.tsbtn_start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_start.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_start.Image")));
            this.tsbtn_start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_start.Name = "tsbtn_start";
            this.tsbtn_start.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_start.Text = "Start";
            this.tsbtn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tsbtn_stop
            // 
            this.tsbtn_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_stop.Enabled = false;
            this.tsbtn_stop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_stop.Image")));
            this.tsbtn_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_stop.Name = "tsbtn_stop";
            this.tsbtn_stop.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_stop.Text = "Stop";
            this.tsbtn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tsbtn_cleareventbox
            // 
            this.tsbtn_cleareventbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_cleareventbox.Enabled = false;
            this.tsbtn_cleareventbox.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_cleareventbox.Image")));
            this.tsbtn_cleareventbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_cleareventbox.Name = "tsbtn_cleareventbox";
            this.tsbtn_cleareventbox.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_cleareventbox.Text = "Clear Event Box";
            this.tsbtn_cleareventbox.Click += new System.EventHandler(this.btn_clearevents_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtn_storeevents
            // 
            this.tsbtn_storeevents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_storeevents.Enabled = false;
            this.tsbtn_storeevents.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_storeevents.Image")));
            this.tsbtn_storeevents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_storeevents.Name = "tsbtn_storeevents";
            this.tsbtn_storeevents.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_storeevents.Text = "Store Events";
            this.tsbtn_storeevents.Click += new System.EventHandler(this.btn_dbwrite_Click);
            // 
            // tsbtn_query
            // 
            this.tsbtn_query.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_query.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_query.Image")));
            this.tsbtn_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_query.Name = "tsbtn_query";
            this.tsbtn_query.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_query.Text = "Query";
            this.tsbtn_query.Click += new System.EventHandler(this.btn_dbquery_Click);
            // 
            // tsbtn_clear
            // 
            this.tsbtn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_clear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_clear.Image")));
            this.tsbtn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_clear.Name = "tsbtn_clear";
            this.tsbtn_clear.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_clear.Text = "Clear Database";
            this.tsbtn_clear.Click += new System.EventHandler(this.btn_dbclear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtn_help
            // 
            this.tsbtn_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_help.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_help.Image")));
            this.tsbtn_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_help.Name = "tsbtn_help";
            this.tsbtn_help.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_help.Text = "Help/Usage";
            this.tsbtn_help.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // lbl_extension
            // 
            this.lbl_extension.AutoSize = true;
            this.lbl_extension.Location = new System.Drawing.Point(8, 31);
            this.lbl_extension.Name = "lbl_extension";
            this.lbl_extension.Size = new System.Drawing.Size(139, 17);
            this.lbl_extension.TabIndex = 3;
            this.lbl_extension.Text = "Monitor by Extension";
            // 
            // lbl_directory
            // 
            this.lbl_directory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_directory.AutoSize = true;
            this.lbl_directory.Location = new System.Drawing.Point(300, 28);
            this.lbl_directory.Name = "lbl_directory";
            this.lbl_directory.Size = new System.Drawing.Size(132, 17);
            this.lbl_directory.TabIndex = 5;
            this.lbl_directory.Text = "Directory to Monitor";
            // 
            // lbl_dbextension
            // 
            this.lbl_dbextension.AutoSize = true;
            this.lbl_dbextension.Location = new System.Drawing.Point(32, 32);
            this.lbl_dbextension.Name = "lbl_dbextension";
            this.lbl_dbextension.Size = new System.Drawing.Size(205, 17);
            this.lbl_dbextension.TabIndex = 7;
            this.lbl_dbextension.Text = "Write/Query/Clear by Extension";
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(303, 78);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(129, 31);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "&Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(475, 78);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(129, 31);
            this.btn_stop.TabIndex = 11;
            this.btn_stop.Text = "Sto&p";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_dbwrite
            // 
            this.btn_dbwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dbwrite.Enabled = false;
            this.btn_dbwrite.Location = new System.Drawing.Point(377, 52);
            this.btn_dbwrite.Name = "btn_dbwrite";
            this.btn_dbwrite.Size = new System.Drawing.Size(129, 31);
            this.btn_dbwrite.TabIndex = 14;
            this.btn_dbwrite.Text = "Store &Events";
            this.btn_dbwrite.UseVisualStyleBackColor = true;
            this.btn_dbwrite.Click += new System.EventHandler(this.btn_dbwrite_Click);
            // 
            // btn_dbquery
            // 
            this.btn_dbquery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dbquery.Location = new System.Drawing.Point(540, 52);
            this.btn_dbquery.Name = "btn_dbquery";
            this.btn_dbquery.Size = new System.Drawing.Size(64, 31);
            this.btn_dbquery.TabIndex = 15;
            this.btn_dbquery.Text = "&Query";
            this.btn_dbquery.UseVisualStyleBackColor = true;
            this.btn_dbquery.Click += new System.EventHandler(this.btn_dbquery_Click);
            // 
            // btn_dbclear
            // 
            this.btn_dbclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dbclear.Location = new System.Drawing.Point(627, 52);
            this.btn_dbclear.Name = "btn_dbclear";
            this.btn_dbclear.Size = new System.Drawing.Size(64, 31);
            this.btn_dbclear.TabIndex = 16;
            this.btn_dbclear.Text = "Clea&r";
            this.btn_dbclear.UseVisualStyleBackColor = true;
            this.btn_dbclear.Click += new System.EventHandler(this.btn_dbclear_Click);
            // 
            // cmbx_extension
            // 
            this.cmbx_extension.FormattingEnabled = true;
            this.cmbx_extension.Items.AddRange(new object[] {
            "ALL",
            "FOLDER",
            ".bin",
            ".conf",
            ".cpp",
            ".cs",
            ".css",
            ".dll",
            ".doc",
            ".exe",
            ".mp3",
            ".txt",
            ".java",
            ".rtf",
            ".tmp",
            ".sh",
            ".wav",
            ".xml",
            ".xls"});
            this.cmbx_extension.Location = new System.Drawing.Point(11, 51);
            this.cmbx_extension.Name = "cmbx_extension";
            this.cmbx_extension.Size = new System.Drawing.Size(136, 24);
            this.cmbx_extension.TabIndex = 17;
            this.cmbx_extension.Text = "ALL";
            // 
            // cmbx_dbextension
            // 
            this.cmbx_dbextension.FormattingEnabled = true;
            this.cmbx_dbextension.Items.AddRange(new object[] {
            "ALL",
            "FOLDER",
            ".bin",
            ".conf",
            ".cpp",
            ".cs",
            ".css",
            ".dll",
            ".doc",
            ".exe",
            ".mp3",
            ".txt",
            ".java",
            ".rtf",
            ".tmp",
            ".sh",
            ".wav",
            ".xml",
            ".xls"});
            this.cmbx_dbextension.Location = new System.Drawing.Point(35, 52);
            this.cmbx_dbextension.Name = "cmbx_dbextension";
            this.cmbx_dbextension.Size = new System.Drawing.Size(136, 24);
            this.cmbx_dbextension.TabIndex = 18;
            this.cmbx_dbextension.Text = "ALL";
            // 
            // grpbx_filewatcher
            // 
            this.grpbx_filewatcher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_filewatcher.Controls.Add(this.btn_browse);
            this.grpbx_filewatcher.Controls.Add(this.cmbx_directory);
            this.grpbx_filewatcher.Controls.Add(this.btn_start);
            this.grpbx_filewatcher.Controls.Add(this.lbl_extension);
            this.grpbx_filewatcher.Controls.Add(this.cmbx_extension);
            this.grpbx_filewatcher.Controls.Add(this.lbl_directory);
            this.grpbx_filewatcher.Controls.Add(this.btn_stop);
            this.grpbx_filewatcher.Location = new System.Drawing.Point(58, 56);
            this.grpbx_filewatcher.Name = "grpbx_filewatcher";
            this.grpbx_filewatcher.Size = new System.Drawing.Size(697, 125);
            this.grpbx_filewatcher.TabIndex = 19;
            this.grpbx_filewatcher.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse.Location = new System.Drawing.Point(616, 46);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 26);
            this.btn_browse.TabIndex = 19;
            this.btn_browse.Text = "&Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // cmbx_directory
            // 
            this.cmbx_directory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_directory.FormattingEnabled = true;
            this.cmbx_directory.Items.AddRange(new object[] {
            "C:\\",
            "C:\\Users",
            "C:\\Windows",
            "C:\\Program Files"});
            this.cmbx_directory.Location = new System.Drawing.Point(303, 48);
            this.cmbx_directory.Name = "cmbx_directory";
            this.cmbx_directory.Size = new System.Drawing.Size(301, 24);
            this.cmbx_directory.TabIndex = 18;
            this.cmbx_directory.Text = "C:\\";
            // 
            // grpbx_database
            // 
            this.grpbx_database.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_database.Controls.Add(this.lbl_dbextension);
            this.grpbx_database.Controls.Add(this.cmbx_dbextension);
            this.grpbx_database.Controls.Add(this.btn_dbclear);
            this.grpbx_database.Controls.Add(this.btn_dbwrite);
            this.grpbx_database.Controls.Add(this.btn_dbquery);
            this.grpbx_database.Location = new System.Drawing.Point(58, 538);
            this.grpbx_database.Name = "grpbx_database";
            this.grpbx_database.Size = new System.Drawing.Size(697, 90);
            this.grpbx_database.TabIndex = 20;
            this.grpbx_database.TabStop = false;
            this.grpbx_database.Text = "DataBase";
            // 
            // btn_cleareventbox
            // 
            this.btn_cleareventbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cleareventbox.Enabled = false;
            this.btn_cleareventbox.Location = new System.Drawing.Point(608, 514);
            this.btn_cleareventbox.Name = "btn_cleareventbox";
            this.btn_cleareventbox.Size = new System.Drawing.Size(147, 24);
            this.btn_cleareventbox.TabIndex = 21;
            this.btn_cleareventbox.Text = "&Clear Event Box";
            this.btn_cleareventbox.UseVisualStyleBackColor = true;
            this.btn_cleareventbox.Click += new System.EventHandler(this.btn_clearevents_Click);
            // 
            // eventsgrid
            // 
            this.eventsgrid.AllowUserToAddRows = false;
            this.eventsgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowid,
            this.extension,
            this.name,
            this.path,
            this.oldname,
            this.oldpath,
            this.eventtype,
            this.datetime});
            this.eventsgrid.Location = new System.Drawing.Point(58, 213);
            this.eventsgrid.Name = "eventsgrid";
            this.eventsgrid.ReadOnly = true;
            this.eventsgrid.RowTemplate.Height = 24;
            this.eventsgrid.Size = new System.Drawing.Size(697, 295);
            this.eventsgrid.TabIndex = 22;
            // 
            // rowid
            // 
            this.rowid.HeaderText = "Row ID";
            this.rowid.Name = "rowid";
            this.rowid.ReadOnly = true;
            // 
            // extension
            // 
            this.extension.HeaderText = "Extension";
            this.extension.Name = "extension";
            this.extension.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // path
            // 
            this.path.HeaderText = "Path";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            // 
            // oldname
            // 
            this.oldname.HeaderText = "Old Name";
            this.oldname.Name = "oldname";
            this.oldname.ReadOnly = true;
            // 
            // oldpath
            // 
            this.oldpath.HeaderText = "Old Path";
            this.oldpath.Name = "oldpath";
            this.oldpath.ReadOnly = true;
            // 
            // eventtype
            // 
            this.eventtype.HeaderText = "Event";
            this.eventtype.Name = "eventtype";
            this.eventtype.ReadOnly = true;
            // 
            // datetime
            // 
            this.datetime.HeaderText = "Date/Time";
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            // 
            // lbl_watcherresults
            // 
            this.lbl_watcherresults.AutoSize = true;
            this.lbl_watcherresults.Location = new System.Drawing.Point(58, 190);
            this.lbl_watcherresults.Name = "lbl_watcherresults";
            this.lbl_watcherresults.Size = new System.Drawing.Size(180, 17);
            this.lbl_watcherresults.TabIndex = 23;
            this.lbl_watcherresults.Text = "FileSystemWatcher Results";
            // 
            // stsp_status
            // 
            this.stsp_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_statuslabel,
            this.tslbl_status});
            this.stsp_status.Location = new System.Drawing.Point(0, 642);
            this.stsp_status.Name = "stsp_status";
            this.stsp_status.Size = new System.Drawing.Size(822, 22);
            this.stsp_status.TabIndex = 24;
            this.stsp_status.Text = "statusStrip1";
            // 
            // ts_statuslabel
            // 
            this.ts_statuslabel.ForeColor = System.Drawing.Color.Red;
            this.ts_statuslabel.Name = "ts_statuslabel";
            this.ts_statuslabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tslbl_status
            // 
            this.tslbl_status.Name = "tslbl_status";
            this.tslbl_status.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 664);
            this.Controls.Add(this.stsp_status);
            this.Controls.Add(this.lbl_watcherresults);
            this.Controls.Add(this.eventsgrid);
            this.Controls.Add(this.btn_cleareventbox);
            this.Controls.Add(this.grpbx_database);
            this.Controls.Add(this.grpbx_filewatcher);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "File System Watcher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpbx_filewatcher.ResumeLayout(false);
            this.grpbx_filewatcher.PerformLayout();
            this.grpbx_database.ResumeLayout(false);
            this.grpbx_database.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsgrid)).EndInit();
            this.stsp_status.ResumeLayout(false);
            this.stsp_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSystemWatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_extension;
        private System.Windows.Forms.Label lbl_directory;
        private System.Windows.Forms.Label lbl_dbextension;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_dbwrite;
        private System.Windows.Forms.Button btn_dbquery;
        private System.Windows.Forms.Button btn_dbclear;
        private System.Windows.Forms.ComboBox cmbx_extension;
        private System.Windows.Forms.ComboBox cmbx_dbextension;
        private System.Windows.Forms.GroupBox grpbx_filewatcher;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpbx_database;
        private System.Windows.Forms.ComboBox cmbx_directory;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtn_start;
        private System.Windows.Forms.ToolStripButton tsbtn_stop;
        private System.Windows.Forms.ToolStripButton tsbtn_storeevents;
        private System.Windows.Forms.ToolStripButton tsbtn_query;
        private System.Windows.Forms.ToolStripButton tsbtn_clear;
        private System.Windows.Forms.Button btn_cleareventbox;
        private System.Windows.Forms.ToolStripButton tsbtn_help;
        private System.Windows.Forms.ToolStripButton tsbtn_cleareventbox;
        private System.Windows.Forms.DataGridView eventsgrid;
        private System.Windows.Forms.Label lbl_watcherresults;
        private System.Windows.Forms.ToolStripMenuItem clearEventBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
        private System.Windows.Forms.DataGridViewTextBoxColumn extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldname;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.StatusStrip stsp_status;
        private System.Windows.Forms.ToolStripStatusLabel ts_statuslabel;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_status;
        private System.Windows.Forms.Button btn_browse;
    }
}

