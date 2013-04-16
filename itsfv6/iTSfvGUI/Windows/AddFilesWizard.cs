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
        private string[] FilesDirs;
        public List<XmlTrack> TracksOrphaned { get; private set; }
        public List<XmlDisc> Discs { get; private set; }

        public AddFilesWizard(string[] filesDirs)
        {
            InitializeComponent();
            FilesDirs = filesDirs;
            TracksOrphaned = new List<XmlTrack>();
            Discs = new List<XmlDisc>();
        }

        private void AddFilesWizard_Load(object sender, EventArgs e)
        {
            foreach (string pfd in FilesDirs.ToArray<string>())
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
            List<XmlTrack> tracks = new List<XmlTrack>();
            foreach (string ext in Program.Config.SupportedAudioTypes)
            {
                Directory.GetFiles(dirPath, string.Format("*.{0}", ext), 
                    SearchOption.AllDirectories).ToList().ForEach(fp => tracks.Add(new XmlTrack(fp)));
            }

            XmlDisc tempDisc = new XmlDisc(tracks);
            Discs.Add(tempDisc);
            return tempDisc;
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
                cboAlbumArtist.Text = disc.AlbumArtist;
                cboGenre.Text = disc.Genre;
                txtAlbum.Text = disc.Album;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}