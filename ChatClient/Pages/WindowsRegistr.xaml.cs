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

namespace ChatClient.Pages
{
    /// <summary>
    /// Логика взаимодействия для WindowsRegistr.xaml
    /// </summary>
    public partial class WindowsRegistr : Window
    {
        public WindowsRegistr()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ты красавчик!");
        }
    }
}
