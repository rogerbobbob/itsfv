using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTSfvLib;

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
        }

        private void ValidatorWizard_Shown(object sender, EventArgs e)
        {
            Program.gLogViewer.Show();
        }

        private void ValidatorWizard_Move(object sender, EventArgs e)
        {
            if (null != Program.gLogViewer)
            {
                Program.gLogViewer.Location = new Point(this.Location.X, this.Location.Y + this.Height);
            }
        }

        private void miTasksAddFiles_Click(object sender, EventArgs e)
        {
            if (Program.gAddFilesWizard == null || Program.gAddFilesWizard.IsDisposed)
            {
                Program.gAddFilesWizard = new AddFilesWizard();
            }
            Program.gAddFilesWizard.Show();
            Program.gAddFilesWizard.Focus();
        }

        private void lbDiscs_DragDrop(object sender, DragEventArgs e)
        {
            XmlPlayer player = new XmlPlayer();

            var pathsFilesFolders = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            player.AddFilesOrFolders(pathsFilesFolders);

            foreach (XmlDisc disc in player.Discs)
            {
                lbDiscs.Items.Add(disc);
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
    }
}