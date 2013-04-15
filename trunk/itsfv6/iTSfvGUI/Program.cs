using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iTSfvLib;

namespace iTSfvGUI
{
    public static class Program
    {
        public static XMLSettings Config = null;
        public static Adapter Linker = new Adapter();

        // Windows
        public static ValidatorWizard gValidator = null;
        public static LogViewer LogViewer = null;
        public static MainWindow gMainWindow = null;
        public static XmlLibrary Library = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogViewer = new LogViewer();
            gValidator = new ValidatorWizard();
            gMainWindow = new MainWindow();
            Application.Run(gValidator);
        }
    }
}