

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Drawing;
using System.Windows.Forms;

namespace McoreSystem
{
    /// <summary>
    /// Summary description for cSingleInstance.
    /// </summary>
    public class AppInfo
    {

        private string mAppName;
        private string mLocalVersion;
        private string mRemoteVersion; // new version
        private string[] webVersion;
        private string[] localVersion;
        private string[] webProduct;
        private string[] mRelNotes;
        private int versionCount = 0;
        private bool mUpdated = false;

        //		private string strUpdateUrl;
        //		private string strUpdateFile;
        //		private string strUpdateMsg;

        public Icon AppIcon { get; set; }
        public Image AppImage { get; set; }

        private string mAppSuffix = "setup.zip";
        public string AppSuffix { get { return mAppSuffix; } set { mAppSuffix = value; } }

        private SoftwareCycle mSoftwareState = SoftwareCycle.FINAL;

        public SoftwareCycle ApplicationState
        {
            get { return mSoftwareState; }

        }


        #region "Enumerations"
        public enum VersionDepth
        {
            Major = 1,
            MajorMinor = 2,
            MajorMinorBuild = 3,
            MajorMinorBuildRevision = 4
        }

        public enum OutdatedMsgStyle
        {
            NewVersionOfAppAvailable,
            AppVerNumberAvailable,
            BetaVersionAvailble
        }

        public enum SoftwareCycle
        {
            ALPHA,
            BETA,
            FINAL
        }
        #endregion


        #region "Constructors"
        public AppInfo()
        {
            //
            // TODO: Add constructor logic here
            //		
        }

        public AppInfo(string ProductName, string Version)
        {
            this.mAppName = ProductName;
            this.mLocalVersion = Version;
        }


        public AppInfo(string ProductName, string Version, SoftwareCycle state)
        {
            this.mAppName = ProductName;
            this.mLocalVersion = Version;
            this.mSoftwareState = state;
        }

        #endregion

        public int GetNumberOfInstances()
        {
            string aModuleName = Process.GetCurrentProcess().MainModule.ModuleName;
            string aProcName = System.IO.Path.GetFileNameWithoutExtension(aModuleName);
            return Process.GetProcessesByName(aProcName).Length;

        }

        public string GetApplicationTitle()
        {
            //String[] version = this.mLocalVersion.Split('.');

            return this.GetApplicationTitle(this.mAppName, this.mLocalVersion);

            //return this.mAppName + " " + version[0] + "." + version[1] ;


        }

        public string GetApplicationTitleFull()
        {
            return this.mAppName + " " + mLocalVersion + " " + mSoftwareState.ToString();
        }


        public String GetApplicationTitle(string ProductName, string ProductVersion)
        {

            // Default Format: ApplicationTitle 1.0

            String[] version = ProductVersion.Split('.');

            string betaTag = "";
            switch (mSoftwareState)
            {
                case SoftwareCycle.ALPHA:
                    betaTag = " ALPHA";
                    break;
                case SoftwareCycle.BETA:
                    betaTag = " BETA";
                    break;
            }

            String title = ProductName + " " + version[0] + "." + version[1] + betaTag;

            return title;
        }


        public String GetApplicationTitle(string ProductName, string ProductVersion, VersionDepth Depth)
        {

            return ProductName + " " + GetVersion(ProductVersion, Depth);

        }

        public string GetVersion(VersionDepth Depth)
        {
            return GetVersion(GetRemoteVersion(), Depth);
        }

        public string GetVersion(string ProductVersion, VersionDepth Depth)
        {

            string title = "";
            int i;
            int d = System.Convert.ToInt32(Depth);
            String[] version = ProductVersion.Split('.');

            if (d > version.Length)
            {
                d = version.Length;
            }

            for (i = 0; i < d - 1; i++)
            {
                title += version[i] + ".";
            }
            title += version[i];

            return title;

        }


        private static bool fRemoteFileExits(string filePath, int retry)
        {
            while (retry > 0)
            {
                Uri objUrl = new Uri(filePath);
                System.Net.WebRequest objWebReq;
                System.Net.WebResponse objResp;
                try
                {
                    objWebReq = System.Net.WebRequest.Create(objUrl);
                    objResp = objWebReq.GetResponse(); objResp.Close();
                    objWebReq = null;
                    Console.WriteLine(string.Format("Found {0} before trying {1} times more...", filePath, retry.ToString()));
                    return true;
                }
                catch (Exception)
                {
                    objWebReq = null;
                    System.Threading.Thread.Sleep(5000);
                    retry--;
                    Console.WriteLine(string.Format("See if {0} exists... {1} times more...", filePath, retry.ToString()));
                    return fRemoteFileExits(filePath, retry);
                }
            }

            return false;

        }


