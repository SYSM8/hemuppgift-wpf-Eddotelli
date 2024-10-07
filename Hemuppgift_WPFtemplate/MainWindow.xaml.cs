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

        //Metod för att öppna upp Grid Window.
        private void OpenGridWindow(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        //Metod för att öppna upp StackPanel Window.
        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show();
        }

        //Metod för att öppna upp WrapPanel Window.
        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanel_Window wrapPanelWindow = new WrapPanel_Window();
            wrapPanelWindow.Show();
        }

        //Metod för att öppna upp DockPanel Window.
        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow dockPanelWindow = new DockPanelWindow();
            dockPanelWindow.Show();
        }
    }
}