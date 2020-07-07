using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Forms.Integration;
using AxCNxMediaPlayerApplicationForActiveXLib;

namespace CDVMediaPlayer.Views
{
    /// <summary>
    /// MediaPlayer.xaml 的交互逻辑
    /// </summary>
    public partial class MediaPlayer : UserControl
    {
        public MediaPlayer()
        {
            InitializeComponent();
            Loaded += MediaPlayer_Loaded;
        }

        private void MediaPlayer_Loaded(object sender, RoutedEventArgs e)
        {
            var player = new AxCNxMediaPlayer();
            //player.BeginInit();
            //player.EndInit();
            this.host.Child = player;

            mediaPlayerViewModel = new ViewModels.MediaPlayerViewModel(player);
            this.DataContext = mediaPlayerViewModel;
        }

        ViewModels.MediaPlayerViewModel mediaPlayerViewModel;
       

        private void Btn_SelectVideo_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            //ofd.Filter = "*.mxf|MXF File|*.MXF|*.8km|8KM File|*.*|All";
            ofd.Multiselect = false;
            if (ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                mediaPlayerViewModel.VideoPath = ofd.FileName;
            }
            ofd.Dispose();
        }
    }
}
