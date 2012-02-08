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
            bool found = false;
            foreach (XmlAlbumArtist oBand in Bands)
            {
                if (oBand.ID == band.ID)
                    found = true;
                break;
            }
            if (!found)
                Bands.Add(band);
        }

        public void RemoveBand(XmlAlbumArtist band)
        {
            XmlAlbumArtist fBand = null;
            foreach (XmlAlbumArtist oBand in Bands)
            {
                if (oBand.ID == band.ID)
                    fBand = oBand;
                break;
            }
            if (fBand != null)
                Bands.Remove(fBand);
        }
    }
}