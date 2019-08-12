using CS.Engine;
using NxBSEditApplicationWrapper;
using Prism.Regions;
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

namespace HanTemp.Player.Views
{
    /// <summary>
    /// MonitorWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MonitorWindow : UserControl,INavigationAware, IRegionMemberLifetime
    {
        public MonitorWindow()
        {
            InitializeComponent();
            Loaded += MonitorWindow_Loaded;
            
        }

        private void MonitorWindow_Loaded(object sender, RoutedEventArgs e)
        {
            oEditApplication = CNxEngineManager.Instance.EditApplication;
            AddHandleOp();
            AddVideo();
        }

        private void AddVideo()
        {
            m_CBSClipMonitor.BeginAddClip();
            m_CBSClipMonitor.BeginAddSegment();
            m_CBSClipMonitor.AddVideoFileNameofClip(videoPathTemp, 0, 0);
            m_CBSClipMonitor.AddAudioFileNameofClip(videoPathTemp,0,0);
            m_CBSClipMonitor.AddAudioFileNameofClip(videoPathTemp,0,0);
            m_CBSClipMonitor.EndAddSegment();
            m_CBSClipMonitor.EndAddClip();

            unsafe
            {
                tagRECT _rect = new tagRECT
                {
                    top = VideoPanel.Top,
                    left = VideoPanel.Left,
                    bottom = VideoPanel.Bottom,
                    right = VideoPanel.Right
                };
                oEditApplication.MoveliveWnd(2, _rect);
            }
            //m_CBSClipMonitor.EndShuttle();
            m_CBSClipMonitor.Play();
        }

        private void AddHandleOp()
        {
            unsafe
            {
                _RemotableHandle* handle = (_RemotableHandle*)VideoPanel.Handle;
                tagRECT _rect = new tagRECT
                {
                    top=VideoPanel.Top,
                    left=VideoPanel.Left,
                    bottom=VideoPanel.Bottom,
                    right=VideoPanel.Right
                };
                CNxEngineManager.Instance.AddLiveWindow(2, ref (*handle), _rect);

                CNxEngineManager.Instance.NewProject2(true);

                m_CBSClipMonitor = CNxEngineManager.Instance.CBSSequenceMonitor;
                
            }
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }


        #region privates
        CBSEditApplication oEditApplication = null;
        CBSSequenceMonitor m_CBSClipMonitor;
        string videoPathTemp = @"D:\MCEContent\20190328173207\High\节目01_20190328173207_1.mov";

        public bool KeepAlive
        {
            get
            {
                return true;
            }
        }
        #endregion
    }
}
