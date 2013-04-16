using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using HelpersLib;

namespace iTSfvLib
{
    [XmlRoot("Settings")]
    public class XMLSettings : SettingsBase<XMLSettings>
    {
        public string[] SupportedAudioTypes = new string[] { "mp3", "m4a" };

        [Category(MyStrings.App), DefaultValue(true), Description("All the tracks in a folder are treated as having the same Album Artist")]
        public bool TreatAsOneBandPerFolder { get; set; }

        [Category(MyStrings.App), DefaultValue(true), Description("Produce a report after validating")]
        public bool ProduceReport { get; set; }

        [Category(MyStrings.App), DefaultValue("Folder"), Description("Artwork file name without extension e.g. Folder")]
        public string ArtworkFileNameWithoutExtension { get; set; }

        public UserConfig UI = new UserConfig();

        public XMLSettings()
        {
            ApplyDefaultValues(this);
        }

        public static void ApplyDefaultValues(object self)
        {
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(self))
            {
                DefaultValueAttribute attr = prop.Attributes[typeof(DefaultValueAttribute)] as DefaultValueAttribute;
                if (attr == null) continue;
                prop.SetValue(self, attr.Value);
            }
        }

        public static XMLSettings Read(string filePath)
        {
            return SettingsHelper.Load<XMLSettings>(filePath, SerializationType.Xml);
        }

        public bool Write(string filePath)
        {
            return SettingsHelper.Save(this, filePath, SerializationType.Xml);
        }
    }
}