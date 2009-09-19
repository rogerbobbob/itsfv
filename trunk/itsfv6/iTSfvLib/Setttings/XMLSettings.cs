using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using System.IO;

namespace iTSfvLib
{
    [XmlRoot("Settings")]
    public class XMLValidatorSettings
    {
        public XMLValidatorSettings()
        {
            //~~~~~~~~~~~~~~~~~~~~~
            //  Capture
            //~~~~~~~~~~~~~~~~~~~~~

            CopyImageUntilURL = false;
            RegionTransparentValue = 75;
            RegionBrightnessValue = 15;
            BackgroundRegionTransparentValue = 100;
            BackgroundRegionBrightnessValue = 15;
            AutoIncrement = 0;

            //~~~~~~~~~~~~~~~~~~~~~
            //  Watermark
            //~~~~~~~~~~~~~~~~~~~~~

            DrawReflection = false;
            ReflectionPercentage = 20;
            ReflectionTransparency = 255;
            ReflectionOffset = 0;
            ReflectionSkew = true;
            ReflectionSkewSize = 25;

            //~~~~~~~~~~~~~~~~~~~~~
            //  FTP
            //~~~~~~~~~~~~~~~~~~~~~

            BackupFTPSettings = true;

            //~~~~~~~~~~~~~~~~~~~~~
            //  Options
            //~~~~~~~~~~~~~~~~~~~~~

            AutoSaveSettings = false;
            HideActiveHelp = false;

        }

        #region Settings

        //~~~~~~~~~~~~~~~~~~~~~
        //  Misc Settings
        //~~~~~~~~~~~~~~~~~~~~~



        //~~~~~~~~~~~~~~~~~~~~~
        //  Main
        //~~~~~~~~~~~~~~~~~~~~~


        public bool GTActiveHelp = false;
        public string HelpToLanguage = "en";

        //~~~~~~~~~~~~~~~~~~~~~
        //  Hotkeys
        //~~~~~~~~~~~~~~~~~~~~~



        //~~~~~~~~~~~~~~~~~~~~~
        //  Capture
        //~~~~~~~~~~~~~~~~~~~~~

        // General

        [Category("Capture / General"), DefaultValue(false), Description("Copy image to clipboard until URL is retrieved.")]
        public bool CopyImageUntilURL { get; set; }
        [Category("Capture / General"), DefaultValue(75), Description("Region style setting. Must be between these values: 0, 255")]
        public int RegionTransparentValue { get; set; }
        [Category("Capture / General"), DefaultValue(15), Description("Region style setting. Must be between these values: -100, 100")]
        public int RegionBrightnessValue { get; set; }
        [Category("Capture / General"), DefaultValue(100), Description("Region style setting. Must be between these values: 0, 255")]
        public int BackgroundRegionTransparentValue { get; set; }
        [Category("Capture / General"), DefaultValue(15), Description("Region style setting. Must be between these values: -100, 100")]
        public int BackgroundRegionBrightnessValue { get; set; }

        [Category("Capture / Watermark"), DefaultValue(false), Description("Draw reflection bottom of screenshots.")]
        public bool DrawReflection { get; set; }
        [Category("Capture / Watermark"), DefaultValue(20), Description("Reflection height size relative to screenshot height.")]
        public int ReflectionPercentage { get; set; }
        [Category("Capture / Watermark"), DefaultValue(255), Description("Reflection transparency start from this value to 0.")]
        public int ReflectionTransparency { get; set; }
        [Category("Capture / Watermark"), DefaultValue(0), Description("Reflection position will be start: Screenshot height + Offset")]
        public int ReflectionOffset { get; set; }
        [Category("Capture / Watermark"), DefaultValue(true), Description("Adding skew to reflection from bottom left to bottom right.")]
        public bool ReflectionSkew { get; set; }
        [Category("Capture / Watermark"), DefaultValue(25), Description("How much pixel skew left to right.")]
        public int ReflectionSkewSize { get; set; }

        // Crop Shot

        public bool CropRegionRectangleInfo = true;
        public bool CropRegionHotkeyInfo = true;

        public bool CropDynamicCrosshair = true;
        public int CropInterval = 25;
        public int CropStep = 1;
        public int CrosshairLineCount = 2;
        public int CrosshairLineSize = 25;

        public bool CropShowBigCross = true;
        public bool CropShowMagnifyingGlass = true;

        public bool CropShowRuler = true;
        public bool CropDynamicBorderColor = true;
        public decimal CropRegionInterval = 75;
        public decimal CropRegionStep = 5;
        public decimal CropHueRange = 50;

        public decimal CropBorderSize = 1;
        public bool CropShowGrids = false;

        // Selected Window


        public bool SelectedWindowFront = false;
        public bool SelectedWindowRectangleInfo = true;
        public bool SelectedWindowRuler = true;

        public decimal SelectedWindowBorderSize = 2;
        public bool SelectedWindowDynamicBorderColor = true;
        public decimal SelectedWindowRegionInterval = 75;
        public decimal SelectedWindowRegionStep = 5;
        public decimal SelectedWindowHueRange = 50;
        public bool SelectedWindowAddBorder = false;

        // Interaction

        public decimal FlashTrayCount = 1;
        public bool CaptureEntireScreenOnError = false;
        public bool ShowBalloonTip = true;
        public bool BalloonTipOpenLink = false;
        public bool ShowUploadDuration = false;
        public bool CompleteSound = false;
        public bool CloseDropBox = false;
        public bool CloseQuickActions = false;

        // Naming Conventions

