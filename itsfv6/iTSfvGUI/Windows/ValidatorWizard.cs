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
            if (null != Program.LogViewer)
            {
                Program.LogViewer.Location = new Point(this.Location.X, this.Location.Y + this.Height);
            }
        }

        private void miTasksAddFiles_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog("Add files or a folder...");
            dlg.IsFolderPicker = true;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                AddFilesFolders(new string[] { dlg.FileName });
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

                IEnumerator iBand = band.Albums.GetEnumerator();
                KeyValuePair<string, XmlAlbum> kvpAlbum = new KeyValuePair<string, XmlAlbum>();

                while (iBand.MoveNext())
                {
                    kvpAlbum = (KeyValuePair<string, XmlAlbum>)iBand.Current;
                    tnAlbumArtist.Nodes.Add(new TreeNode(kvpAlbum.Key) { Tag = kvpAlbum.Value });
                }

                tvLibrary.Nodes.Add(tnAlbumArtist);
            }

            Program.Library.Validate();
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
    }
}