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
    public partial class SuggestPassword : Page
    {
        MyDbContext context;
        public SuggestPassword()
        {
            InitializeComponent();
            context = new MyDbContext();
        }

        private void RequestPass(object sender, RoutedEventArgs e)
        {
            int TabNum = Convert.ToInt32(TabNumBox.Text);
            string FIO = FioBox.Text;
            int position = Convert.ToInt32(PositionBox.Text);
            if (context.Worker.Any(x => x.tabNum == TabNum))
            {
                Worker worker = context.Worker.ToList().Find(x => x.tabNum == TabNum);
                if (worker == null)
                {
                    MessageBox.Show("Работника с таким номером нету!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

                }

                else
                {
                    Worker employer1 = context.Worker.ToList().Find(x => x.FIO == FIO);
                    if (employer1 == null)
                    {
                        MessageBox.Show("Работника с таким ФИО нету!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        Worker employer2 = context.Worker.ToList().Find(x => x.position == position);
                        if (employer2 == null)
                        {
                            MessageBox.Show("Работника с такой должностью нету!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Ваш пароль {worker.password}");                           
                        }
                    }
                }
            }
        }
    }
}
