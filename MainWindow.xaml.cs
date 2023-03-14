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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtLogin.Text;
            string pass = txtPassword.Password;
            // Проверка логина и пароля
            if (username == "admin" && pass == "admin")
            {

                MessageBox.Show("Вы успешно авторизовались!");
                navigation w1 = new navigation();
                w1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации. Проверьте логин и пароль.");
            }
        }

        private void btnRegister_Click_1(object sender, RoutedEventArgs e)
        {
            // Открыть окно регистрации
            RegistrationWindow regWindow = new RegistrationWindow();
            regWindow.ShowDialog();
        }
    }
}
