using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayerLibrary.ExtensionMethods
{
    public static class EnumExtensionMethods
    {
        public static T ToEnum<T>(this string value, bool ignoreCase = true)
            {
                return (T)Enum.Parse(typeof(T), value, ignoreCase);
            }
    }
}
