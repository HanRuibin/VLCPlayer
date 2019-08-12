using System.Windows.Controls;
using MahApps.Metro.Controls;

namespace HanTemp.FlyoutModule.Views
{
    /// <summary>
    /// Flyout.xaml 的交互逻辑
    /// </summary>
    public partial class FlyoutSetting : Flyout,HanTemp.Infrastructure.Interfaces.IFlyoutVIew
    {
        public FlyoutSetting()
        {
            InitializeComponent();
        }

        public string FlyoutName
        {
            get { return HanTemp.Infrastructure.Constants.FlyoutNames.ShellSettingFlyoutName; }
        }
    }
}
