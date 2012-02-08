using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    /// <summary>
    /// Holds one or more discs of an album
    /// </summary>
    public class XmlAlbum
    {
        /// <summary>
        /// Unique ID Artist_Album_NumberOfTracks
        /// </summary>
        public string AlbumID { get; set; }

        public string AlbumName { get; set; }

        public List<XmlDisc> Discs = new List<XmlDisc>();

        public void AddDisc(XmlDisc o)
        {
            if (Discs.All(x => x.DiscID != o.DiscID))
                Discs.Add(o);
        }

        public void RemoveDisc(XmlDisc o)
        {
            XmlDisc item = Discs.FirstOrDefault(x => x.DiscID == o.DiscID);
            if (item != null)
                Discs.Remove(item);
        }
    }
}