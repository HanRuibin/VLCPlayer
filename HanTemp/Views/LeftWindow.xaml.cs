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

namespace HanTemp.Views
{
    /// <summary>
    /// LeftWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LeftWindow : UserControl
    {
        public LeftWindow()
        {
            InitializeComponent();
        }

        public string FlyoutName
        {
            get { return HanTemp.Infrastructure.Constants.FlyoutNames.ShellSettingFlyoutName; }
        }

    }
}
