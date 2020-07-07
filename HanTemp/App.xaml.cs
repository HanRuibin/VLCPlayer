using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism;
using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using System.Windows.Controls;
using Prism.Modularity;
using HanTemp.Infrastructure.Interfaces;
using HanTemp.Infrastructure.Services;
using Prism.Mvvm;

namespace HanTemp
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return this.Container.Resolve<MainWindow>();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register(typeof(IApplicationCommands), typeof(HanTemp.Infrastructure.Commands.ApplicationCommandsProxy));
            containerRegistry.RegisterInstance<IFlyoutService>(Container.Resolve<FlyoutService>());
            containerRegistry.RegisterInstance<INavigateService>(Container.Resolve<NavigateService>());
            containerRegistry.RegisterInstance<ILocalizerService>(Container.Resolve<LocalizerService>());
        }
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel),Container.Resolve<Mapping.StackPanelAdapter>());
        }
        protected override void InitializeShell(Window shell)
        {
            base.InitializeShell(shell);
            var regionManager = this.Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(HanTemp.Infrastructure.Constants.RegionNames.RigthWindowCommandsRegion, typeof(Views.LeftWindow));

        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(typeof(HanTemp.Menu.MenuModule));
            moduleCatalog.AddModule(typeof(HanTemp.FlyoutModule.FlyoutModule));
            moduleCatalog.AddModule(typeof(HanTemp.VLC.VLCPlayerModule));
            moduleCatalog.AddModule(typeof(CDVMediaPlayer.MediaPlayerModule));
        }
    }
}
