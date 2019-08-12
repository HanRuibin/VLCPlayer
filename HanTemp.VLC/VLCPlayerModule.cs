using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using HanTemp.VLC.Views;

namespace HanTemp.VLC
{
    public class VLCPlayerModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion(HanTemp.Infrastructure.Constants.RegionNames.MainRegion,typeof(VLCPlayer));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation(typeof(Views.VLCPlayer), HanTemp.Infrastructure.Constants.ModuleNames.VLCPlayerModel);
        }
    }
}
