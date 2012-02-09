﻿using System;
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
        public string Key { get; private set; }

        private Dictionary<string, XmlAlbum> Albums = new Dictionary<string, XmlAlbum>();

        public XmlBand(string key)
        {
            this.Key = key;
        }

        public void AddAlbum(XmlAlbum o)
        {
            if (!Albums.ContainsKey(o.Key))
                Albums.Add(o.Key, o);
        }

        public XmlAlbum GetAlbum(string albumKey)
        {
            if (Albums.ContainsKey(albumKey))
                return Albums[albumKey];

            return null;
        }

        public void RemoveAlbum(XmlAlbum o)
        {
            if (Albums.ContainsKey(o.Key))
                Albums.Remove(o.Key);
        }
    }
}