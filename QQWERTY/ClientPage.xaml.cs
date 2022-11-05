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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QQWERTY
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        MyDbContext context;
        public ClientPage()
        {
            InitializeComponent();
            context = new MyDbContext();
            ClientTable.ItemsSource = context.Client.ToList();
        }
        public void RefreszData()
        {
            var list = context.Client.ToList();
            if (!string.IsNullOrWhiteSpace(BoxFio.Text))
            {
                list = list.Where(x => x.name.ToLower().Contains(BoxFio.Text.ToLower())).ToList();
            }
            ClientTable.ItemsSource = list;
        }

        private void EditMaster(object sender, RoutedEventArgs e)
        {
            Client client = ClientTable.SelectedItem as Client;
            NavigationService.Navigate(new EditClient(context, client));
        }

        private void ChangeFio(object sender, TextChangedEventArgs e)
        {
            RefreszData();
        }
    }
}
