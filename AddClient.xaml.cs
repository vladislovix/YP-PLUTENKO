﻿using System;
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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        YPplutenkoEntities7 db;
        public AddClient(YPplutenkoEntities7 db, Клиенты d)
        {
            InitializeComponent();
            this.db = db;
            this.DataContext = d;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавлено");
            db.SaveChanges();
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
