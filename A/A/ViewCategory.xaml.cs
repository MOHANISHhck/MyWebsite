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
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class ViewCategory : Window
    {
        public ViewCategory()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            CategoryView w1 = new CategoryView();
            w1.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            CategoryUpdate w1 = new CategoryUpdate();
            w1.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            CategoryRemove w1 = new CategoryRemove();
            w1.Show();
        }

        private void AddNew_Click(object sender, RoutedEventArgs e)
        {
            CategoryAdd w1 = new CategoryAdd();
            w1.Show();
        }
    }
}
