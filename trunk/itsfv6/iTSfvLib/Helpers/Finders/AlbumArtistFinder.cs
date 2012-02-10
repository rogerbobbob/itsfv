using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    public class AlbumArtistFinderOptions
    {
        public bool MostCommonArtistRatioActive { get; set; }
        public double MostCommonArtistPerc { get; set; }
        public bool MostCommonAlbumArtist { get; set; }
    }

    /// <summary>
    /// Class to determine the most appropriate Album Artist of a track in a Disc
    /// </summary>
    public class AlbumArtistFinder
    {
        private Dictionary<string, int> mDiscArtists = new Dictionary<string, int>();
        private string mDiscArtist = ConstantStrings.VariousArtists;
        private XmlDisc mDisc = null;
        private double mConfidence = 0.0;
        private AlbumArtistFinderOptions Options { get; set; }

        public string AlbumArtist
        {
            get { return mDiscArtist; }
        }

        public AlbumArtistFinder(XmlDisc lDisc, AlbumArtistFinderOptions lOptions)
        {
            this.mDisc = lDisc;
            this.Options = lOptions;

            if (Options.MostCommonAlbumArtist)
            {
                for (int i = 0; i <= lDisc.Tracks.Count - 1; i++)
                {
                    string oAlbumArtist = ConstantStrings.VariousArtists;

                    if (string.Empty != lDisc.Tracks[i].Artist)
                    {
                        oAlbumArtist = lDisc.Tracks[i].Artist;
                    }
                    AddArtist(oAlbumArtist);
                }
                mDiscArtist = GetTopArtist();
            }
            else
            {
                bool bArtistIsSame = true;
                string oAlbumArtist = lDisc.FirstTrack.Artist;

                for (int i = 0; i <= lDisc.Tracks.Count - 2; i++)
                {
                    string artist1 = lDisc.Tracks[i].Artist;
                    string artist2 = lDisc.Tracks[i + 1].Artist;
                    if (string.Empty != artist1 && string.Empty != artist2)
                    {
                        bArtistIsSame = bArtistIsSame & artist1.Equals(artist2);
                    }
                }

                if (bArtistIsSame == true)
                {
                    // this will not get assigned if strAlbumArtist is empty
                    mDiscArtist = oAlbumArtist;
                }
                else
                {
                    mDiscArtist = ConstantStrings.VariousArtists;
                }
            }

            FileSystem.AppendDebug(string.Format("Chosen Most Common Artist: \"{0}\" with {1}% confidence", mDiscArtist, mConfidence.ToString("0.00")));
        }

        private string GetTopArtist()
        {
            int topHit = 0;
            string topArtist = ConstantStrings.VariousArtists;

            if (mDisc.Tracks.Count > 0 & mDiscArtists.Count > 0)
            {
                IEnumerator et = mDiscArtists.GetEnumerator();
                KeyValuePair<string, int> de = default(KeyValuePair<string, int>);

                while (et.MoveNext())
                {
                    de = (KeyValuePair<string, int>)et.Current;
                    if (string.IsNullOrEmpty(de.Key) == false && (int)de.Value > topHit)
                    {
                        topHit = (int)de.Value;
                        topArtist = (string)de.Key;
                    }
                }

                mConfidence = 100 * mDiscArtists[topArtist] / mDisc.Tracks.Count;

                if (Options.MostCommonArtistRatioActive == true)
                {
                    // work out if top Artist has lost the election
                    if (mConfidence < Options.MostCommonArtistPerc)
                    {
                        topArtist = ConstantStrings.VariousArtists;
                    }
                }
            }

            return topArtist;
        }

        private void AddArtist(string artist)
        {
            if (mDiscArtists.ContainsKey(artist))
            {
                mDiscArtists[artist] += 1;
            }
            else
            {
                mDiscArtists.Add(artist, 1);
            }
        }
    }
}