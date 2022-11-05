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
    /// Логика взаимодействия для AccessoriesPage.xaml
    /// </summary>
    public partial class AccessoriesPage : Page
    {
        MyDbContext context;
        internal AccessoriesPage(MyDbContext context, DevicePart devicePart)
        {
            InitializeComponent();
            this.context = context;
            MaterialTable.ItemsSource = context.DevicePart.ToList().Where(x => x.id == devicePart.id);
        }
    }
}
