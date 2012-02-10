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

        public List<XmlTrack> Tracks { get; private set; }

        public AddFilesWizard(string[] filesDirs)
        {
            InitializeComponent();
            _FilesDirs = filesDirs;
            Tracks = new List<XmlTrack>();
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
                    Tracks.Add(new XmlTrack(pfd));
                }
            }
        }

        private void AddDirToNode(string dirPath, TreeNodeCollection tnc)
        {
            TreeNode tn = new TreeNode(Path.GetFileName(dirPath));
            tnc.Add(tn);

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
    }
}