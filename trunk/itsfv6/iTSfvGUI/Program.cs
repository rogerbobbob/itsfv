using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iTSfvLib;
using HelpersLib;
using System.IO;
using System.Threading;

namespace iTSfvGUI
{
    public static class Program
    {
        private static readonly string ApplicationName = Application.ProductName; // keep this top most
        private static readonly string LogFileName = ApplicationName + "Log-{0}.log";
        public static bool IsPortable { get; private set; }

        public static XMLSettings Config = null;
        public static Adapter Linker = new Adapter();

        // Windows
        public static ValidatorWizard gValidator = null;
        public static LogViewer LogViewer = null;
        public static MainWindow gMainWindow = null;
        public static XmlLibrary Library = null;

        public static XMLSettings ConfigCore = null;
        public static UserConfig ConfigUser = new UserConfig(); 

        private static readonly string DefaultPersonalPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), ApplicationName);
        private static readonly string PortablePersonalPath = Path.Combine(Application.StartupPath, ApplicationName);
        internal static readonly string ConfigCoreFileName = ApplicationName + "Settings.json";

        public static SynchronizationContext TreadUI = null;

        public static string PersonalPath
        {
            get
            {
                if (IsPortable)
                {
                    return PortablePersonalPath;
                }

                return DefaultPersonalPath;
            }
        }

        private static string ConfigCoreFilePath
        {
            get
            {
                return Path.Combine(PersonalPath, ConfigCoreFileName);
            }
        }

        public static string LogsFolderPath
        {
            get
            {
                return Path.Combine(PersonalPath, "Logs");
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                IsPortable = CLIHelper.CheckArgs(args, "p", "portable");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                LogViewer = new LogViewer();
                DebugHelper.MyLogger = LogViewer.Logger;

                gValidator = new ValidatorWizard();
                gMainWindow = new MainWindow();

                Program.ConfigCore = XMLSettings.Read(ConfigCoreFilePath);
                Application.Run(gValidator);
                Program.ConfigCore.Write(ConfigCoreFilePath);
            }
            finally
            {

            }
        }
    }
}