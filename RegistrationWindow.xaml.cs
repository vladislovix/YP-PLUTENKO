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
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private SqlConnection connection;

        public RegistrationWindow()
        {
            InitializeComponent();
            btnRegister.Click += btnRegister_Click_1;
            btnCancel.Click += BtnCancel_Click;
            string connectionString = "Data Source=serverName;Initial Catalog=databaseName;User ID=userName;Password=password";
            SqlConnection connection = new SqlConnection(connectionString);
        }

       

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click_1(object sender, RoutedEventArgs e)
        {
            // Проверка данных
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                // Сохранение информации о пользователе в базе данных
                string query = "INSERT INTO Users (FirstName, LastName, Login, Password) VALUES (@FirstName, @LastName, @Login, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                MessageBox.Show("Вы успешно зарегистрировались!");
                this.Close();
            }
        }
    }
}

