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
using exam1.Classes;
using exam1.DB;
using exam1.Windows;

namespace exam1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var accounts = Connection.conect.Accounts.ToList().FirstOrDefault();
            if (accounts.Login == txtLogin.Text && accounts.Password == pbPassword.Password)
            {
                MessageBox.Show($"Здравствуйте, {accounts.Name}");
                //if (CurrentData.IdRole == 1)
                //{
                    AdminWindow win = new AdminWindow();
                    win.Show();
                    this.Close();
                //}
                //else if (CurrentData.IdRole == 2)
                //{
                //    AdminWindow win = new AdminWindow();
                //    win.Show();
                //    this.Close();
                //}
                CurrentData.IdAccount = accounts.IdAccount;
            }
            else
            {
                MessageBox.Show($"Заполните все поля");
            }
        }
        //public void RoleWindows()
        //{
        //    if (CurrentData.IdRole == 1)
        //    {
        //        ClientWindow win = new ClientWindow();
        //        win.Show();
        //        this.Close();
        //    }
        //    else if (CurrentData.IdRole == 2)
        //    {
        //        AdminWindow win = new AdminWindow();
        //        win.Show();
        //        this.Close();
        //    }
        //}
    }
}
