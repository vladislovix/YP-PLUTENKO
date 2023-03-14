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
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        YPplutenkoEntities7 db;
        List<Клиенты> tb;
        public Client()
        {
            InitializeComponent();
            db = new YPplutenkoEntities7();
            tb = db.Клиенты.ToList();
            SuppliersDataGrid.ItemsSource = tb;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var Search = db.Клиенты.ToList();
            Search = Search.Where(x => x.ФИО_клиента.ToLower().StartsWith(SearchTextBox.Text.ToLower())).ToList();
            SuppliersDataGrid.ItemsSource = Search.ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            db = new YPplutenkoEntities7();
            Клиенты item = SuppliersDataGrid.SelectedItem as Клиенты;
            Клиенты del = db.Клиенты.Where(d => d.ID_клиента == item.ID_клиента).Single();
            db.Клиенты.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Строка успешно удалена!");
            refreshdatagrid();
        }
        private void refreshdatagrid()
        {
            SuppliersDataGrid.ItemsSource = db.Клиенты.ToList();
            SuppliersDataGrid.Items.Refresh();
        }

        private void Add_button(object sender, RoutedEventArgs e)
        {
            var nw = new Клиенты();
            db.Клиенты.Add(nw);
            AddClient add = new AddClient(db, nw);
            add.ShowDialog();
            refreshdatagrid();
        }
    }
}
