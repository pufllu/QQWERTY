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
    /// Логика взаимодействия для CatalogSpareParts.xaml
    /// </summary>
    public partial class CatalogSpareParts : Page
    {
        MyDbContext context;
        public CatalogSpareParts()
        {
            InitializeComponent();
            context = new MyDbContext();
            CatalogList.ItemsSource = context.DevicePart.ToList();
        }

        private void ClickCatalog(object sender, MouseButtonEventArgs e)
        {
            DevicePart devicePart = (sender as Grid).DataContext as DevicePart;
            NavigationService.Navigate(new AccessoriesPage(context, devicePart));
        }
    }
}
