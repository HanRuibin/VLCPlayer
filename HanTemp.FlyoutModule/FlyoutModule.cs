using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HanTemp.FlyoutModule
{
    public class FlyoutModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(HanTemp.Infrastructure.Constants.RegionNames.SettingFlyoutRegion, typeof(Views.FlyoutSetting));
            regionManager.RegisterViewWithRegion(HanTemp.Infrastructure.Constants.RegionNames.SettingFlyoutRegion, typeof(Views.FlyoutTransfer));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
