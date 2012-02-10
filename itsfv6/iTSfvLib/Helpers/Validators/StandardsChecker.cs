using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    public class StandardsChecker
    {
        private XmlDisc _Disc = null;

        public StandardsChecker(XmlDisc disc)
        {
            _Disc = disc;
        }

        public uint GetDiscCount()
        {
            return (uint)_Disc.Tracks.Count;
        }

        public string ToReportString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (XmlTrack track in _Disc.Tracks)
            {
            }
            return sb.ToString();
        }
    }
}