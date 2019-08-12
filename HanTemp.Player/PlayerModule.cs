using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Unity.Ioc;
using Prism.Regions;
using Prism.Ioc;

namespace HanTemp.Player
{
    public class PlayerModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion(HanTemp.Infrastructure.Constants.RegionNames.MainRegion, typeof(Views.MonitorWindow));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation(typeof(Views.MonitorWindow), HanTemp.Infrastructure.Constants.ModuleNames.MonitorModel);
            containerRegistry.RegisterForNavigation(typeof(Views.MonitorWindow), HanTemp.Infrastructure.Constants.ModuleNames.MonitorModel);

        }
    }
}
