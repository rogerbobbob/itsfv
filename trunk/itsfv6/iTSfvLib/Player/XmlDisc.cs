using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    /// <summary>
    /// Holds one or more tracks of a disc
    /// </summary>
    [Serializable()]
    public class XmlDisc
    {
        #region 0 Constructor

        public XmlDisc()
        {
            Band = ConstantStrings.VariousArtists;
            AlbumName = ConstantStrings.UnknownAlbum;
            DiscName = ConstantStrings.UnknownDisc;
            Tracks = new List<XmlTrack>();
            DiscNumber = 0;
        }

        public XmlDisc(List<string> filePaths)
        {
            foreach (string p in filePaths)
            {
                XmlTrack xt = new XmlTrack(p);
                this.Tracks.Add(xt);
            }

            if (this.Tracks.Count > 0)
            {
                this.DiscName = GetDiscName();
                this.AlbumName = GetAlbumName();
            }
        }

        #endregion 0 Constructor

        #region 1 Properties

        public string AlbumName { get; set; }

        public string Band { get; set; }

        public string Genre { get; set; }

        public uint HighestTrackNumber { get; set; }

        public string DiscName { get; set; }

        public List<XmlTrack> Tracks { get; set; }

        public uint Year { get; set; }

        #endregion 1 Properties

        #region 2 Properties Read-Only

        public uint DiscID { get; private set; }

        public uint DiscNumber { get; private set; }

        public XmlTrack FirstTrack
        {
            get { return Tracks[0]; }
        }

        public string GoogleSearchURL
        {
            get
            {
                // generate google artwork search string
                string url = "";
                XmlTrack track = Tracks[0];

                if (track.Band != string.Empty)
                {
                    url = string.Format("http://www.google.com/search?q={0}+%22{1}%22", track.Album, track.Band);
                }
                else
                {
                    url = string.Format("http://www.google.com/search?q=%22{0}%22+%22{1}%22", track.Album, track.Artist);
                }
                return url;
            }
        }

        public bool IsComplete { get; private set; }

        public string Location
        {
            get { return Path.GetDirectoryName(Tracks[0].Location); }
        }

        #endregion 2 Properties Read-Only

        public bool AddTrack(XmlTrack track)
        {
            bool success = false;

            if (!HasTrack(track))
            {
                Tracks.Add(track);

                if (DiscNumber == 0)
                {
                    DiscNumber = track.DiscNumber;
                }

                if (string.IsNullOrEmpty(DiscName))
                {
                    DiscName = GetDiscName();
                }

                success = true;
            }

            return success;
        }

        public string GetAlbumName()
        {
            foreach (XmlTrack track in Tracks)
            {
                if (!string.IsNullOrEmpty(track.Band) && !string.IsNullOrEmpty(track.Album))
                {
                    return string.Format("{0} - {1}", track.Album, track.Band);
                }
            }
            return ConstantStrings.UnknownAlbum;
        }

        public string GetBand()
        {
            foreach (XmlTrack track in Tracks)
            {
                if (track.Compilation == true)
                {
                    return ConstantStrings.VariousArtists;
                }
                else if (!string.IsNullOrEmpty(track.Band))
                {
                    return track.Band;
                }
            }
            return ConstantStrings.UnknownArtist;
        }

        public string GetDiscName()
        {
            foreach (XmlTrack track in Tracks)
            {
                if (!string.IsNullOrEmpty(track.Band) && !string.IsNullOrEmpty(track.Album))
                {
                    return string.Format("{0} Disc {1} - {2}", track.Album, DiscNumber.ToString("000"), track.Band);
                }
            }

            return string.Format("{0} Disc {1} - {2}", ConstantStrings.UnknownDisc, DiscNumber.ToString("000"), ConstantStrings.UnknownArtist);
        }

        public bool HasTrack(XmlTrack track)
        {
            // 5.32.0.4 iTSfv showed duplicated tracklists if the same album was added to iTunes multiple times
            foreach (XmlTrack oTrack in Tracks)
            {
                if (track.FileName == oTrack.FileName)
                {
                    return true;
                }
            }
            return false;
        }

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

        public override string ToString()
        {
            return ToString(false, false);
        }
    }
}