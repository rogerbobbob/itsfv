using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    /// <summary>
    /// Class that holds a List of AlbumArtist - highest in the hierachy
    /// </summary>
    public class XmlLibrary
    {
        public Dictionary<string, XmlAlbumArtist> Player = new Dictionary<string, XmlAlbumArtist>();

        public List<XmlAlbumArtist> AlbumArtists { get; private set; }
        public List<XmlAlbum> Albums { get; private set; }
        public List<XmlDisc> Discs { get; private set; }

        private XMLSettings _Config = null;

        public XmlLibrary(XMLSettings Config)
        {
            AlbumArtists = new List<XmlAlbumArtist>();
            Albums = new List<XmlAlbum>();
            Discs = new List<XmlDisc>();

            _Config = Config;
        }

        public void AddFilesOrFolders(string[] filesOrFolders)
        {
            List<XmlTrack> tracks = new List<XmlTrack>();

            foreach (string pfd in filesOrFolders)
            {
                if (Directory.Exists(pfd))
                {
                    // todo: respect windows explorer folder structure
                    foreach (string ext in _Config.SupportedAudioTypes)
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
        /// </summary>
        /// <param name="track"></param>
        public void AddTrack(XmlTrack track)
        {
            XmlAlbumArtist tempBand = GetBand(track.Band);
            if (tempBand == null)
            {
                tempBand = new XmlAlbumArtist(track.Band);
                Player.Add(tempBand.Name, tempBand);
                AlbumArtists.Add(tempBand);
            }

            XmlAlbum tempAlbum = tempBand.GetAlbum(track.GetAlbumKey());
            if (tempAlbum == null)
            {
                tempAlbum = new XmlAlbum(track.GetAlbumKey());
                Player[track.Band].AddAlbum(tempAlbum);
                Albums.Add(tempAlbum);
            }

            XmlDisc tempDisc = tempAlbum.GetDisc(track.GetDiscKey());
            if (tempDisc == null)
            {
                tempDisc = new XmlDisc(track.GetDiscKey());
                Player[track.Band].GetAlbum(track.GetAlbumKey()).AddDisc(tempDisc);
                Discs.Add(tempDisc);
            }

            Player[track.Band].GetAlbum(track.GetAlbumKey()).GetDisc(track.GetDiscKey()).AddTrack(track);
        }

        public void AddBand(XmlAlbumArtist o)
        {
            if (!Player.ContainsKey(o.Name))
                Player.Add(o.Name, o);
        }

        public XmlAlbumArtist GetBand(string key)
        {
            if (Player.ContainsKey(key))
                return Player[key];

            return null;
        }

        public void RemoveBand(XmlAlbumArtist o)
        {
            if (Player.ContainsKey(o.Name))
                Player.Remove(o.Name);
        }

        /// <summary>
        /// This method validates the entire Player
        /// </summary>
        public void Validate()
        {
            IEnumerator iPlayer = Player.GetEnumerator();
            KeyValuePair<string, XmlAlbumArtist> currBand = new KeyValuePair<string, XmlAlbumArtist>();

            while (iPlayer.MoveNext())
            {
                currBand = (KeyValuePair<string, XmlAlbumArtist>)iPlayer.Current;
                ValidateBand(currBand.Value);
            }
        }

        public void ValidateBand(XmlAlbumArtist band)
        {
            Console.WriteLine("Band: " + band.Name);

            IEnumerator iBand = band.Albums.GetEnumerator();
            KeyValuePair<string, XmlAlbum> currAlbum = new KeyValuePair<string, XmlAlbum>();

            while (iBand.MoveNext())
            {
                currAlbum = (KeyValuePair<string, XmlAlbum>)iBand.Current;
                ValidateAlbum(currAlbum.Value);
            }
        }

        public void ValidateAlbum(XmlAlbum album)
        {
            Console.WriteLine(" Album -> " + album.Key);

            IEnumerator iDisc = album.Discs.GetEnumerator();
            KeyValuePair<string, XmlDisc> currDisc = new KeyValuePair<string, XmlDisc>();

            while (iDisc.MoveNext())
            {
                currDisc = (KeyValuePair<string, XmlDisc>)iDisc.Current;
                ValidateDisc(currDisc.Value);
            }
        }

        public void ValidateDisc(XmlDisc disc)
        {
            Console.WriteLine("   Disc --> " + disc.Key);

            foreach (XmlTrack track in disc.Tracks)
            {
                Console.WriteLine("    Track ---> " + track.FileName);
                ValidateTrack(track);
            }
        }

        public void ValidateTrack(XmlTrack track)
        {
        }
    }
}