using System;
using System.ComponentModel;
using System.Reflection;

namespace Tools
{
    /// <summary>
    /// 取出Enum中的Description欄位
    /// </summary>
    public static class EnumExtensionsBase
    {
        public static string GetDescription(this Enum enumValue)
        {
            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return enumValue.ToString();
        }
    }
}