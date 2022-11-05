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

    public partial class MainWindow : Window
    {
        MyDbContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new MyDbContext();
            ButtonHelp.IsEnabled = false;
        }
        int a = 0;
        private void ButtonAuthorization(object sender, RoutedEventArgs e)
        {
            int tabNum = Convert.ToInt32(login.Text);
            string pass = password.Text;
          
            using (MyDbContext context = new MyDbContext())
            {
                Worker workers = context.Worker.Find(Convert.ToInt32(login.Text));
            }
            Worker worker = context.Worker.ToList().Find(x => x.tabNum == tabNum);
            if (worker == null)
            {
                MessageBox.Show("Работника с таким логином не существует", "Ошибка!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                a ++;
                if (a >= 3)
                {
                    ButtonLogin.IsEnabled = false;
                    login.IsEnabled = false;
                    password.IsEnabled = false;
                    ButtonHelp.IsEnabled = true;
                }
            }
            else
            {
                if (worker.password.Equals(pass))
                {
                    MessageBox.Show("Авторизация прошла успешно", "Выполняется вход", MessageBoxButton.OK, MessageBoxImage.Information);
                    FrameMainScreen.Content = new MainScreen(worker);
                }
                else
                {
                    MessageBox.Show("Работника с таким паролем не существует", "Ошибка!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                    a ++;
                    if (a >= 3)
                    {
                        ButtonLogin.IsEnabled = false;
                        login.IsEnabled = false;
                        password.IsEnabled = false;
                        ButtonHelp.IsEnabled = true;
                    }
                }
            }

        }

        private void HelpPassword(object sender, RoutedEventArgs e)
        {
            FrameHelpPass.Content = new SuggestPassword();
        }
    }
}

