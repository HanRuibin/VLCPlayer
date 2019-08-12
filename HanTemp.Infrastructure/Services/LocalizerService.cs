using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLocalizeExtension.Engine;
using WPFLocalizeExtension.Extensions;

namespace HanTemp.Infrastructure.Services
{
    public class LocalizerService : Interfaces.ILocalizerService
    {
        public LocalizerService()
        {
            string culture = "en-US";
            this.SupportedLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures).Where(c => c.IetfLanguageTag.Equals("en-US") || c.IetfLanguageTag.Equals("zh-CN")).ToList<CultureInfo>();
            this.SetLocale(culture);
        }
        public CultureInfo SelectedLanguage
        {
            get
            {
                return LocalizeDictionary.Instance.Culture;
            }

            set
            {
                this.SetLocale(value);
            }
        }

        public IList<CultureInfo> SupportedLanguages
        {
            get;private set;
        }

        public string GetLocalizerString(string key)
        {
            string uiString;
            LocExtension locExtension = new LocExtension(key);
            locExtension.ResolveLocalizedValue(out uiString);
            return uiString;
        }

        public void SetLocale(CultureInfo cultrue)
        {
            LocalizeDictionary.Instance.Culture = cultrue;
        }

        public void SetLocale(string locale)
        {
            LocalizeDictionary.Instance.Culture = CultureInfo.GetCultureInfo(locale);
        }
    }
}
