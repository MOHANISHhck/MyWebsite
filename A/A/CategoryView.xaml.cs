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
    /// Interaction logic for CategoryView.xaml
    /// </summary>
    public partial class CategoryView : Window
    {
        public CategoryView()
        {
            InitializeComponent();
            List<Member> items = new List<Member>();
            items.Add(new Member() { Name = "Mainboard" });
            items.Add(new Member() { Name = "Power supply"});
            items.Add(new Member() { Name = "Graphic card"});
            items.Add(new Member() { Name = "Network card" });
            items.Add(new Member() { Name = "SCSI card" });
            items.Add(new Member() { Name = "Logic board" });
            lvCategory.ItemsSource = items;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            {
                this.Close();
            }

        }
    }
    public class Member
    {
        public string Name { get; set; }
    }
}
