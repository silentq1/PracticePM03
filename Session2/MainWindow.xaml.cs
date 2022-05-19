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

namespace Session2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> userList = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            using(Session1Entities pi = new Session1Entities())
            {
                userList = pi.User.ToList();
            }
            foreach(var q in userList)
            {
                UsersComboBox.Items.Add(q.FIO);
            }
        }
        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void SubsTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderTextBlock.Text = "Абоненты ТНС";
        }

        private void EquipTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderTextBlock.Text = "Управление оборудованием ТНС";
            MainFrame.Navigate(new Pages.Control());
        }

        private void AssetsTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderTextBlock.Text = "Активы ТНС";
        }

        private void BillingTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderTextBlock.Text = "Биллинг ТНС";
        }

        private void SupprtTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderTextBlock.Text = "Поддержка пользователей ТНС";
        }

        private void crmTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HeaderTextBlock.Text = "CRM ТНС";
        }

        private void UsersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
