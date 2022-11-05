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
    /// Логика взаимодействия для DevicePage.xaml
    /// </summary>
    public partial class DevicePage : Page
    {
        MyDbContext context;
        public DevicePage()
        {
            InitializeComponent();
            context = new MyDbContext();
            DeviceTable.ItemsSource = context.Device.ToList(); 
        }
        public void RefreszData()
        {
            var list = context.Device.ToList();
            if (!string.IsNullOrWhiteSpace(BoxDevice.Text))
            {
                list = list.Where(x => x.model.ToLower().Contains(BoxDevice.Text.ToLower())).ToList();
            }
            DeviceTable.ItemsSource = list;
        }
        private void ChangeDevice(object sender, TextChangedEventArgs e)
        {
            RefreszData();
        }
    }
}
