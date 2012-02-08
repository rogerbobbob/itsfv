using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    /// <summary>
    /// Holds one or more albums by an AlbumArtist
    /// </summary>
    public class XmlAlbumArtist
    {
        /// <summary>
        /// Unique ID usually the Name of the Band
        /// </summary>
        public string ID { get; set; }

        private List<XmlAlbum> Albums = new List<XmlAlbum>();

        public void AddAlbum(XmlAlbum item)
        {
            if (Albums.All(x => x.ID != item.ID))
                Albums.Add(item);
        }

        public void RemoveAlbum(XmlAlbum band)
        {
            XmlAlbum fItem = Albums.FirstOrDefault(x => x.ID == band.ID);
            if (fItem != null)
                Albums.Remove(fItem);
        }
    }
}