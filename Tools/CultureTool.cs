using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading;

namespace Tools
{
    public class CultureTool
    {
        /// <summary>
        /// 字串轉語系 取得合法語系名稱
        /// </summary>
        /// <param name="name">語系名稱 (e.g. en-US)</param>
        public static string GetImplementedCulture(string name)
        {
            // give a default culture just in case
            string cultureName = GetDefaultCulture();
            // check if it's implemented
            try
            {
                if (EnumHelper.TryGetValueFromDescription<LanguageEnum>(name))
                    cultureName = name;
                return cultureName;
            }
            catch (System.Exception)
            {
                return GetDefaultCulture();
            }
        }

        /// <summary>
        /// 取得預設 語系名稱
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultCulture()
        {
            return LanguageEnum.Taiwan.GetDescription();
        }
        /// <summary>
        /// 取得目前 語系
        /// </summary>
        /// <returns></returns>
        public static LanguageEnum GetCurrentLanguage()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;
            // get implemented culture name
            currentCulture = GetImplementedCulture(currentCulture);
            // get language by implemented culture name
            return EnumHelper.GetValueFromDescription<LanguageEnum>(currentCulture);
        }
        /// <summary>
        /// 語系是不是是正體中文?
        /// </summary>
        /// <returns></returns>
        public static bool IsCht()
        {
            return GetCurrentLanguage() == LanguageEnum.Taiwan;
        }

    }


}
