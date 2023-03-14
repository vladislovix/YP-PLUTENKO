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
    /// Логика взаимодействия для Postav.xaml
    /// </summary>
    public partial class Postav : Window
    {
        YPplutenkoEntities7 db;
        List<Поставщики> tb;
        public Postav()
        {
            InitializeComponent();
            db = new YPplutenkoEntities7();
            tb = db.Поставщики.ToList();
            SuppliersDataGrid.ItemsSource = tb;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello from Window 1!");
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var Search = db.Поставщики.ToList();
            Search = Search.Where(x => x.Наименование_поставщика.ToLower().StartsWith(SearchTextBox.Text.ToLower())).ToList();
            SuppliersDataGrid.ItemsSource = Search.ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            db = new YPplutenkoEntities7();
            Поставщики item = SuppliersDataGrid.SelectedItem as Поставщики;
            Поставщики del = db.Поставщики.Where(d => d.ID_поставщика == item.ID_поставщика).Single();
            db.Поставщики.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Строка успешно удалена!");
            refreshdatagrid();
        }

        private void Add_button(object sender, RoutedEventArgs e)
        {
            var nw = new Поставщики();
            db.Поставщики.Add(nw);
            AddPostav add = new AddPostav(db, nw);
            add.ShowDialog();
            refreshdatagrid();
        }
        private void refreshdatagrid()
        {
            SuppliersDataGrid.ItemsSource = db.Поставщики.ToList();
            SuppliersDataGrid.Items.Refresh();
        }
    }
}
