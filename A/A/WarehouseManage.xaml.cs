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
    /// Interaction logic for WarehouseManage.xaml
    /// </summary>
    public partial class WarehouseManage : Window
    {
        public WarehouseManage()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            WarehouseView WarehouseAdd = new WarehouseView();
            WarehouseAdd.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            WarehouseUpdate w1 = new WarehouseUpdate();
            w1.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            WarehouseRemove WarehouseRemove = new WarehouseRemove();
            WarehouseRemove.Show();
        }

        private void AddNew_Click(object sender, RoutedEventArgs e)
        {
            WarehouseAdd WarehouseAdd = new WarehouseAdd();
            WarehouseAdd.Show();
        }
     }
}
