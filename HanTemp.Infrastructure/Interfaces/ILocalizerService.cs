using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanTemp.Infrastructure.Interfaces
{
    public interface ILocalizerService
    {
        void SetLocale(string locale);
        void SetLocale(CultureInfo cultrue);
        string GetLocalizerString(string key);
        IList<CultureInfo> SupportedLanguages { get; }
        CultureInfo SelectedLanguage { get; set; }
    }
}