        public string NamingActiveWindow = "%t-%y.%mo.%d-%h.%mi.%s";
        public string NamingEntireScreen = "SS-%y.%mo.%d-%h.%mi.%s";
        [Category("Capture / File Naming"), DefaultValue(0), Description("Adjust the current Auto-Increment number.")]
        public int AutoIncrement { get; set; }

        // Quality

        public int FileFormat = 0;
        public decimal ImageQuality = 90;
        public decimal SwitchAfter = 512;
        public int SwitchFormat = 1;

        //~~~~~~~~~~~~~~~~~~~~~
        //  Watermark
        //~~~~~~~~~~~~~~~~~~~~~


        public decimal WatermarkOffset = 5;
        public bool WatermarkAddReflection = false;
        public bool WatermarkAutoHide = true;


        public decimal WatermarkFontTrans = 255;
        public decimal WatermarkCornerRadius = 4;

        public decimal WatermarkBackTrans = 225;


        public string WatermarkImageLocation = "";
        public bool WatermarkUseBorder = false;
        public decimal WatermarkImageScale = 100;

        //~~~~~~~~~~~~~~~~~~~~~
        //  Text Uploaders
        //~~~~~~~~~~~~~~~~~~~~~

        public int SelectedTextUploader = 0;

        //~~~~~~~~~~~~~~~~~~~~~
        //  Editors
        //~~~~~~~~~~~~~~~~~~~~~


        public bool TextEditorEnabled = false;

        //~~~~~~~~~~~~~~~~~~~~~
        //  FTP
        //~~~~~~~~~~~~~~~~~~~~~


        public int FTPSelected = -1;
        public bool FTPCreateThumbnail = false;
        public bool AutoSwitchFTP = true;
        [Category("FTP"), DefaultValue(true), Description("Periodically backup FTP settings.")]
        public bool BackupFTPSettings { get; set; }

        //~~~~~~~~~~~~~~~~~~~~~
        //  HTTP
        //~~~~~~~~~~~~~~~~~~~~~

        // Image Uploaders


        public decimal ErrorRetryCount = 3;
        public bool ImageUploadRetry = true;
        public bool AddFailedScreenshot = false;
        public bool AutoChangeUploadDestination = true;
        public decimal UploadDurationLimit = 10000;
        public string ImageShackRegistrationCode = "";
        public string TinyPicShuk = "";
        [Category("HTTP / TinyPic")]
        public string TinyPicUserName { get; set; }
        [Category("HTTP / TinyPic"), PasswordPropertyText(true)]
        public string TinyPicPassword { get; set; }
        public bool RememberTinyPicUserPass = false;
        public bool TinyPicSizeCheck = false;

        // Custom Image Uploaders
        public int ImageUploaderSelected = 0;

        // Language Translator

        public string FromLanguage = "auto";
        public string ToLanguage = "en";
        public string ToLanguage2 = "?";
        public bool ClipboardTranslate = false;

        //~~~~~~~~~~~~~~~~~~~~~
        //  History
        //~~~~~~~~~~~~~~~~~~~~~

        // History Settings

        public int HistoryMaxNumber = 50;
        public bool HistorySave = true;
        public bool HistoryShowTooltips = true;
        public bool HistoryAddSpace = false;
        public bool HistoryReverseList = false;

        //~~~~~~~~~~~~~~~~~~~~~
        //  Options
        //~~~~~~~~~~~~~~~~~~~~~

        // Actions Toolbar 
        [Category("Options / Actions Toolbar"), Description("Open Actions Toolbar on startup.")]
        public bool ActionsToolbarMode { get; set; }
        [Category("Options / Actions Toolbar"), Description("Action Toolbar Location.")]


        // General

        public bool OpenMainWindow = false;
        public bool ShowInTaskbar = true;
        public bool LockFormSize = false;
        [Category("Options / General"), DefaultValue(false), Description("Auto save settings whenever form is resized or main" +
            " tabs are changed. Normally settings are saved only after form is closed.")]
        public bool AutoSaveSettings { get; set; }
        public bool CheckUpdates = true;

        public bool CheckExperimental = false;
        [Category("Options / General"), DefaultValue(true), Description("Write debug information into a log file.")]
        public bool WriteDebugFile { get; set; }
        [Category("Options / General"), DefaultValue(false), Description("Hides active help in bottom of form.")]
        public bool HideActiveHelp { get; set; }

        // Paths

        public bool DeleteLocal = false;
        public decimal ScreenshotCacheSize = 50;
        [Category("Options / Paths"), DefaultValue(true), Description("Periodically backup application settings.")]
        public bool BackupApplicationSettings { get; set; }
        [Category("Options / Paths"), Description("Images directory where screenshots and pictures will be stored locally.")]
        public string ImagesDir { get; set; }


        //~~~~~~~~~~~~~~~~~~~~~
        //  Auto Capture
        //~~~~~~~~~~~~~~~~~~~~~

        public bool AutoCaptureAutoMinimize = false;
        public bool AutoCaptureWaitUploads = true;

        #endregion

        #region Serialization Helpers

        public enum ColorFormat
        {
            NamedColor,
            ARGBColor
        }

        #endregion

        #region I/O Methods

        public void Write(string filePath)
        {
            /* try
             {
 */
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            XmlSerializer xs = new XmlSerializer(typeof(XMLValidatorSettings));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                xs.Serialize(fs, this);
            }
            /* }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
             }*/
        }

        public static XMLValidatorSettings Read(string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(XMLValidatorSettings));
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        return (XMLValidatorSettings)xs.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    // We dont need a MessageBox when we rename enumerations
                    // Renaming enums tend to break parts of serialization
                    // FileSystem.AppendDebug(ex.ToString());
                }
            }

            return new XMLValidatorSettings();
        }

        #endregion
    }
}
