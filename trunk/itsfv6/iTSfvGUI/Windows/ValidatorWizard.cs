﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTSfvLib;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections;
using System.Threading;
using System.Reflection;

namespace iTSfvGUI
{
    public partial class ValidatorWizard : Form
    {
        Dictionary<string, CheckBox> dicCheckBoxes = new Dictionary<string, CheckBox>();
        BackgroundWorker AddFilesWorker = new BackgroundWorker() { WorkerReportsProgress = true };

        public ValidatorWizard()
        {
            InitializeComponent();
        }

        private void LoadDictionaryCheckBoxes(FlowLayoutPanel flp)
        {
            foreach (Control ctl in flp.Controls)
            {
                if (ctl is CheckBox)
                    dicCheckBoxes.Add(ctl.Name, ctl as CheckBox);
            }
        }

        public void SettingsReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadDictionaryCheckBoxes(flpChecks);
            LoadDictionaryCheckBoxes(flpTracks);
            LoadDictionaryCheckBoxes(flpFileSystem);

            PropertyInfo[] properties = typeof(UserConfig).GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                string checkBoxName = "chk" + pi.Name;
                if (pi.PropertyType == typeof(Boolean) && dicCheckBoxes.ContainsKey(checkBoxName))
                {
                    CheckBox chk = dicCheckBoxes[checkBoxName];
                    chk.Checked = (bool)pi.GetValue(Program.Config.UI, null);
                }
            }

