using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using HelpersLib;
using System.ComponentModel;

namespace iTSfvLib
{
    public class UserConfig :SettingsBase<UserConfig>
    {
        public bool Checks_MissingTags { get; set; }
        public bool Tracks_TrackCountFill { get; set; }
        public bool Tracks_AlbumArtistFill { get; set; }
        public bool Tracks_GenreFill { get; set; }
        public bool FileSystem_ArtworkJpgExport { get; set; }

        public static void ApplyDefaultValues(object self)
        {
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(self))
            {
                DefaultValueAttribute attr = prop.Attributes[typeof(DefaultValueAttribute)] as DefaultValueAttribute;
                if (attr == null) continue;
                prop.SetValue(self, attr.Value);
            }
        }

        public static bool IsConfigured(UserConfig self)
        {
            PropertyInfo[] properties = typeof(UserConfig).GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                if (pi.PropertyType == typeof(Boolean) && (bool)pi.GetValue(self, null))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
