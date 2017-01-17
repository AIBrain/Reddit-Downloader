using ImgDownloading;
using Newtonsoft.Json;
using RedditSharp;
using RedditSharp.Things;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditDownloader
{
    class Helper
    {
        public static string APPDATAFOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Reddit Downloader");
        private string SUBLISTFILENAME = Path.Combine(APPDATAFOLDER, "sublist.txt");
        private string CONFIGFILENAME = Path.Combine(APPDATAFOLDER, "config.txt");

        private Reddit reddit = new Reddit();
        private AuthenticatedUser user;
        public List<RedditSub> subsToSave = new List<RedditSub>();
        public Config config = new Config();
        private ImageDownloading ID = new ImageDownloading();
        private Login _login;

        public Helper(Login login)
        {
            _login = login;
        }

        public void createFolder(string path, bool nsfw)
        {
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                if (nsfw)
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
        }
        public void downloadSaved()
        {
            Listing<VotableThing> savedPosts = user.GetSaved();
            foreach (VotableThing savedPost in savedPosts)
            {
                Post post = (Post)savedPost;
                if (subsToSave.Where(s => s.subName == post.SubredditName).Count() == 1)
                {
                    RedditSub subToSave = subsToSave.Where(s => s.subName == post.SubredditName).First();
                    if (!post.IsSelfPost && ID.isImageUrl(post.Url.ToString()))
                    {
                        string savePath;
                        if (string.IsNullOrEmpty(subToSave.directory))
                            savePath = Path.Combine(_login.rootDirectoryTextbox.Text, ID.removeIllegalChars(post.SubredditName));
                        else
                            savePath = Path.Combine(subToSave.directory, ID.removeIllegalChars(post.SubredditName));
                        createFolder(savePath, subToSave.nsfw);
                        string name = Path.Combine(savePath, ID.removeIllegalChars(post.Title) + ID.imageType(post.Url.ToString()));
                        ID.saveImage(name, post.Url.ToString(), subToSave.nsfw);
                    }
                    else if (!post.IsSelfPost && ID.isImgurAlbumLink(post.Url.ToString()))
                    {
                        string savePath;
                        if (string.IsNullOrEmpty(subToSave.directory))
                        {
                            createFolder(Path.Combine(_login.rootDirectoryTextbox.Text, ID.removeIllegalChars(post.SubredditName)), subToSave.nsfw);
                            savePath = Path.Combine(_login.rootDirectoryTextbox.Text, ID.removeIllegalChars(post.SubredditName), ID.removeIllegalChars(post.Title));
                        }
                        else
                        {
                            createFolder(Path.Combine(subToSave.directory, ID.removeIllegalChars(post.SubredditName)), subToSave.nsfw);
                            savePath = Path.Combine(subToSave.directory, ID.removeIllegalChars(post.SubredditName), ID.removeIllegalChars(post.Title));
                        }
                        createFolder(savePath, subToSave.nsfw);
                        ID.downloadImgurAlbum(savePath, post.Url.ToString(), subToSave.nsfw);
                    }
                }
            }
        }
        public void loadSubList()
        {
            if (File.Exists(SUBLISTFILENAME))
            {
                List<string> subList = new List<string>(File.ReadAllLines(SUBLISTFILENAME));
                foreach (string sub in subList)
                {
                    subsToSave.Add(JsonConvert.DeserializeObject<RedditSub>(sub));
                }
            }
        }
        public void saveSubList()
        {
            List<string> subList = new List<string>();
            foreach (RedditSub sub in subsToSave)
            {
                subList.Add(JsonConvert.SerializeObject(sub));
            }
            File.WriteAllLines(SUBLISTFILENAME, subList);
        }
        public void loadConfig()
        {
            if (File.Exists(CONFIGFILENAME))
            {
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(CONFIGFILENAME));
                _login.nightModeToolStripMenuItem.Checked = config.nightMode;
                if (!string.IsNullOrEmpty(config.rootDirectory))
                    _login.rootDirectoryTextbox.Text = config.rootDirectory;
            }
        }
        public void saveConfig()
        {
            File.WriteAllText(CONFIGFILENAME, JsonConvert.SerializeObject(config));
        }
        public void setNightMode(bool shouldSet)
        {
            if (shouldSet)
            {
                _login.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                _login.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            config.nightMode = shouldSet;
        }
        public void logIn(string username, string password)
        {
            user = reddit.LogIn(username, password);
            _login.loginButton.Enabled = false;
            _login.logoutButton.Enabled = true;
            _login.saveNowToolStripMenuItem.Enabled = true;
            _login.timer1.Start();
        }
        public void logOut()
        {
            user = null;
            _login.loginButton.Enabled = true;
            _login.logoutButton.Enabled = false;
            _login.saveNowToolStripMenuItem.Enabled = false;
            _login.timer1.Stop();
        }
        public void removeSub(string sub)
        {
            subsToSave.Remove(subsToSave.Where(s => s.subName == sub).Select(s => s).First());
            _login.subComboBox.SelectedItem = null;
            _login.subNSFW.Checked = false;
            _login.subDirectoryTextbox.Text = null;
        }
        public void nsfwCheckChange(string sub)
        {
            RedditSub redditSub = subsToSave.Where(s => s.subName == sub).First();
            subsToSave.Remove(redditSub);
            redditSub.nsfw = _login.subNSFW.Checked;
            subsToSave.Add(redditSub);
        }
    }
}
