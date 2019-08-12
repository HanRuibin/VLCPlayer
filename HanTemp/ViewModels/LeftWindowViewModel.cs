using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace HanTemp.ViewModels
{
    public class LeftWindowViewModel:BindableBase
    {
        public LeftWindowViewModel()
        {

        }
        private string settingName="Setting";

        public string SettingName
        {
            get { return settingName; }
            set { SetProperty(ref settingName, value); }
        }

    }
}
