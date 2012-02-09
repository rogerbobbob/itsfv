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

        public AddFilesWizard(string[] filesDirs)
        {
            InitializeComponent();
            _FilesDirs = filesDirs;
        }

        private void AddFilesWizard_Load(object sender, EventArgs e)
        {
            List<XmlTrack> tracks = new List<XmlTrack>();

            foreach (string pfd in _FilesDirs.ToArray<string>())
            {
                if (Directory.Exists(pfd))
                {
                    TreeNode tn = new TreeNode(Path.GetFileName(pfd));
                    tvBands.Nodes.Add(tn);

                    // todo: respect windows explorer folder structure
                    foreach (string fp in Directory.GetFiles(pfd, "*.mp3", SearchOption.AllDirectories))
                    {
                        tracks.Add(new XmlTrack(fp));
                    }
                }
                else if (File.Exists(pfd))
                {
                    tracks.Add(new XmlTrack(pfd));
                }
            }
        }
    }
}