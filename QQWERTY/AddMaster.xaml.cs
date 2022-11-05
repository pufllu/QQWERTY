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
    /// Логика взаимодействия для AddMaster.xaml
    /// </summary>
    public partial class AddMaster : Page
    {
        MyDbContext context;
        internal AddMaster(MyDbContext cont)
        {
            InitializeComponent();
            context = cont;
            con = true;
        }
        bool con;
        private void ButtonSaveAdd(object sender, RoutedEventArgs e)
        {
            if(con == true)
            {
                Worker worker = new Worker()
                {
                    tabNum = Convert.ToInt32(tabNumBox.Text),
                    FIO = fioBox.Text,
                    oklad = Convert.ToDecimal(okladBox.Text),
                    percentToRepair = Convert.ToDecimal(percentBox.Text),
                    position = Convert.ToInt32(statusBox.Text),
                };
                context.Worker.Add(worker);
                context.SaveChanges();
                NavigationService.Navigate(new MasterPage());
            }
            else
            {
                context.Worker.Find(work.tabNum).FIO = fioBox.Text;
                context.Worker.Find(work.tabNum).oklad = Convert.ToDecimal(okladBox.Text);
                context.Worker.Find(work.tabNum).percentToRepair = Convert.ToDecimal(percentBox.Text);
                context.Worker.Find(work.tabNum).position = Convert.ToInt32(statusBox.Text);
                context.SaveChanges();
                NavigationService.Navigate(new MasterPage());
            }
        }
        Worker work;
        internal AddMaster(MyDbContext cont, Worker worker)
        {
            InitializeComponent();
            context = cont;
            work = worker;
            tabNumBox.Text = worker.tabNum.ToString();
            fioBox.Text = worker.FIO;
            okladBox.Text = worker.oklad.ToString();
            percentBox.Text = worker.percentToRepair.ToString();
            statusBox.Text = worker.position.ToString();
        }
    }
}
