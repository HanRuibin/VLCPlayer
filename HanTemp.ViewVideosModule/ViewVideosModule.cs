using System;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HanTemp.ViewVideosModule
{
    public class ViewVideosModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion(HanTemp.Infrastructure.Constants.RegionNames.MainRegion, typeof(Views.IngestWindow));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation(typeof(Views.ViewVideosWindow), Infrastructure.Constants.ModuleNames.ViewVideosModel);
            containerRegistry.RegisterForNavigation(typeof(Views.UCPlayList),Infrastructure.Constants.ModuleNames.PlayListModel);
            containerRegistry.RegisterForNavigation(typeof(Views.IngestWindow), Infrastructure.Constants.ModuleNames.IngestModel);

        }
    }
}
