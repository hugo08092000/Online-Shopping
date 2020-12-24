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
using OnlineShoppingBUS;

namespace Online_Shopping
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if((UsernameTextBox.Text == "") || (PasswordTextBox.Password == ""))
            {

            }
            else
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Password;

                if (TaiKhoanBUS.Instance.CheckLogin(username, password))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    MainWindow main = new MainWindow();
                    this.Close();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if ((UsernameTextBox.Text == "") || (PasswordTextBox.Password == ""))
            {

            }
            else
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Password;

                if (TaiKhoanBUS.Instance.CheckUsername(username))
                {
                    TaiKhoanBUS.Instance.AddAccount(username, password);
                    MessageBox.Show("Đăng kí thành công!");

                    MainWindow main = new MainWindow();
                    this.Close();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại tài khoản!");
                }
            }
        }
    }
}
