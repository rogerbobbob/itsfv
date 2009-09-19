using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iTSfvLib;

namespace iTSfvGUI
{
   public static class Program
    {
       public static Adapter Linker = new Adapter(); 
                              
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectedTracksWizard());
        }
    }
}
