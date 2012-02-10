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
        public Dictionary<string, XmlBand> Library = new Dictionary<string, XmlBand>();

        public List<XmlBand> Bands { get; private set; }

        public List<XmlAlbum> Albums { get; private set; }

        public List<XmlDisc> Discs { get; private set; }

        public XMLSettings Config = null;

        public XmlPlayer(XMLSettings Config)
        {
            Bands = new List<XmlBand>();
            Albums = new List<XmlAlbum>();
            Discs = new List<XmlDisc>();
        }

        public void AddFilesOrFolders(string[] filesOrFolders)
        {
            List<XmlTrack> tracks = new List<XmlTrack>();

            foreach (string pfd in filesOrFolders)
            {
                if (Directory.Exists(pfd))
                {
                    // todo: respect windows explorer folder structure
                    foreach (string ext in Config.SupportedAudioTypes)
                    {
                        foreach (string fp in Directory.GetFiles(pfd, string.Format("*.{0}", ext), SearchOption.AllDirectories))
                        {
                            tracks.Add(new XmlTrack(fp));
                        }
                    }
                }
                else if (File.Exists(pfd))
                {
                    tracks.Add(new XmlTrack(pfd));
                }
            }

            foreach (XmlTrack track in tracks)
            {
                AddTrack(track);
            }
        }

        /// <summary>
        /// Method to add a track to Player
        /// If the track already exists
        /// </summary>
        /// <param name="track"></param>
        public void AddTrack(XmlTrack track)
        {
            XmlBand tempBand = GetBand(track.Band);
            if (tempBand == null)
            {
                tempBand = new XmlBand(track.Band);
                Library.Add(tempBand.Key, tempBand);
                Bands.Add(tempBand);
            }

            XmlAlbum tempAlbum = tempBand.GetAlbum(track.GetAlbumKey());
            if (tempAlbum == null)
            {
                tempAlbum = new XmlAlbum(track.GetAlbumKey());
                Library[track.Band].AddAlbum(tempAlbum);
                Albums.Add(tempAlbum);
            }

            XmlDisc tempDisc = tempAlbum.GetDisc(track.GetDiscKey());
            if (tempDisc == null)
            {
                tempDisc = new XmlDisc(track.GetDiscKey());
                Library[track.Band].GetAlbum(track.GetAlbumKey()).AddDisc(tempDisc);
                Discs.Add(tempDisc);
            }

            Library[track.Band].GetAlbum(track.GetAlbumKey()).GetDisc(track.GetDiscKey()).AddTrack(track);
        }

        public void AddBand(XmlBand o)
        {
            if (!Library.ContainsKey(o.Key))
                Library.Add(o.Key, o);
        }

        public XmlBand GetBand(string key)
        {
            if (Library.ContainsKey(key))
                return Library[key];

            return null;
        }

        public void RemoveBand(XmlBand o)
        {
            if (Library.ContainsKey(o.Key))
                Library.Remove(o.Key);
        }
    }
}