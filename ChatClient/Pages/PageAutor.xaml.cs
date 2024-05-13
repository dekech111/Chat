using ChatClient.dataFiles;
using ChatClient.Pages.Chat;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChatClient.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAutor.xaml
    /// </summary>
    public partial class PageAutor : Page
    {
        public PageAutor()
        {
            InitializeComponent();
        }

        private void btnShowPassword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            spHiddenPassword.Visibility = Visibility.Collapsed;
            spVisiblePassword.Visibility = Visibility.Visible;
            txbPassword.Text = pbPassword.Password;
        }

        private void btnHiddenPassword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            spHiddenPassword.Visibility = Visibility.Visible;
            spVisiblePassword.Visibility = Visibility.Collapsed;
            pbPassword.Password = txbPassword.Text;
        }

        private void pbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pbPassword.Password.Length == 0)
                tblPasswordHint.Visibility = Visibility.Visible;
            else
                tblPasswordHint.Visibility = Visibility.Hidden;
        }

        private void btnRegistr_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowsRegistr windowsRegistr = new WindowsRegistr();
            windowsRegistr.ShowDialog();
        }

        private void btnSingIn_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageMainChat());
        }
    }
}
