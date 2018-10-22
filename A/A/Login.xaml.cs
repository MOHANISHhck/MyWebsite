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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "" || psboxPassword.Password == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            else if (txtUsername.Text != "user" || psboxPassword.Password != "password")
            {

                MessageBox.Show("Incorrect username or password");

            }
            else 
            {
                MainWindow w1 = new MainWindow();
                w1.Show();
                this.Close();

            }
        }
    }
}
