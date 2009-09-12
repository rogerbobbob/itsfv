using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTSfvLib
{
    public class Adapter
    {
        private iTunesApp mApp = null;

        public bool LoadApplication()
        {

            bool success = true;
            try
            {
                mApp = new iTunesApp();
                Console.WriteLine(mApp.Version);
            }
            catch (Exception ex)
            {
                success = false;
                Console.WriteLine(ex.Message);
            }
            return success;
        }
    }
}
