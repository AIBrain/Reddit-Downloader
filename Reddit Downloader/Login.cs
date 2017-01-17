using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditDownloader
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private Helper helper;

        public Login()
        {
            InitializeComponent();
            if (!Directory.Exists(Helper.APPDATAFOLDER))
                Directory.CreateDirectory(Helper.APPDATAFOLDER);
            helper = new Helper(this);
            pictureBox1.Image = Properties.Resources.settingsGrey;
        }

        #region UI Handling

        private void Login_Load(object sender, EventArgs e)
        {
            helper.loadConfig();
            helper.loadSubList();
            if (helper.config.nightMode)
                helper.setNightMode(true);
            else
                helper.setNightMode(false);
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            helper.saveSubList();
            helper.saveConfig();
        }
        private void subNSFW_CheckedChanged(object sender, EventArgs e)
        {
            if (subComboBox.SelectedItem != null)
            {
                helper.nsfwCheckChange(subComboBox.SelectedItem.ToString());
            }
        }
        private void subComboBox_DropDown(object sender, EventArgs e)
        {
            subComboBox.Items.Clear();
            if (helper.subsToSave != null)
            {
                foreach (RedditSub sub in helper.subsToSave)
                {
                    subComboBox.Items.Add(sub.subName);
                }
            }
        }
        private void subComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subComboBox.SelectedItem != null)
            {
                RedditSub redditSub = helper.subsToSave.Where(s => s.subName == subComboBox.SelectedItem.ToString()).FirstOrDefault();
                subNSFW.Checked = redditSub.nsfw;
                subDirectoryTextbox.Text = redditSub.directory;
            }
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (timer1.Interval != 900000)
                timer1.Interval = 900000;
            new Task(helper.downloadSaved).Start();
        }
        private void Login_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Hide();
            }
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        #region Click
        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=4KPEKYFJP9XW6");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(btnSender.Width, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);
        }
        private void loginButton_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTextbox.Text) && !string.IsNullOrEmpty(passwordTextbox.Text))
            {
                try
                {
                    helper.logIn(usernameTextbox.Text, passwordTextbox.Text);
                }
                catch
                {
                    MessageBox.Show("Failed to login!");
                }
            }
            else
                MessageBox.Show("You need to enter your username and password!");
        }
        private void logoutButton_Click(object sender, System.EventArgs e)
        {
            helper.logOut();
        }
        private void removeSubButton_Click(object sender, EventArgs e)
        {
            if (subComboBox.SelectedItem != null)
            {
                helper.removeSub(subComboBox.SelectedItem.ToString());
            }
        }
        private void addSubButton_Click(object sender, EventArgs e)
        {
            AddSub AS = new AddSub(this);
            if (AS.ShowDialog() == DialogResult.OK)
            {
                string subName = AS.subTextbox.Text;
                bool nsfw = AS.nsfwCheckBox.Checked;
                string subDirectory = AS.subDirectoryTextbox.Text;
                RedditSub sub = new RedditSub() { subName = AS.subTextbox.Text, nsfw = AS.nsfwCheckBox.Checked, directory = AS.subDirectoryTextbox.Text };
                helper.subsToSave.Add(sub);
            }
            AS.Dispose();
        }
        private void changeRootButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                rootDirectoryTextbox.Text = folderBrowserDialog1.SelectedPath;
                helper.config.rootDirectory = folderBrowserDialog1.SelectedPath;
            }
            folderBrowserDialog1.Dispose();
        }
        private void changeCustomDirectoryButton_Click(object sender, EventArgs e)
        {
            if (subComboBox.SelectedItem != null && folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                subDirectoryTextbox.Text = folderBrowserDialog1.SelectedPath;
                RedditSub redditSub = helper.subsToSave.Where(s => s.subName == subComboBox.SelectedItem.ToString()).First();
                helper.subsToSave.Remove(redditSub);
                redditSub.directory = folderBrowserDialog1.SelectedPath;
                helper.subsToSave.Add(redditSub);
            }
            folderBrowserDialog1.Dispose();
        }
        #endregion

        #region ToolStripMenuItem
        private void openRootDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", rootDirectoryTextbox.Text);
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Task(helper.downloadSaved).Start();
        }
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void nightModeToolStripMenuItem_CheckedChanged(object sender, System.EventArgs e)
        {
            helper.setNightMode(nightModeToolStripMenuItem.Checked);
        }
        #endregion

        #endregion
    }

    public class RedditSub
    {
        public string subName { get; set; }
        public bool nsfw { get; set; }
        public string directory { get; set; }
    }

    public class Config
    {
        public bool nightMode { get; set; }
        public string rootDirectory { get; set; }
    }
}
