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
using Prism.Regions;
using MahApps.Metro.Controls;

namespace HanTemp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            SetRegionManager(regionManager, this.RightWindowCommandsRegion, "RightWindowCommandsRegion");
            SetRegionManager(regionManager, this.FlyoutRegion, HanTemp.Infrastructure.Constants.RegionNames.SettingFlyoutRegion);

        }
        private void SetRegionManager(IRegionManager regionManager,DependencyObject regionTarget,string regionName)
        {
            RegionManager.SetRegionName(regionTarget, regionName);
            RegionManager.SetRegionManager(regionTarget, regionManager);
        }
    }
}
