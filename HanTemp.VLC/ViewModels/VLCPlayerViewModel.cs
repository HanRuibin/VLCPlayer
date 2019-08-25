using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using System.Windows.Input;
using Prism.Commands;
using Vlc.DotNet.Wpf;
using Prism.Ioc;

namespace HanTemp.VLC.ViewModels
{
    public class VLCPlayerViewModel:BindableBase
    {
        public VLCPlayerViewModel()
        {

            OpenCommand = new DelegateCommand<object>(OpenCommandExecute);
        }

        private void OpenCommandExecute(object obj)
        {
            string path = obj as string;
        }

        public ICommand OpenCommand { get; set; }
        public VlcVideoSourceProvider SourceProvider { get; set; }
    }
}
