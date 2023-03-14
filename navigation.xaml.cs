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
    /// Логика взаимодействия для navigation.xaml
    /// </summary>
    public partial class navigation : Window
    {
        public navigation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Postav w2 = new Postav();
            w2.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Client w3 = new Client();
            w3.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Sotrudniki w4 = new Sotrudniki();
            w4.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Zakaz w5 = new Zakaz();
            w5.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Tovar w6 = new Tovar();
            w6.ShowDialog();
        }
    }
}
