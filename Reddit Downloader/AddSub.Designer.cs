namespace RedditDownloader
{
    partial class AddSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSub));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.subTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nsfwCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.subDirectoryTextbox = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.chooseDirectoryButton = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // subTextbox
            // 
            this.subTextbox.Location = new System.Drawing.Point(141, 63);
            this.subTextbox.Name = "subTextbox";
            this.subTextbox.Size = new System.Drawing.Size(196, 23);
            this.subTextbox.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Subreddit Name";
            // 
            // nsfwCheckBox
            // 
            this.nsfwCheckBox.AutoSize = true;
            this.nsfwCheckBox.Location = new System.Drawing.Point(343, 67);
            this.nsfwCheckBox.Name = "nsfwCheckBox";
            this.nsfwCheckBox.Size = new System.Drawing.Size(55, 15);
            this.nsfwCheckBox.TabIndex = 2;
            this.nsfwCheckBox.Text = "NSFW";
            this.nsfwCheckBox.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Custom Directory";
            // 
            // subDirectoryTextbox
            // 
            this.subDirectoryTextbox.Location = new System.Drawing.Point(141, 92);
            this.subDirectoryTextbox.Name = "subDirectoryTextbox";
            this.subDirectoryTextbox.Size = new System.Drawing.Size(151, 23);
            this.subDirectoryTextbox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(23, 121);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(257, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(286, 121);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // chooseDirectoryButton
            // 
            this.chooseDirectoryButton.Location = new System.Drawing.Point(298, 92);
            this.chooseDirectoryButton.Name = "chooseDirectoryButton";
            this.chooseDirectoryButton.Size = new System.Drawing.Size(100, 23);
            this.chooseDirectoryButton.TabIndex = 7;
            this.chooseDirectoryButton.Text = "Choose Directory";
            this.chooseDirectoryButton.Click += new System.EventHandler(this.chooseDirectoryButton_Click);
            // 
            // AddSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 169);
            this.ControlBox = false;
            this.Controls.Add(this.chooseDirectoryButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subDirectoryTextbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.nsfwCheckBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.subTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddSub";
            this.Resizable = false;
            this.Text = "AddSub";
            this.Load += new System.EventHandler(this.AddSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button addButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton chooseDirectoryButton;
        public MetroFramework.Controls.MetroTextBox subTextbox;
        public MetroFramework.Controls.MetroCheckBox nsfwCheckBox;
        public MetroFramework.Controls.MetroTextBox subDirectoryTextbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}