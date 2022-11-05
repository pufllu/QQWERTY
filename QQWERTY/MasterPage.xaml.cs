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
    /// Логика взаимодействия для MasterPage.xaml
    /// </summary>
    public partial class MasterPage : Page
    {
        MyDbContext context;
        public MasterPage()
        {
            InitializeComponent();
            context = new MyDbContext();
            Mastera.ItemsSource = context.Worker.ToList();
            var list = context.Position.ToList();
            list.Insert(0, new Position() { title = "Все", id = 0 });
            StatusBox.ItemsSource = list;
        }
        public void RefreszData()
        {
            var list = context.Worker.ToList();
            if (StatusBox.SelectedIndex > 0)
            {
                Position pos = StatusBox.SelectedItem as Position;
                list = list.Where(x => x.Position1 == pos).ToList();
            }

            if (!string.IsNullOrWhiteSpace(FioBox.Text))
            {
                list = list.Where(x => x.FIO.ToLower().Contains(FioBox.Text.ToLower())).ToList();
            }
            Mastera.ItemsSource = list;
        }

        private void EditMaster(object sender, RoutedEventArgs e)
        {
            Worker worker = Mastera.SelectedItem as Worker;
            NavigationService.Navigate(new AddMaster(context, worker));
        }

        private void DeleteMaster(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить сотрудника?", "Подтверждение", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                try
                {
                    Worker worker = Mastera.SelectedItem as Worker;
                    context.Worker.Remove(worker);
                    context.SaveChanges();
                    NavigationService.Navigate(new MasterPage());
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления");
                }
            }
        }

        private void ChangedFio(object sender, TextChangedEventArgs e)
        {
            RefreszData();
        }
    }
}
