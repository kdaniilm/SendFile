using SendFile.View;
using System.Windows;

namespace SendFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadClick(object sender, RoutedEventArgs e)
        {
            var loadWindow = new LoadWindow();
            this.Close();
            loadWindow.Show();
        }
        private void SendClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
