using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditDownloader
{
    public partial class AddSub : MetroFramework.Forms.MetroForm
    {
        public Login _login;

        public AddSub(Login login)
        {
            InitializeComponent();
            this._login = login;
        }

        private void AddSub_Load(object sender, EventArgs e)
        {
            metroStyleManager1.Style = _login.metroStyleManager1.Style;
            metroStyleManager1.Theme = _login.metroStyleManager1.Theme;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(subTextbox.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chooseDirectoryButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                subDirectoryTextbox.Text = folderBrowserDialog1.SelectedPath;
            }
            folderBrowserDialog1.Dispose();
        }
    }
}