        public bool fRemoteFileExits(string filePath)
        {
            return fRemoteFileExits(filePath, 3);
        }

        public bool isUpdated()
        {
            return mUpdated;
        }

        public bool isUpdated(string updateUrl)
        {

            versionCount = 0;  // IMPORTANT BUG FIX

            if (!mUpdated)
            {
                string updateDirName = Path.GetDirectoryName(updateUrl).Replace("\\", "/").Replace(":/", "://");
                string updateFileName = Path.GetFileName(updateUrl);

                mUpdated = isUpdated(updateDirName, updateFileName);
            }

            return mUpdated;

        }

        /// <summary>
        /// Checks all download directories and returns true if succesfully completed
        /// </summary>
        /// <param name="updateUrl"></param>
        /// <param name="downloadDirs">An array of download directories</param>
        /// <param name="appName"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        public bool CheckUpdates(string updateUrl, string[] downloadDirs, string appName, OutdatedMsgStyle style)
        {
            foreach (string dirName in downloadDirs)
            {
                if (CheckUpdates(updateUrl, dirName, appName, style))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckUpdates(string updateUrl, string downloadDirName, string appName, OutdatedMsgStyle style)
        {
            bool succ = false;

            if (isUpdated(updateUrl) == true)
            {

                string downloadUrl = String.Empty;
                bool foundBeta = false;

                // check for beta
                // the new method as in sourceforge
                string downloadFileBetaName = string.Format("{0}-{1}-{2}", appName, GetVersion(VersionDepth.MajorMinorBuildRevision), "setup.zip");

                downloadUrl = downloadDirName + downloadFileBetaName;

                if (fRemoteFileExits(downloadUrl))
                {
                    foundBeta = true;
                }

                else
                {
                    // look for old method : sub folder with /beta/
                    downloadUrl = Path.Combine(downloadDirName, "beta/") + downloadFileBetaName;

                    if (fRemoteFileExits(downloadUrl))
                    {
                        foundBeta = true;
                    }
                }

                succ = foundBeta;

                if (foundBeta == true)
                {
                    DialogResult ans = DialogResult.No;
                    if (mRelNotes != null)
                    {
                        frmVer v = new frmVer(this.AppIcon, this.AppImage,
                            getMsgOutdated(mAppName, OutdatedMsgStyle.BetaVersionAvailble, false),
                            mRelNotes);
                        v.Text = this.GetApplicationTitle(this.mAppName, GetRemoteVersion(), VersionDepth.MajorMinorBuildRevision) + " BETA";
                        v.ShowDialog();
                        ans = v.DialogResult;
                    }
                    else
                    {
                        ans = MessageBox.Show(getMsgOutdated(mAppName, OutdatedMsgStyle.BetaVersionAvailble, true), mAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (ans == DialogResult.Yes)
                    {
                        Process.Start(downloadUrl);
                    }
                }

                else // updated beta is not found
                {

                    string downloadFileName = string.Empty;

                    if (appName != string.Empty)
                    {
                        downloadFileName = string.Format("{0}-{1}-{2}", appName, GetVersion(VersionDepth.MajorMinor), this.AppSuffix);

                        if (!downloadDirName[downloadDirName.Length - 1].Equals('/'))
                        {
                            downloadDirName = downloadDirName + "/";
                        }
                    }

                    downloadUrl = downloadDirName + downloadFileName;

                    if (fRemoteFileExits(downloadUrl))
                    {
                        // update is final
                        DialogResult ans = DialogResult.No;
                        if (mRelNotes != null)
                        {
                            frmVer v = new frmVer(this.AppIcon, this.AppImage,
                                            getMsgOutdated(mAppName, OutdatedMsgStyle.BetaVersionAvailble, false),
                                            mRelNotes);
                            v.Text = this.GetApplicationTitle(this.mAppName, GetRemoteVersion(), VersionDepth.MajorMinorBuildRevision);
                            v.ShowDialog();
                            ans = v.DialogResult;
                        }
                        else
                        {
                            ans = MessageBox.Show(getMsgOutdated(mAppName, style, true), mAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        if (ans == DialogResult.Yes)
                        {
                            Process.Start(downloadUrl);
                        }
                        succ = true;
                    }

                }

            }

            else
            {
                MessageBox.Show(getMsgUpToDate(), mAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                succ = true;
            }

            return succ;
        }

        public string GetLocalVersion()
        {
            return this.mLocalVersion;
        }

        public string GetRemoteVersion()
        {
            return this.mRemoteVersion;
        }

        private bool isUpdated(int web, int local)
        {
            if (web > local)
            {
                this.mRemoteVersion = webProduct[1];
                return true;
            }
            else if (web < local)
            {
                this.mRemoteVersion = webProduct[1];
                return false;
            }
            else
            {
                if (++versionCount < 4)
                {
                    return isUpdated(System.Convert.ToInt32(webVersion[versionCount]),
                        System.Convert.ToInt32(localVersion[versionCount]));
                }
                else
                {
                    this.mRemoteVersion = webProduct[1];
                    return false;
                }
            }

        }

        private string getMsgStatistics()
        {
            return String.Format("\n\nLocal Version: {0} \nRemote Version: {1}", GetLocalVersion(), GetRemoteVersion());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="style"></param>
        /// <param name="history">Whether to include Version History</param>
        /// <returns></returns>
        public string getMsgOutdated(string app, OutdatedMsgStyle style, bool history)
        {

            string msg = "";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (history)
            {
                if (null != mRelNotes)
                {
                    sb.AppendLine();
                    sb.AppendLine();
                    foreach (string var in mRelNotes)
                    {
                        sb.AppendLine(string.Format("* {0}", var));
                    }
                }
            }

            switch (style)
            {
                case OutdatedMsgStyle.AppVerNumberAvailable:
                    msg = app + " " + GetRemoteVersion() + " is available.\nWould you like to download it now?";
                    break;
                case OutdatedMsgStyle.NewVersionOfAppAvailable:
                    msg = string.Format("New version of {0} is available.{1}\nWould you like to download it now?", app, sb.ToString());
                    break;
                case OutdatedMsgStyle.BetaVersionAvailble:
                    msg = String.Format("A beta version of {0} is available.{1}\nWould you like to download it now?", mAppName, sb.ToString());
                    break;
            }

            return msg + getMsgStatistics();
        }



        public string getMsgUpToDate()
        {
            return String.Format("The current version is up-to-date. {0}", getMsgStatistics());
        }

        private bool isUpdated(string address, string fileName)
        {

            string tempFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + fileName;
            WebClient myWebClient = new System.Net.WebClient();
            try
            {
                Console.WriteLine("Checking Updates from " + address + "/" + fileName);
                //System.Windows.Forms.MessageBox.Show("'"+address+fileName+"'");	
                myWebClient.DownloadFile(address + "/" + fileName, tempFile);
                StreamReader sr = System.IO.File.OpenText(tempFile);
                string[] product = sr.ReadToEnd().Trim().Split(';');
                sr.Close();
                System.IO.File.Delete(tempFile);

                for (int i = 0; i < product.Length; i++)
                {
                    webProduct = product[i].Split('=');
                    if (this.mAppName.Equals(webProduct[0].Trim()))
                    {
                        webVersion = webProduct[1].Split('.');
                        localVersion = this.mLocalVersion.Split('.');
                        bool[] booUpdated = new bool[webVersion.Length];

                        if (webVersion.Length == localVersion.Length)
                        {

                            bool bUpdated = isUpdated(System.Convert.ToInt32(webVersion[0]),
                                System.Convert.ToInt32(localVersion[0]));

                            if (bUpdated)
                            {
                                // add release notes
                                if (webProduct.Length > 2)
                                {
                                    if (fRemoteFileExits(webProduct[2].Trim(), 1))
                                    {
                                        string relNotes = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rel.txt");
                                        WebClient wc = new System.Net.WebClient();
                                        wc.DownloadFile(webProduct[2].Trim(), relNotes);
                                        using (StreamReader srRel = new StreamReader(relNotes))
                                        {
                                            mRelNotes = System.Text.RegularExpressions.Regex.Split(srRel.ReadToEnd().Trim(), "\n");
                                        }
                                    }
                                    else
                                    {
                                        mRelNotes = webProduct[2].Trim().Split('*');
                                    }
                                }
                            }

                            return bUpdated;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;

        }

    }
}
