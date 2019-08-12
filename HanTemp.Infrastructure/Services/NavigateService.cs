using Prism.Regions;
using Prism.Ioc;
using HanTemp.Infrastructure.Commands;
using HanTemp.Infrastructure.Interfaces;
using Prism.Commands;
using HanTemp.Infrastructure.Constants;
using System;

namespace HanTemp.Infrastructure.Services
{
    public class NavigateService:Interfaces.INavigateService
    {
        public NavigateService(IApplicationCommands applicationCommand,IRegionManager regionManager)
        {
            NavigateCommand = new DelegateCommand<object>(NavigateCommandExecute,CanNavigate);
            applicationCommand.NavigateCommand.RegisterCommand(NavigateCommand);
            navigateRegionManager = regionManager;
        }

        private bool CanNavigate(object obj)
        {
            return true;
        }

        private void NavigateCommandExecute(object obj)
        {
            if (obj == null)
                return;
            if(obj is string)
            {
                string page = obj as string;
                navigateRegionManager.RequestNavigate(RegionNames.MainRegion, page, Callback);

            }
        }

        private void Callback(NavigationResult obj)
        {
            
        }

        DelegateCommand<object> NavigateCommand;
        IRegionManager navigateRegionManager;
    }
}
