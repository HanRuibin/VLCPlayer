using Prism.Events;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HanTemp.Infrastructure.Models;
using HanTemp.Infrastructure.Events;
using System;

namespace HanTemp.ViewVideosModule.ViewModels
{
    public class UCPlayListViewModel:BindableBase
    {
        public UCPlayListViewModel(IEventAggregator eventaggregator)
        {
            ea = eventaggregator;
            ea.GetEvent<AddPlayListEvent>().Subscribe(AddPlaylist);
            Playlist.Add(new PlayListModel { Name = "@han By WPF开发", DateTime = DateTime.Now });
        }

        private void AddPlaylist(PlayListModel obj)
        {
            try
            {
                Playlist.Add(obj);
            }
            catch (Exception ex)
            {

            }
        }

        private IEventAggregator ea;
        private IList<PlayListModel> playList=new ObservableCollection<PlayListModel>();

        public IList<PlayListModel> Playlist
        {
            get { return playList; }
            set { SetProperty(ref playList,value); }
        }


    }
}
