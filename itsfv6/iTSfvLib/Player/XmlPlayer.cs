using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib.Player
{
    /// <summary>
    /// Class that holds a List of Band
    /// </summary>
    public class XmlPlayer
    {
        private List<XmlAlbumArtist> Bands = new List<XmlAlbumArtist>();

        public void AddBand(XmlAlbumArtist band)
        {
            if (Bands.All(x => x.ID != band.ID))
                Bands.Add(band);
        }

        public void RemoveBand(XmlAlbumArtist band)
        {
            XmlAlbumArtist fBand = Bands.FirstOrDefault(x => x.ID == band.ID);
            if (fBand != null)
                Bands.Remove(fBand);
        }
    }
}