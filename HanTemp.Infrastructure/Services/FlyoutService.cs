using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Regions;
using MahApps.Metro;
using HanTemp.Infrastructure.Interfaces;
using System.Linq.Expressions;

namespace HanTemp.Infrastructure.Services
{
    
    public class FlyoutService : IFlyoutService
    {
        ICommand ShowFlyoutCommand { get; set; }
        IRegionManager RegionManager { get; set; }

        public FlyoutService(Interfaces.IApplicationCommands applicationCommand,IRegionManager regionManager)
        {
            RegionManager = regionManager;
            ShowFlyoutCommand = new DelegateCommand<string>(ShowFlyout, CanShowFlyout);
            applicationCommand.ShowCommand.RegisterCommand(ShowFlyoutCommand);

        }

        public void ShowFlyout(string str)
        {
            try
            {
                var views = RegionManager.Regions[Constants.RegionNames.SettingFlyoutRegion].Views;
                var view = views.FirstOrDefault(v => v is Interfaces.IFlyoutVIew&&(v as IFlyoutVIew).FlyoutName.Equals(str));
                if(view!=null)
                {
                    (view as MahApps.Metro.Controls.Flyout).IsOpen = !(view as MahApps.Metro.Controls.Flyout).IsOpen;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public bool CanShowFlyout(string obj)
        {
            return true;
        }
    }
}
