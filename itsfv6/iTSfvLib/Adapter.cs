using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;
using System.Threading;

namespace iTSfvLib
{
    public class Adapter
    {
        private iTunesApp mApp = null;

        /// <summary>
        /// Method to load iTunes if not already loaded. This method can be called multipl times
        /// without any impact on the performance
        /// </summary>
        /// <returns></returns>
        public bool LoadApplication()
        {
            return (null != this.LoadApp);
        }

        internal iTunesApp LoadApp
        {
            get
            {
                try
                {
                    if (null == mApp)
                    {
                        mApp = new iTunesApp();
                        Console.WriteLine("Loading " + mApp.Version);
                    }
                    return mApp;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(5000);
                    return LoadApp;
                }
            }
        }

        #region Selected Tracks

        public List<XmlTrack> GetSelectedTracks()
        {
            List<XmlTrack> temp = new List<XmlTrack>();
            if (null != LoadApp.BrowserWindow.SelectedTracks)
            {
                foreach (IITTrack track in LoadApp.BrowserWindow.SelectedTracks)
                {
                    temp.Add(new XmlTrack(track));
                }
            }
            else if (null != LoadApp.SelectedTracks)
            {
                foreach (IITTrack track in LoadApp.SelectedTracks)
                {
                    temp.Add(new XmlTrack(track));
                }
            }
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

        #endregion

    }
}
