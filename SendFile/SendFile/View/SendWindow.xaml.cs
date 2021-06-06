using BLL.Service;
using Microsoft.Win32;
using System.Windows;

namespace SendFile.View
{
    /// <summary>
    /// Interaction logic for SendWindow.xaml
    /// </summary>
    public partial class SendWindow : Window
    {
        public SendWindow()
        {
            InitializeComponent();
        }

        private void SelectFileBtn_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            fileDialog.ShowDialog();

            FilePathTb.Text = fileDialog.FileName;
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            var sendFileBLL = new SendFileBLL();

            sendFileBLL.GetFile(FilePathTb.Text);
        }
    }
}
