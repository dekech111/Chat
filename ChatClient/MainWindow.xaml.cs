using ChatClient.dataFiles;
using ChatClient.Pages;
using System.Windows;

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameApp.frmObj = FrmMain;

            FrameApp.frmObj.Navigate(new PageAutor());
        }
    }
}
