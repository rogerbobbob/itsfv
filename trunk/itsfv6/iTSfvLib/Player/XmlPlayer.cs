using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    /// <summary>
    /// Class that holds a List of Band
    /// </summary>
    public class XmlPlayer
    {
        private List<XmlBand> Bands = new List<XmlBand>();

        public void AddFilesOrFolders(string[] filesOrFolders)
        {
            List<XmlTrack> tracks = new List<XmlTrack>();

            foreach (string pfd in filesOrFolders)
            {
                if (Directory.Exists(pfd))
                {
                    foreach (string fp in Directory.GetFiles(pfd, "*.*", SearchOption.AllDirectories))
                    {
                        tracks.Add(new XmlTrack(fp));
                    }
                }
                else if (File.Exists(pfd))
                {
                    tracks.Add(new XmlTrack(pfd));
                }
            }

            List<XmlAlbum> albums = new List<XmlAlbum>();
            XmlAlbum album = new XmlAlbum();
            List<XmlDisc> discs = new List<XmlDisc>();
            XmlDisc disc = new XmlDisc();

            foreach (XmlTrack track in tracks)
            {
                disc.AddTrack(track);
            }
        }

        public void AddBand(XmlBand band)
        {
            if (Bands.All(x => x.ID != band.ID))
                Bands.Add(band);
        }

        public void RemoveBand(XmlBand band)
        {
            XmlBand fBand = Bands.FirstOrDefault(x => x.ID == band.ID);
            if (fBand != null)
                Bands.Remove(fBand);
        }
    }
}