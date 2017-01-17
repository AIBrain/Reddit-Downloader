namespace RedditDownloader
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.usernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.logoutButton = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rootDirectoryTextbox = new MetroFramework.Controls.MetroTextBox();
            this.changeRootButton = new MetroFramework.Controls.MetroButton();
            this.addSubButton = new MetroFramework.Controls.MetroButton();
            this.removeSubButton = new MetroFramework.Controls.MetroButton();
            this.subComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.subNSFW = new MetroFramework.Controls.MetroCheckBox();
            this.subDirectoryTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.changeCustomDirectoryButton = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openRootDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(99, 63);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(168, 23);
            this.usernameTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(99, 92);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(168, 23);
            this.passwordTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(273, 63);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(87, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // logoutButton
            // 
            this.logoutButton.Enabled = false;
            this.logoutButton.Location = new System.Drawing.Point(273, 92);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(87, 23);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveNowToolStripMenuItem,
            this.nightModeToolStripMenuItem,
            this.openRootDirectoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 120);
            // 
            // saveNowToolStripMenuItem
            // 
            this.saveNowToolStripMenuItem.Enabled = false;
            this.saveNowToolStripMenuItem.Name = "saveNowToolStripMenuItem";
            this.saveNowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveNowToolStripMenuItem.Text = "Save Now!";
            this.saveNowToolStripMenuItem.Click += new System.EventHandler(this.saveNowToolStripMenuItem_Click);
            // 
            // nightModeToolStripMenuItem
            // 
            this.nightModeToolStripMenuItem.CheckOnClick = true;
            this.nightModeToolStripMenuItem.Name = "nightModeToolStripMenuItem";
            this.nightModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nightModeToolStripMenuItem.Text = "Night Mode";
            this.nightModeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.nightModeToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rootDirectoryTextbox
            // 
            this.rootDirectoryTextbox.Location = new System.Drawing.Point(25, 147);
            this.rootDirectoryTextbox.Name = "rootDirectoryTextbox";
            this.rootDirectoryTextbox.ReadOnly = true;
            this.rootDirectoryTextbox.Size = new System.Drawing.Size(216, 23);
            this.rootDirectoryTextbox.TabIndex = 6;
            this.rootDirectoryTextbox.Text = "Reddit";
            // 
            // changeRootButton
            // 
            this.changeRootButton.Location = new System.Drawing.Point(247, 147);
            this.changeRootButton.Name = "changeRootButton";
            this.changeRootButton.Size = new System.Drawing.Size(113, 23);
            this.changeRootButton.TabIndex = 7;
            this.changeRootButton.Text = "Change Root Folder";
            this.changeRootButton.Click += new System.EventHandler(this.changeRootButton_Click);
            // 
            // addSubButton
            // 
            this.addSubButton.Location = new System.Drawing.Point(25, 176);
            this.addSubButton.Name = "addSubButton";
            this.addSubButton.Size = new System.Drawing.Size(161, 23);
            this.addSubButton.TabIndex = 8;
            this.addSubButton.Text = "Add Subreddit";
            this.addSubButton.Click += new System.EventHandler(this.addSubButton_Click);
            // 
            // removeSubButton
            // 
            this.removeSubButton.Location = new System.Drawing.Point(199, 176);
            this.removeSubButton.Name = "removeSubButton";
            this.removeSubButton.Size = new System.Drawing.Size(161, 23);
            this.removeSubButton.TabIndex = 9;
            this.removeSubButton.Text = "Remove Subreddit";
            this.removeSubButton.Click += new System.EventHandler(this.removeSubButton_Click);
            // 
            // subComboBox
            // 
            this.subComboBox.FormattingEnabled = true;
            this.subComboBox.ItemHeight = 23;
            this.subComboBox.Location = new System.Drawing.Point(99, 233);
            this.subComboBox.Name = "subComboBox";
            this.subComboBox.Size = new System.Drawing.Size(200, 29);
            this.subComboBox.TabIndex = 10;
            this.subComboBox.DropDown += new System.EventHandler(this.subComboBox_DropDown);
            this.subComboBox.SelectedIndexChanged += new System.EventHandler(this.subComboBox_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 239);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Subreddit";
            // 
            // subNSFW
            // 
            this.subNSFW.AutoSize = true;
            this.subNSFW.Location = new System.Drawing.Point(305, 239);
            this.subNSFW.Name = "subNSFW";
            this.subNSFW.Size = new System.Drawing.Size(55, 15);
            this.subNSFW.TabIndex = 12;
            this.subNSFW.Text = "NSFW";
            this.subNSFW.UseVisualStyleBackColor = true;
            this.subNSFW.CheckedChanged += new System.EventHandler(this.subNSFW_CheckedChanged);
            // 
            // subDirectoryTextbox
            // 
            this.subDirectoryTextbox.Location = new System.Drawing.Point(143, 268);
            this.subDirectoryTextbox.Name = "subDirectoryTextbox";
            this.subDirectoryTextbox.ReadOnly = true;
            this.subDirectoryTextbox.Size = new System.Drawing.Size(217, 23);
            this.subDirectoryTextbox.TabIndex = 13;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Custom Directory";
            // 
            // changeCustomDirectoryButton
            // 
            this.changeCustomDirectoryButton.Location = new System.Drawing.Point(25, 297);
            this.changeCustomDirectoryButton.Name = "changeCustomDirectoryButton";
            this.changeCustomDirectoryButton.Size = new System.Drawing.Size(335, 23);
            this.changeCustomDirectoryButton.TabIndex = 15;
            this.changeCustomDirectoryButton.Text = "Change Directory";
            this.changeCustomDirectoryButton.Click += new System.EventHandler(this.changeCustomDirectoryButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Reddit Downloader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLink1.Location = new System.Drawing.Point(127, 326);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(233, 23);
            this.metroLink1.TabIndex = 16;
            this.metroLink1.Text = "If you like this, please consider donating!";
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openRootDirectoryToolStripMenuItem
            // 
            this.openRootDirectoryToolStripMenuItem.Name = "openRootDirectoryToolStripMenuItem";
            this.openRootDirectoryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openRootDirectoryToolStripMenuItem.Text = "Open Root Directory";
            this.openRootDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openRootDirectoryToolStripMenuItem_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.changeCustomDirectoryButton);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.subDirectoryTextbox);
            this.Controls.Add(this.subNSFW);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.subComboBox);
            this.Controls.Add(this.removeSubButton);
            this.Controls.Add(this.addSubButton);
            this.Controls.Add(this.changeRootButton);
            this.Controls.Add(this.rootDirectoryTextbox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Reddit Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox usernameTextbox;
        private MetroFramework.Controls.MetroTextBox passwordTextbox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroButton changeRootButton;
        private MetroFramework.Controls.MetroButton removeSubButton;
        private MetroFramework.Controls.MetroButton addSubButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton changeCustomDirectoryButton;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public MetroFramework.Controls.MetroTextBox rootDirectoryTextbox;
        public MetroFramework.Controls.MetroTextBox subDirectoryTextbox;
        public MetroFramework.Controls.MetroButton loginButton;
        public MetroFramework.Controls.MetroButton logoutButton;
        public System.Windows.Forms.Timer timer1;
        public MetroFramework.Controls.MetroCheckBox subNSFW;
        public MetroFramework.Controls.MetroComboBox subComboBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem nightModeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRootDirectoryToolStripMenuItem;
    }
}

