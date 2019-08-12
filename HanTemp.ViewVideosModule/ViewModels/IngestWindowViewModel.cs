using Prism.Mvvm;
using Prism.Events;
using Prism.Commands;
using System;
using HanTemp.Infrastructure.Models;
using HanTemp.Infrastructure.Events;

namespace HanTemp.ViewVideosModule.ViewModels
{
    public class IngestWindowViewModel:BindableBase
    {
        public IngestWindowViewModel(IEventAggregator eventAggregator)
        {
            EventAggre = eventAggregator;
            AddPlayListCommand = new DelegateCommand(AddPlayListCommandExecute);
        }

        private void AddPlayListCommandExecute()
        {
            PlayListModel pl = new PlayListModel {Name=PlayListName,DateTime=PlayListDate };
            EventAggre.GetEvent<AddPlayListEvent>().Publish(pl);
        }

        #region propertity
        public IEventAggregator EventAggre { get; set; }
        public DelegateCommand AddPlayListCommand { get; set; }
        public string PlayListName { get; set; }
        public DateTime PlayListDate { get; set; }
        #endregion
    }
}
