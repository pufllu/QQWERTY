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
    /// Логика взаимодействия для EditClient.xaml
    /// </summary>
    public partial class EditClient : Page
    {
        MyDbContext context;
        internal EditClient(MyDbContext cont)
        {
            InitializeComponent();
            context = cont;
        }
        Client buyer;
        internal EditClient(MyDbContext cont, Client client)
        {
            InitializeComponent();
            buyer = client;
            context = cont;
            FioBox.Text = client.name;
            SerialBox.Text = client.serialPass;
            NumberBox.Text = client.numberPas;
            NumberPhoneBox.Text = client.phone;

        }
        private void ButtonSaveEdit(object sender, RoutedEventArgs e)
        {
            context.Client.Find(buyer.Num).name = FioBox.Text; 
            context.Client.Find(buyer.Num).serialPass = SerialBox.Text;
            context.Client.Find(buyer.Num).numberPas = NumberBox.Text;
            context.Client.Find(buyer.Num).phone = NumberPhoneBox.Text;
            context.SaveChanges();
            NavigationService.Navigate(new ClientPage());
        }
    }
}
