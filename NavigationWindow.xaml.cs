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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для NavigationWindow.xaml
    /// </summary>
    public partial class NavigationWindow : Window
    {
        public NavigationWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Postav());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Client());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Sotrudniki());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Zakaz());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tovar());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ZakazTovar());
        }
    }
}
