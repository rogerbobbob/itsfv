using System;
using System.Collections;
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
        public string Key { get; private set; }

        public Dictionary<string, XmlDisc> Discs = new Dictionary<string, XmlDisc>();

        public XmlAlbum(string key)
        {
            Key = key;
        }

        public void AddDisc(XmlDisc o)
        {
            if (!Discs.ContainsKey(o.Key))
                Discs.Add(o.Key, o);
        }

        public XmlDisc GetDisc(string key)
        {
            if (Discs.ContainsKey(key))
                return Discs[key];

            return null;
        }

        public void RemoveDisc(XmlDisc o)
        {
            if (Discs.ContainsKey(o.Key))
                Discs.Remove(o.Key);
        }

        public string GetAlbumName()
        {
            foreach (XmlTrack track in GetTracks())
            {
                if (!string.IsNullOrEmpty(track.Tags.Album))
                {
                    return track.Tags.Album;
                }
            }
            return ConstantStrings.UnknownAlbum;
        }

        public List<XmlTrack> GetTracks()
        {
            List<XmlTrack> tracks = new List<XmlTrack>();
            IEnumerator i = this.Discs.GetEnumerator();

            while (i.MoveNext())
            {
                tracks.AddRange(((KeyValuePair<string, XmlDisc>)i.Current).Value.Tracks);
            }

            return tracks;
        }
    }
}