using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace iTSfvLib
{
    public class UserConfig
    {
        public bool CheckMissingTags { get; set; }

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
