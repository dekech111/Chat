using ChatClient.dataFiles;
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

namespace ChatClient.Pages.Chat
{
    /// <summary>
    /// Логика взаимодействия для PageMainChat.xaml
    /// </summary>
    public partial class PageMainChat : Page
    {
        public PageMainChat()
        {
            InitializeComponent();

            FrameApp.frmViewChat = FrmViewChat;
            FrameApp.frmSelectChat = FrmSelectChat;

            FrameApp.frmViewChat.Navigate(new PageViewChat());
            FrameApp.frmSelectChat.Navigate(new PageSelectChat());
        }
    }
}
