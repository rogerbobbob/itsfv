using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    public class GenreFinderOptions
    {
        public bool MostCommonGenreRatioActive { get; set; }

        public double MostCommonGenrePerc { get; set; }

        public bool MostCommonGenre { get; set; }
    }

    /// <summary>
    /// Class to determine the most appropriate Album Artist of a track in a Disc
    /// </summary>
    public class GenreFinder
    {
        private Dictionary<string, int> mDiscGenres = new Dictionary<string, int>();
        private string mDiscGenre = ConstantStrings.UnknownGenre;
        private XmlDisc mDisc = null;
        private double mConfidence = 0.0;

        private GenreFinderOptions Options { get; set; }

        public string Genre
        {
            get { return mDiscGenre; }
        }

        public GenreFinder(XmlDisc lDisc, GenreFinderOptions lOptions)
        {
            this.mDisc = lDisc;
            this.Options = lOptions;

            if (Options.MostCommonGenre)
            {
                for (int i = 0; i <= lDisc.Tracks.Count - 1; i++)
                {
                    string oGenre = ConstantStrings.VariousArtists;

                    if (string.Empty != lDisc.Tracks[i].Genre)
                    {
                        oGenre = lDisc.Tracks[i].Genre;
                    }
                    AddArtist(oGenre);
                }
                mDiscGenre = GetTopGenre();
            }
            else
            {
                bool bIsGenreSame = true;
                string oAlbumArtist = lDisc.FirstTrack.Genre;

                for (int i = 0; i <= lDisc.Tracks.Count - 2; i++)
                {
                    string genre1 = lDisc.Tracks[i].Genre;
                    string genre2 = lDisc.Tracks[i + 1].Genre;
                    if (string.Empty != genre1 && string.Empty != genre2)
                    {
                        bIsGenreSame = bIsGenreSame & genre1.Equals(genre2);
                    }
                }

                if (bIsGenreSame)
                {
                    // this will not get assigned if strAlbumArtist is empty
                    mDiscGenre = oAlbumArtist;
                }
                else
                {
                    mDiscGenre = ConstantStrings.UnknownGenre;
                }
            }

            FileSystem.AppendDebug(string.Format("Chosen Most Common Genre: \"{0}\" with {1}% confidence", mDiscGenre, mConfidence.ToString("0.00")));
        }

        private string GetTopGenre()
        {
            int topHit = 0;
            string topArtist = ConstantStrings.VariousArtists;

            if (mDisc.Tracks.Count > 0 & mDiscGenres.Count > 0)
            {
                IEnumerator et = mDiscGenres.GetEnumerator();
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

                mConfidence = 100 * mDiscGenres[topArtist] / mDisc.Tracks.Count;

                if (Options.MostCommonGenreRatioActive)
                {
                    // work out if top Artist has lost the election
                    if (mConfidence < Options.MostCommonGenrePerc)
                    {
                        topArtist = ConstantStrings.VariousArtists;
                    }
                }
            }

            return topArtist;
        }

        private void AddArtist(string artist)
        {
            if (mDiscGenres.ContainsKey(artist))
            {
                mDiscGenres[artist] += 1;
            }
            else
            {
                mDiscGenres.Add(artist, 1);
            }
        }
    }
}