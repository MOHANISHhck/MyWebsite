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

namespace A
{
    /// <summary>
    /// Interaction logic for StockManage.xaml
    /// </summary>
    public partial class StockManage : Window
    {
        public StockManage()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            StockView w1 = new StockView();
            w1.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            StockUpdate w1 = new StockUpdate();
            w1.Show();
        }

        private void RemoveStock_Click(object sender, RoutedEventArgs e)
        {
            StockRemove w1 = new StockRemove();
            w1.Show();
        }

        private void AddStock_Click(object sender, RoutedEventArgs e)
        {
            StockAdd w1 = new StockAdd();
            w1.Show();
        }
        private void Move_Click(object sender, RoutedEventArgs e)
        {
            StockMove w1 = new StockMove();
            w1.Show();
        }
    }
}
