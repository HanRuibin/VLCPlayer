using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Ioc;
using AxCNxMediaPlayerApplicationForActiveXLib;
using System.Windows.Input;
using System.IO;

namespace CDVMediaPlayer.ViewModels
{
    public class MediaPlayerViewModel:BindableBase
    {
        private IRegionManager regionManager;
        private AxCNxMediaPlayer mediaPlayer;
        public MediaPlayerViewModel(AxCNxMediaPlayer _MediaPlayer)
        {
            mediaPlayer = _MediaPlayer;

            PlayCommand = new DelegateCommand(PlayCommandExecute);
            OpenCommand = new DelegateCommand(OpenCommandExecute);
        }

        private void OpenCommandExecute()
        {
            try
            {
                if (!string.IsNullOrEmpty(VideoPath)&&File.Exists(VideoPath))
                {
                    mediaPlayer.Open(VideoPath,0,0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PlayCommandExecute()
        {
            try
            {
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ICommand PlayCommand { get; set; }
        public ICommand OpenCommand { get; set; }

        private string videoPath;

        public string VideoPath
        {
            get { return videoPath; }
            set { this.SetProperty(ref videoPath, value); }
        }

    }
}
