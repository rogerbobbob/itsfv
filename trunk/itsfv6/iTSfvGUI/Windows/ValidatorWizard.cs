using System;
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

namespace iTSfvGUI
{
    public partial class ValidatorWizard : Form
    {
        public ValidatorWizard()
        {
            InitializeComponent();
        }

        private void ValidatorWizard_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} {1}", Application.ProductName, Application.ProductVersion);
            Program.Config = new XMLSettings(); // todo: background worker
        }

        private void ValidatorWizard_Shown(object sender, EventArgs e)
        {
            Program.LogViewer.Show();
            Program.Library = new XmlLibrary(Program.Config);
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
            CommonOpenFileDialog dlg = new CommonOpenFileDialog("Add files or a folder...")
            {
                Multiselect = true,
                IsFolderPicker = true
            };

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                AddFilesFolders(dlg.FileNames.ToArray());
                // ShowAddFilesWizard(new string[] { dlg.FileName });
            }
        }

        private void lbDiscs_DragDrop(object sender, DragEventArgs e)
        {
            var pathsFilesFolders = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            ShowAddFilesWizard(pathsFilesFolders);
            // AddFilesFolders(pathsFilesFolders);
        }

        private void AddFilesFolders(string[] filesDirs)
        {
            Program.Library.AddFilesOrFolders(filesDirs);

            //foreach (XmlDisc disc in Program.Library.Discs)
            //{
            //    lbDiscs.Items.Add(disc);
            //}

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
            foreach (XmlDisc disc in afw.Discs)
            {
                lbDiscs.Items.Add(disc);
            }
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
            ValidateTracks();
        }

        private void ValidateTracks()
        {
            if (Program.ConfigUser.CheckMissingTags)
            {
                XmlLibrary selectedLibrary = new XmlLibrary(Program.ConfigCore);

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

                    selectedLibrary.Validate();
                }
                else
                {
                    selectedLibrary = Program.Library; // if nothing is selected then validate entire library
                }

                selectedLibrary.Validate();

                if (Program.ConfigCore.ProductReport)
                    new ReportWriterTracksNotCompliant().Write(Program.LogsFolderPath);
            }
        }

        private void chkChecksMissingTags_CheckedChanged(object sender, EventArgs e)
        {
            Program.ConfigUser.CheckMissingTags = chkChecksMissingTags.Checked;
        }
    }
}