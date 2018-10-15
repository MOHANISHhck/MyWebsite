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
    /// Interaction logic for View_Task.xaml
    /// </summary>
    public partial class ViewTask : Window
    {
        public ViewTask()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            TaskView w1 = new TaskView();
            w1.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            TaskUpdate w1 = new TaskUpdate();
            w1.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            TaskRemove w1 = new TaskRemove();
            w1.Show();
        }

        private void AddNew_Click(object sender, RoutedEventArgs e)
        {
            TaskAdd w1 = new TaskAdd();
            w1.Show();
        }
    }
}
