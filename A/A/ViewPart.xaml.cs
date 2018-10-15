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
    /// Interaction logic for View_Part.xaml
    /// </summary>
    public partial class ViewPart : Window
    {
        public ViewPart()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            PartView w1 = new PartView();
            w1.Show();            
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            PartUpdate w1 = new PartUpdate();
            w1.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            PartRemove w1 = new PartRemove();
            w1.Show();
        }

        private void AddNew_Click(object sender, RoutedEventArgs e)
        {
            PartAdd w1 = new PartAdd();
            w1.Show();
        }
    }
}
