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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var account = Connection.conect.Accounts.ToList();
            Accounts client = new Accounts{ Login = txtLogin.Text, Password = txtPassword.Text, Surname = txtSurname.Text, 
                Name = txtName.Text, Patronymic = txtPatronymic.Text, PhoneNumber = txtNumber.Text, IdRole = 1 };
            Connection.conect.Accounts.Add(client);
            Connection.conect.SaveChanges();
            MessageBox.Show("Клиент добавлен");
        }
    }
}
