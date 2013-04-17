using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iTSfvLib;
using HelpersLib;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.Reflection;

namespace iTSfvGUI
{
    public static class Program
    {
        private static readonly string ApplicationName = Application.ProductName; // keep this top most
        private static readonly string LogFileName = ApplicationName + "Log-{0}.log";
        public static bool IsPortable { get; private set; }

        public static BackgroundWorker SettingsReader = new BackgroundWorker();
        public static XMLSettings Config = null;

        // Windows
        public static ValidatorWizard MainForm = null;
        public static LogViewer LogViewer = null;
        public static XmlLibrary Library = null;

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

        public static string Title
        {
            get
            {
                string title = string.Format("{0} {1} r{2}", ApplicationName, Application.ProductVersion, AppRevision);
                if (IsPortable) title += " Portable";
                return title;
            }
        }

        public static string AppRevision
        {
            get
            {
                return AssemblyVersion.Split('.')[3];
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
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

                MainForm = new ValidatorWizard();
                SettingsReader.DoWork += SettingsReader_DoWork;
                SettingsReader.RunWorkerCompleted += MainForm.SettingsReader_RunWorkerCompleted;
                SettingsReader.RunWorkerAsync();

                Application.Run(MainForm);
                Program.Config.Write(ConfigCoreFilePath);
            }
            finally
            {

            }
        }

        static void SettingsReader_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.Config = XMLSettings.Read(ConfigCoreFilePath);
        }
    }
}