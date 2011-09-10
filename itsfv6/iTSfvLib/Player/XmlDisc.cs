using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;

namespace iTSfvLib
{
    /// <summary>
    /// Holds one or more tracks of a disc
    /// </summary>
    [Serializable()]
    public class XmlDisc
    {
        public uint DiscID { get; set; }
        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public uint Year { get; set; }
        public uint HighestTrackNumber { get; set; }

        public List<XmlTrack> Tracks { get; set; }

        public XmlDisc()
        {
            Artist = "Various Artists";
            AlbumName = "Unknown Album";
            Name = "Unknown Disc";
            Tracks = new List<XmlTrack>();
        }

        public bool HasTrack(XmlTrack track)
        {
            //' 5.32.0.4 iTSfv showed duplicated tracklists if the same album was added to iTunes multiple times
            foreach (XmlTrack oTrack in Tracks)
            {
                if (track.TrackNumber == oTrack.TrackNumber && track.Name.Equals(oTrack.Name))
                {
                    return true;
                }
            }
            return false;
        }

        // public ArtworkSource ArtworkSource { get; set; }
        public XmlTrack FirstTrack
        {
            get { return Tracks[0]; }
        }

        private string mArtworkCachePath = string.Empty;
        public string ArtworkPath
        {
            get
            {
                if (string.Empty == mArtworkCachePath)
                {
                   // mArtworkCachePath = mfGetArtworkCachePath(Tracks[0]);
                }
                return mArtworkCachePath;
            }
        }

        public bool AddTrack(XmlTrack track)
        {
            bool success = false;
            if (HasTrack(track) == false)
            {
                Tracks.Add(track);
                success = true;
            }
            return success;
        }

        public bool IsComplete { get; set; }

        public string fGetAlbumName()
        {
            foreach (XmlTrack track in Tracks)
            {
                if (!string.IsNullOrEmpty(track.Album))
                {
                    return Tracks[0].Album;
                }
            }
            return "Unknown Album";
        }

        public string fGetArtistName()
        {
            foreach (XmlTrack track in Tracks)
            {
                if (track.Compilation == true)
                {
                    return "Compilations";
                }
            }
            return Tracks[0].AlbumArtist;
        }

        public string StandardText { get; set; }

        public string TrackList { get; set; }

        public string ToString(bool bBitRate, bool bSize)
        {

            List<string> tracks = new List<string>();

            foreach (XmlTrack track in Tracks)
            {

                System.Text.StringBuilder l = new System.Text.StringBuilder();

                l.Append(track.TrackNumber.ToString("00") + " " + track.Name);

                if (bBitRate == true)
                {
                    l.Append(string.Format(" [{0} Kibit/s]", track.BitRate));
                }

                if (bSize == true)
                {
                    decimal sz = (decimal)track.Size / (1024);
                    l.Append(string.Format(" [{0} KiB]", sz.ToString("N0", CultureInfo.CurrentCulture)));
                }

                tracks.Add(l.ToString());
            }

            tracks.Sort();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (string l in tracks)
            {
                sb.AppendLine(l);
            }

            return sb.ToString();
        }

        public string Location
        {
            get { return Path.GetDirectoryName(Tracks[0].Location); }
        }

        public string GoogleSearchURL
        {
            get
            {
                // generate google artwork search string
                string url = "";
                XmlTrack track = Tracks[0];

                if (track.AlbumArtist != string.Empty)
                {
                    url = string.Format("http://www.google.com/search?q={0}+%22{1}%22", track.Album, track.AlbumArtist);
                }
                else
                {
                    url = string.Format("http://www.google.com/search?q=%22{0}%22+%22{1}%22", track.Album, track.Artist);
                }
                return url;
            }
        }

        public override string ToString()
        {
            return ToString(false, false);
        }

        public XmlDisc(List<string> filePaths)
        {

            foreach (string p in filePaths)
            {
                XmlTrack xt = new XmlTrack(p);
                this.Tracks.Add(xt);

                // we will see 
            }

            if (this.Tracks.Count > 0)
            {
                //this.Name = mGetDiscName(this.FirstTrack);
                //this.AlbumName = mGetAlbumName(this.FirstTrack);

            }
        }

        public XmlDisc(XmlTrack lTrack)
        {
            //this.Name = mGetDiscName(lTrack);
            //this.AlbumName = mGetAlbumName(lTrack);
        }

    }
}
