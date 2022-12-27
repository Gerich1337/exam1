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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            lvClients.ItemsSource = Connection.conect.Accounts.Where(z=>z.IdRole == 1).ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow window = new AddClientWindow();
            window.Show();
            this.Close();

        }
    }
}
