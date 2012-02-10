using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    public static class FileSystem
    {
        public static void AppendDebug(string descr, Exception ex)
        {
            AppendDebug(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + descr + " " + ex.ToString());
        }

        public static void AppendDebug(string descr)
        {
            Console.WriteLine(descr);
        }
    }
}