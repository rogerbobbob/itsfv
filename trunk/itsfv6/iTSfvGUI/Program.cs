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
        // Windows
        public static ValidatorWizard gValidator = null;
        public static LogViewer gLogViewer = null;
        public static AddFilesWizard gAddFilesWizard = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gLogViewer = new LogViewer();
            gValidator = new ValidatorWizard();
            gAddFilesWizard = new AddFilesWizard();
            Application.Run(gValidator);
        }
    }
}