            Program.Library = new XmlLibrary(Program.Config);
            Program.LogViewer.Show();
        }

        /// <summary>
        /// Returns a UserConfig object based on the checkbox configuration
        /// </summary>
        /// <param name="userConfig"></param>
        /// <returns></returns>
        private UserConfig SaveUserConfig(UserConfig userConfig = null)
        {
            if (userConfig == null)
                userConfig = new UserConfig(); 

            IEnumerator e = dicCheckBoxes.GetEnumerator();
            KeyValuePair<string, CheckBox> kvp = new KeyValuePair<string, CheckBox>();

            while (e.MoveNext())
            {
                kvp = (KeyValuePair<string, CheckBox>)e.Current;
                CheckBox chk = kvp.Value as CheckBox;
                PropertyInfo[] properties = typeof(UserConfig).GetProperties();
                foreach (PropertyInfo pi in properties)
                {
                    string propName = chk.Name.Remove(0, 3);
                    if (pi.PropertyType == typeof(Boolean) && pi.Name.Equals(propName))
                    {
                        pi.SetValue(userConfig, chk.Checked, null);
                        break;
                    }
                }
            }

            return userConfig;
        }

        private void ValidatorWizard_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} {1}", Application.ProductName, Application.ProductVersion);
        }

        private void ValidatorWizard_Move(object sender, EventArgs e)
        {
            UpdateLogViewPos();
        }

        private void UpdateLogViewPos()
        {
            if (null != Program.LogViewer)
            {
                Program.LogViewer.Width = this.Width;
                Program.LogViewer.Location = new Point(this.Location.X, this.Location.Y + this.Height);
            }
        }

        private void miTasksAddFiles_Click(object sender, EventArgs e)
        {
            AddFiles();
        }

        private void AddFiles(bool respectFolderStructure = false)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog("Add files or a folder...")
            {
                Multiselect = true,
                IsFolderPicker = true
            };

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (respectFolderStructure)
                    ShowAddFilesWizard(dlg.FileNames.ToArray());
                else
                    AddFilesFolders(dlg.FileNames.ToArray());
            }
        }

        private void lbDiscs_DragDrop(object sender, DragEventArgs e)
        {
            var pathsFilesFolders = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            AddFilesFolders(pathsFilesFolders);
        }

        private void AddFilesFolders(string[] filesDirs)
        {
            AddFilesWorker.DoWork += AddFilesWorker_DoWork;
            AddFilesWorker.ProgressChanged += Program.LogViewer.AddFilesWorker_ProgressChanged;
            AddFilesWorker.RunWorkerCompleted += AddFilesWorker_RunWorkerCompleted;

            AddFilesWorker.RunWorkerAsync(filesDirs);
        }

        void AddFilesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tvLibrary.Nodes.Clear();

            foreach (XmlAlbumArtist band in Program.Library.AlbumArtists)
            {
                TreeNode tnAlbumArtist = new TreeNode(band.Name) { Tag = band };

                IEnumerator i = band.Albums.GetEnumerator();
                KeyValuePair<string, XmlAlbum> kvpAlbum = new KeyValuePair<string, XmlAlbum>();

                while (i.MoveNext())
                {
                    kvpAlbum = (KeyValuePair<string, XmlAlbum>)i.Current;
                    tnAlbumArtist.Nodes.Add(new TreeNode(kvpAlbum.Value.GetAlbumName()) { Tag = kvpAlbum.Value });
                }

                tvLibrary.Nodes.Add(tnAlbumArtist);
            }

            Program.LogViewer.AddFilesWorker_RunWorkerCompleted();
        }

        void AddFilesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            AddFilesWorker.ReportProgress(0);
            Program.Library.AddFilesOrFolders(e.Argument as string[]);
        }

        private void lbDiscs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbDiscs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDiscs.SelectedIndex > -1)
            {
                XmlDisc tempDisc = lbDiscs.SelectedItem as XmlDisc;
                ttApp.SetToolTip(lbDiscs, tempDisc.ToTracklistString());
            }
        }

        #region Helpers

        public void ShowAddFilesWizard(string[] filesDirs)
        {
            AddFilesWizard afw = new AddFilesWizard(filesDirs);
            afw.ShowDialog();

            AddFilesFolders(filesDirs);
        }

        #endregion Helpers

        private void tsmiOptions_Click(object sender, EventArgs e)
        {
            OptionsWindow dlg = new OptionsWindow(Program.Config);
            dlg.ShowDialog();
        }

        private void lbDiscs_MouseDown(object sender, MouseEventArgs e)
        {
            lbDiscs.SelectedIndex = lbDiscs.IndexFromPoint(e.X, e.Y);

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //now show your context menu...
            }
        }

        private void tvLibrary_Click(object sender, EventArgs e)
        {
            // nothing
        }

        private void tvLibrary_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode tn = e.Node;
            if (tn.Tag is XmlAlbum)
            {
                XmlAlbum album = tn.Tag as XmlAlbum;
                lbDiscs.Items.Clear();

                IEnumerator iDisc = album.Discs.GetEnumerator();
                KeyValuePair<string, XmlDisc> kvpDisc = new KeyValuePair<string, XmlDisc>();

                while (iDisc.MoveNext())
                {
                    kvpDisc = (KeyValuePair<string, XmlDisc>)iDisc.Current;
                    lbDiscs.Items.Add(kvpDisc.Value);
                }
            }
        }

        private void ValidatorWizard_Resize(object sender, EventArgs e)
        {
            UpdateLogViewPos();
        }

        private void tsmiTasksValidate_Click(object sender, EventArgs e)
        {
            RunTasks();
        }

        private void RunTasks()
        {
            Program.TreadUI = SynchronizationContext.Current;

            UserConfig userConfig = SaveUserConfig();

            if (UserConfig.IsConfigured(userConfig))
            {
                XmlLibrary selectedLibrary = new XmlLibrary(Program.Config);

                if (lbDiscs.SelectedItem != null)
                {
                    if (lbDiscs.SelectedItem is XmlDisc)
                    {
                        XmlDisc disc = lbDiscs.SelectedItem as XmlDisc;
                        disc.Tracks.ToList().ForEach(x => selectedLibrary.AddTrack(x));
                    }
                }
                else if (tvLibrary.SelectedNode != null)
                {
                    if (tvLibrary.SelectedNode.Tag is XmlAlbumArtist)
                    {
                        XmlAlbumArtist band = tvLibrary.SelectedNode.Tag as XmlAlbumArtist;
                        band.GetTracks().ToList().ForEach(x => selectedLibrary.AddTrack(x));
                    }
                    else if (tvLibrary.SelectedNode.Tag is XmlAlbum)
                    {
                        XmlAlbum album = tvLibrary.SelectedNode.Tag as XmlAlbum;
                        album.GetTracks().ToList().ForEach(x => selectedLibrary.AddTrack(x));
                    }
                }
                else
                {
                    selectedLibrary = Program.Library; // if nothing is selected then validate entire library
                }

                Program.LogViewer.BindWorker(selectedLibrary.Worker);
                selectedLibrary.RunTasks();
            }
        }

        private void ValidatorWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUserConfig(Program.Config.UI);
        }

        private void tsmiFile_AddFilesWithStructure_Click(object sender, EventArgs e)
        {
            AddFiles(respectFolderStructure: true);
        }

        private void tsmiFoldersLogs_Click(object sender, EventArgs e)
        {
            HelpersLib.Helpers.OpenFolder(Program.LogsFolderPath);
        }
    }
}