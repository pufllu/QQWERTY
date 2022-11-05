using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Page
    {
        public MainScreen(Worker worker)
        {
            InitializeComponent();
            if(worker.position == 1)
            {
                MasterButton.Visibility = Visibility.Collapsed;
                ClientButton.Visibility = Visibility.Collapsed;
                OrderButton.Visibility = Visibility.Collapsed;
            }
        }

        private void GoMaster(object sender, RoutedEventArgs e)
        {
            FrameMaster.Navigate(new MasterPage());
        }

        private void GoClient(object sender, RoutedEventArgs e)
        {
            FrameMaster.Navigate(new ClientPage());
        }

        private void GoOrder(object sender, RoutedEventArgs e)
        {
            FrameMaster.Navigate(new DevicePage());
        }

        private void GoAccessories(object sender, RoutedEventArgs e)
        {
            FrameMaster.Navigate(new CatalogSpareParts());
        }
    }
}
