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

namespace SportWear.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListView.xaml
    /// </summary>
    public partial class ListView : Page
    {
        public ListView()
        {
            InitializeComponent();
           
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Manager.MainFrame.Navigate(new Pages.Auth());
            return;

        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Manager.MainFrame.Navigate(new Pages.UserAdd());
            return;
        }
    }
}
