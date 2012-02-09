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
    }
}