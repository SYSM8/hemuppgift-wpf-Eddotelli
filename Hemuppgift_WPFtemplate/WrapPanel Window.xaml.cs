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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for WrapPanel_Window.xaml
    /// </summary>
    public partial class WrapPanel_Window : Window
    {
        public WrapPanel_Window()
        {
            InitializeComponent();
        }

        private void rbtnHorizontal_Checked(object sender, RoutedEventArgs e)
        {
            OrientationStackPanel.Orientation = Orientation.Horizontal;
        }

        private void rbtnVertical_Checked(object sender, RoutedEventArgs e)
        {
            OrientationStackPanel.Orientation = Orientation.Vertical;
        }
    }
}
