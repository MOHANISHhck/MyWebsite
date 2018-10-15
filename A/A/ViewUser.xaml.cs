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
    /// Interaction logic for View_User.xaml
    /// </summary>
    public partial class ViewUser : Window
    {
        public ViewUser()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            UserView w1 = new UserView();
            w1.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            UserUpdate w1 = new UserUpdate();
            w1.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            UserRemove w1 = new UserRemove();
            w1.Show();
        }

        private void AddNew_Click(object sender, RoutedEventArgs e)
        {
            UserAdd w1 = new UserAdd();
            w1.Show();
        }
    }
}
