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

namespace A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            About w1 = new About();
            w1.Show();
        }
        private void ViewPart_Click(object sender, RoutedEventArgs e)
        {
            PartView w1 = new PartView();
            w1.Show();
        }
        private void ViewWarehouse_Click(object sender, RoutedEventArgs e)
        {
            WarehouseView w1 = new WarehouseView();
            w1.Show();
        }
        private void ViewUser_Click(object sender, RoutedEventArgs e)
        {
            UserView w1 = new UserView();
            w1.Show();
        }
        private void ViewCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryView w1 = new CategoryView();
            w1.Show();
        }
        private void StockReport_Click(object sender, RoutedEventArgs e)
        {
            StockReport w1 = new StockReport();
            w1.Show();
        }
        private void WarehouseReport_Click(object sender, RoutedEventArgs e)
        {
            WarehouseReport w1 = new WarehouseReport();
            w1.Show();
        }

        private void AddWarehouse_Click(object sender, RoutedEventArgs e)
        {
            WarehouseAdd w1 = new WarehouseAdd();
            w1.Show();
        }
        private void UpdateWarehouse_Click(object sender, RoutedEventArgs e)
        {
            WarehouseUpdate w1 = new WarehouseUpdate();
            w1.Show();
        }
        private void DeleteWarehouse_Click(object sender, RoutedEventArgs e)
        {
            WarehouseRemove w1 = new WarehouseRemove();
            w1.Show();
        }

         private void AddPart_Click(object sender, RoutedEventArgs e)
        {
            PartAdd w1 = new PartAdd();
            w1.Show();
        }
        private void DeletePart_Click(object sender, RoutedEventArgs e)
        {
            PartRemove w1 = new PartRemove();
            w1.Show();
        }
        private void UpdatePart_Click(object sender, RoutedEventArgs e)
        {
            PartUpdate w1 = new PartUpdate();
            w1.Show();
        }

         private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            UserAdd w1 = new UserAdd();
            w1.Show();
        }
        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            UserRemove w1 = new UserRemove();
            w1.Show();
        }
        private void UpdateUser_Click(object sender, RoutedEventArgs e)
        {
            UserUpdate w1 = new UserUpdate();
            w1.Show();
        }
        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryAdd w1 = new CategoryAdd();
            w1.Show();
        }
        private void DeleteCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryRemove w1 = new CategoryRemove();
            w1.Show();
        }
        private void UpdateCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryUpdate w1 = new CategoryUpdate();
            w1.Show();
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            PasswordChange w1 = new PasswordChange();
            w1.Show();
        }
    }
}

