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
                        Console.WriteLine("Loading " + mApp.Version);
                        mApp = new iTunesApp();
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

        public IITTrackCollection GetSelectedTracks()
        {
            return LoadApp.SelectedTracks;
        }

        public int SelectedTracksCount
        {
            get
            {
                IITTrackCollection temp = GetSelectedTracks();
                return (null == temp ? 0 : temp.Count);
            }
        }

        #endregion

    }
}
