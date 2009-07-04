using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace itsfv6
{
    static class Program
    {

        public static iTSfvLib.Adapter Linker = new iTSfvLib.Adapter();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
