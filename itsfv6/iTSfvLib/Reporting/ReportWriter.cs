using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    public class ReportWriter
    {
        protected static Dictionary<XmlTrack, List<string>> TracksNotCompliant = new Dictionary<XmlTrack, List<string>>(); // track and list of tags missing

        protected ReportWriter() { }

        public static void Add(XmlTrack track, List<string> missingTags)
        {
            TracksNotCompliant.Add(track, missingTags);
        }

        internal static void Clear()
        {
            TracksNotCompliant.Clear();
        }
    }
}
