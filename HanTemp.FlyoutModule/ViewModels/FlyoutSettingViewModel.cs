using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using System.Globalization;
using HanTemp.Infrastructure.Interfaces;
using Prism.Ioc;

namespace HanTemp.FlyoutModule.ViewModels
{
    public class FlyoutSettingViewModel:BindableBase
    {
        public FlyoutSettingViewModel(ILocalizerService localizeService)
        {
            localizerService = localizeService;
        }

        ILocalizerService localizerService=null;

        #region Properity

        public IList<CultureInfo> Languages
        {
            get
            {
                return localizerService.SupportedLanguages;
            }
        }


        public CultureInfo SelectedLanguage
        {
            get { return localizerService.SelectedLanguage; }
            set
            {
                localizerService.SelectedLanguage = value;
            }
        }

        #endregion
    }
}
