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
            ViewPart w1 = new ViewPart();
            w1.Show();
        }
        private void ViewStock_Click(object sender, RoutedEventArgs e)
        {
            ViewStock w1 = new ViewStock();
            w1.Show();
        }
        private void ViewWarehouse_Click(object sender, RoutedEventArgs e)
        {
            ViewWarehouses w1 = new ViewWarehouses();
            w1.Show();
        }
        private void ViewTask_Click(object sender, RoutedEventArgs e)
        {
            ViewTask w1 = new ViewTask();
            w1.Show();
        }
        private void ViewUser_Click(object sender, RoutedEventArgs e)
        {
            ViewUser w1 = new ViewUser();
            w1.Show();
        }
        private void ViewGroup_Click(object sender, RoutedEventArgs e)
        {
            ViewGroup w1 = new ViewGroup();
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
        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            Inventory w1 = new Inventory();
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
        private void AddStock_Click(object sender, RoutedEventArgs e)
        {
            StockAdd w1 = new StockAdd();
            w1.Show();
        }
        private void DeleteStock_Click(object sender, RoutedEventArgs e)
        {
            StockRemove w1 = new StockRemove();
            w1.Show();
        }
        private void UpdateStock_Click(object sender, RoutedEventArgs e)
        {
            StockUpdate w1 = new StockUpdate();
            w1.Show();
        }
        private void MoveStock_Click(object sender, RoutedEventArgs e)
        {
            StockMove w1 = new StockMove();
            w1.Show();
        }
    }
}
