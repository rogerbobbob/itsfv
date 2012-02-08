using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace iTSfvLib
{
    public class Adapter
    {
        /// <summary>
        /// Function to add files to the iTunes library. All the files need to be properly tagged prior to using this method.
        /// </summary>
        /// <param name="filesList">Files list after necessary tagging is performed</param>
        public void AddFiles(List<string> filesList)
        {
            filesList.Sort();
            object objFiles = filesList.ToArray();
        }

        #region Selected Tracks

        public List<XmlTrack> GetSelectedTracks()
        {
            List<XmlTrack> temp = new List<XmlTrack>();

            return temp;
        }

        /// <summary>
        /// Method to get the track count of Selected tracks
        /// If no tracks are selected then returns 0
        /// </summary>
        public int SelectedTracksCount
        {
            get
            {
                List<XmlTrack> temp = GetSelectedTracks();
                return (null == temp ? 0 : temp.Count);
            }
        }

        #endregion Selected Tracks
    }
}