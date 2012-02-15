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

        private XmlDisc()
        {
            Tracks = new List<XmlTrack>();
            DiscNumber = 0;
        }

        public XmlDisc(string key)
            : this()
        {
            Key = key;
        }

        public XmlDisc(List<XmlTrack> tracks)
            : this()
        {
            this.Tracks = tracks;

            if (tracks.Count > 0)
            {
                this.Key = tracks[0].GetDiscKey();
            }
        }

        public XmlDisc(List<string> filePaths)
            : this()
        {
            foreach (string p in filePaths)
            {
                XmlTrack xt = new XmlTrack(p);
                this.Tracks.Add(xt);
            }

            if (this.Tracks.Count > 0)
            {
                this.Key = Tracks[0].GetDiscKey();
            }
        }

        #endregion 0 Constructor

        #region 1 Properties

        public string Band
        {
            get
            {
                if (Tracks.Count > 0)
                {
                    return new MostCommonTagFinder(Tracks, ETagFinderType.Artist, new TagFinderOptions()
                    {
                        ConfidenceRequired = 50.0,
                        MostCommonTagRatioActive = true,
                        ChooseMostCommonTag = true
                    }).MostCommonString;
                }
                return string.Empty;
            }
        }

        public string Genre
        {
            get
            {
                if (Tracks.Count > 0)
                {
                    return new MostCommonTagFinder(Tracks, ETagFinderType.Genre, new TagFinderOptions()
                    {
                        ChooseMostCommonTag = true
                    }).MostCommonString;
                }
                return string.Empty;
            }
        }

        public uint HighestTrackNumber { get; set; }

        public List<XmlTrack> Tracks { get; set; }

        public uint Year { get; set; }

        #endregion 1 Properties

        #region 2 Properties Read-Only

        /// <summary>
        /// Unique Key
        /// </summary>
        public string Key { get; private set; }

        public uint DiscNumber { get; private set; }

        public string Album
        {
            get
            {
                if (Tracks.Count > 0)
                    return FirstTrack.Tags.Album;

                return string.Empty;
            }
        }

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
                    url = string.Format("http://www.google.com/search?q={0}+%22{1}%22", track.Tags.Album, track.Band);
                }
                else
                {
                    url = string.Format("http://www.google.com/search?q=%22{0}%22+%22{1}%22", track.Tags.Album, track.Artist);
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
                    this.DiscNumber = Math.Max(track.Tags.Disc, 1);
                }

                if (string.IsNullOrEmpty(Key))
                {
                    this.Key = track.GetDiscKey();
                }

                success = true;
            }

            return success;
        }

        public string GetAlbumKey()
        {
            foreach (XmlTrack track in Tracks)
            {
                if (!string.IsNullOrEmpty(track.Band) && !string.IsNullOrEmpty(track.Tags.Album))
                {
                    return string.Format("{0} - {1}", track.Tags.Album, track.Band);
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
                if (!string.IsNullOrEmpty(track.Band) && !string.IsNullOrEmpty(track.Tags.Album))
                {
                    return string.Format("{0} Disc {1} - {2}", track.Tags.Album, DiscNumber.ToString("000"), track.Band);
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

        public string ToTracklistString(bool bBitRate = false, bool bSize = false)
        {
            List<string> tracks = new List<string>();

            foreach (XmlTrack track in Tracks)
            {
                System.Text.StringBuilder l = new System.Text.StringBuilder();

                l.Append(track.Tags.Track.ToString("00") + " " + track.Tags.Title);

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
            return Key;
        }
    }
}