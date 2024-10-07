using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGridWindow(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show();
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanel_Window wrapPanelWindow = new WrapPanel_Window();
            wrapPanelWindow.Show();
        }
    }
}