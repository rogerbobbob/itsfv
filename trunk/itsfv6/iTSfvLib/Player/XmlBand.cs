using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    /// <summary>
    /// Holds one or more albums by an AlbumArtist
    /// </summary>
    public class XmlBand
    {
        /// <summary>
        /// Unique ID usually the Name of the Band
        /// </summary>
        public string ID { get; set; }

        private List<XmlAlbum> Albums = new List<XmlAlbum>();

        public void AddAlbum(XmlAlbum o)
        {
            if (Albums.All(x => x.AlbumID != o.AlbumID))
                Albums.Add(o);
        }

        public void RemoveAlbum(XmlAlbum o)
        {
            XmlAlbum item = Albums.FirstOrDefault(x => x.AlbumID == o.AlbumID);
            if (item != null)
                Albums.Remove(item);
        }
    }
}