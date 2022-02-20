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
using BLL;

namespace IntraMAPua
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

  
        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxUsername.Text == "" || PasswordBox.Password == "")
            {
                MessageBox.Show("Do not leave empty entries");
                if (txtBoxUsername.Text == "")
                {
                    txtBoxUsername.Focus();
                }
                else
                {
                    PasswordBox.Focus();
                }
            }
            else
            {
                BusinessLogic FNameSetter = new BusinessLogic();
                string FullName;
                FullName = FNameSetter.ReturnName(txtBoxUsername.Text, PasswordBox.Password);
                if (FullName == "")
                {
                    MessageBox.Show("Log In Authentication Failed. Please try again.");
                    txtBoxUsername.Clear();
                    PasswordBox.Clear();
                    txtBoxUsername.Focus();
                }
                else
                {
                    MainWindow mymap = new MainWindow();
                    MessageBox.Show("Welcome " + FullName);
                    this.Close();
                    mymap.Show();
                }

            }


        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow open = new LoginWindow();
            MessageBox.Show("We are now taking you back to the Log-in page...");
            this.Close();
            open.Show();
        }

        private void CheckBoxShowPass_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxUsername.Text = PasswordBox.Password;
            PasswordBox.Visibility = Visibility.Collapsed;
            txtBoxUsername.Visibility = Visibility.Visible;
        }

        private void CheckBoxShowPass_Unchecked(object sender, RoutedEventArgs e)
        {
            txtBoxUsername.Visibility = Visibility.Collapsed;
            PasswordBox.Visibility = Visibility.Visible;
        }

       private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignupWindow signup = new SignupWindow();
            this.Close();
            signup.Show();
        }
    }
}
