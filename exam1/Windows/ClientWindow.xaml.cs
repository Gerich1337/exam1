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
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
            lvPhones.ItemsSource = Connection.conect.Phones.ToList();
        }

        private void lvPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var phones = Connection.conect.Phones.FirstOrDefault();
            CurrentData.IdPhone = phones.IdPhone;
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            var act = Connection.conect.ActsOfBuying.ToList();
            ActsOfBuying actsOfBuying = new ActsOfBuying { IdAccount = CurrentData.IdAccount, IdPhone = CurrentData.IdPhone };
            Connection.conect.ActsOfBuying.Add(actsOfBuying);
            Connection.conect.SaveChanges();
            MessageBox.Show("Телефон добавлен в акт покупок");
        }
    }
}
