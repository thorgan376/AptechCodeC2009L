using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using WAD_C2009L_NguyenVanA.Models;

namespace WAD_C2009L_NguyenVanA
{
    public class LanguageManager
    {
        public static List<Language> AvailableLanguages = new List<Language> {
            new Language {
                LanguageFullName = "English", LanguageCultureName = "en"
            },
            new Language {
                LanguageFullName = "Vietnamese", LanguageCultureName = "vi-VN"
            }            
        };
        public static bool IsLanguageAvailable(string lang)
        {
            /*
            var someNumbers = new List<int>() { 1, 4, 5, 6, 78, 9};
            int myNumber = someNumbers.Where(eachNumber => eachNumber > 5).FirstOrDefault();
            */
            return AvailableLanguages
                .Where(eachLanguage => eachLanguage.LanguageCultureName
                    .ToLower().Equals(lang.ToLower()))
                    .FirstOrDefault() != null ? true : false;
        }
        public static string GetDefaultLanguage() => AvailableLanguages[0].LanguageCultureName;       
        public void SetLanguage(string lang)
        {
            try
            {
                if (!IsLanguageAvailable(lang)) lang = GetDefaultLanguage();
                var cultureInfo = new CultureInfo(lang);
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
                //"culture": "vn"
                HttpCookie langCookie = new HttpCookie("culture", lang);
                langCookie.Expires = DateTime.Now.AddYears(1);
                HttpContext.Current.Response.Cookies.Add(langCookie);
            }
            catch (Exception) { }
        }
    }
    
}