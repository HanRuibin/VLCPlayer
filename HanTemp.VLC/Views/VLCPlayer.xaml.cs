using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vlc.DotNet.Wpf;

namespace HanTemp.VLC.Views
{
    /// <summary>
    /// VLCPlayer.xaml 的交互逻辑
    /// </summary>
    public partial class VLCPlayer : UserControl
    {
        private VlcVideoSourceProvider vlcVideoSourceProvider;
        public VLCPlayer()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            var libDirectory = new DirectoryInfo(System.IO.Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            //this.vlcControl.SourceProvider.CreatePlayer(libDirectory);
            //this.vlcControl.SourceProvider.MediaPlayer.Play(new FileInfo(@"D:\迅雷下载\[阳光电影www.ygdy8.net].追龙.HD.720p.国语中字.mkv"));

            vlcVideoSourceProvider = new VlcVideoSourceProvider(this.Dispatcher);
            vlcVideoSourceProvider.CreatePlayer(libDirectory);
            SetBindings();
        }

        private void SetBindings()
        {
            this.image.SetBinding(Image.SourceProperty,
                new Binding(nameof(VlcVideoSourceProvider.VideoSource)){ Source= vlcVideoSourceProvider }
                );
        }

        private void btn_open_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            if(ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                var path = ofd.FileName;
                vlcVideoSourceProvider.MediaPlayer.Play(new FileInfo(path));
            }
        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {
            vlcVideoSourceProvider.MediaPlayer.Play();
        }

        private void btn_pause_Click(object sender, RoutedEventArgs e)
        {
            vlcVideoSourceProvider.MediaPlayer.Pause();
        }
    }
}
