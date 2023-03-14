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
    /// Логика взаимодействия для AddSotryd.xaml
    /// </summary>
    public partial class AddSotryd : Window
    {

        YPplutenkoEntities7 db;
        public AddSotryd(YPplutenkoEntities7 db, Сотрудники d)
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
