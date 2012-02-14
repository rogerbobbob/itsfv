using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTSfvLib;

namespace iTSfvGUI
{
    public partial class AddFilesWizard : Form
    {
        private string[] _FilesDirs;

        public List<XmlTrack> TracksOrphaned { get; private set; }

        public AddFilesWizard(string[] filesDirs)
        {
            InitializeComponent();
            _FilesDirs = filesDirs;
            TracksOrphaned = new List<XmlTrack>();
        }

        private void AddFilesWizard_Load(object sender, EventArgs e)
        {
            foreach (string pfd in _FilesDirs.ToArray<string>())
            {
                if (Directory.Exists(pfd))
                {
                    AddDirToNode(pfd, tvBands.Nodes);
                }
                else if (File.Exists(pfd))
                {
                    TracksOrphaned.Add(new XmlTrack(pfd));
                }
            }

            XmlDisc discOrphaned = new XmlDisc(TracksOrphaned);
            foreach (XmlTrack track in TracksOrphaned)
            {
                TreeNode tnOrphaned = new TreeNode("Orphaned Tracks");
                tnOrphaned.Tag = discOrphaned;
                tvBands.Nodes.Add(tnOrphaned);
            }
        }

        private void AddDirToNode(string dirPath, TreeNodeCollection tnc)
        {
            TreeNode tn = new TreeNode(Path.GetFileName(dirPath));
            tnc.Add(tn);
            tn.Tag = GetDiscFromFolder(dirPath);

            foreach (string dp in Directory.GetDirectories(dirPath))
            {
                if (Directory.Exists(dp))
                {
                    AddDirToNode(dp, tn.Nodes);
                }
            }
        }

        private XmlDisc GetDiscFromFolder(string dirPath)
        {
            return new XmlDisc(Directory.GetFiles(dirPath, "*.mp3", SearchOption.TopDirectoryOnly).ToList<string>());
        }

        private void tvBands_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode tn = e.Node;
            if (tn != null && tn.Tag != null)
            {
                XmlDisc disc = tn.Tag as XmlDisc;
                lbPaths.Items.Clear();
                foreach (XmlTrack track in disc.Tracks)
                {
                    lbPaths.Items.Add(track.Location);
                }
                cboAlbumArtist.Text = disc.Band;
                txtAlbum.Text = disc.Album;
            }
        }
    }
}