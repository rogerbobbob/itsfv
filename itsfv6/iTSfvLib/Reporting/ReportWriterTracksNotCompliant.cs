using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTSfvLib
{
    public class ReportWriterTracksNotCompliant : ReportWriter
    {
        public void Write(string workingDir)
        {
            string fp = Path.Combine(workingDir, string.Format("{0}-TracksMissingTags-{1}.log",
                Application.ProductName,
                DateTime.Now.ToString("yyyyMMddTHHmm")));

            if (TracksNotCompliant.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(fp, false))
                {
                    IEnumerator i = TracksNotCompliant.GetEnumerator();
                    KeyValuePair<XmlTrack, List<string>> kvp = new KeyValuePair<XmlTrack, List<string>>();

                    while (i.MoveNext())
                    {
                        kvp = (KeyValuePair<XmlTrack, List<string>>)i.Current;
                        XmlTrack track = kvp.Key;
                        List<string> missingTags = kvp.Value;
                        string errors = string.Join("; ", missingTags.ToArray());
                        sw.WriteLine(track.Location + " --> " + errors);
                    }
                }
            }
        }
    }
}
