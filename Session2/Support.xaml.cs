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
    /// Логика взаимодействия для Support.xaml
    /// </summary>
    public partial class Support : Page
    {
        List<User> users = new List<User>();
        List<Тарифы> items = new List<Тарифы>();
        public Support()
        {
            InitializeComponent();
            users = Session1Entities.GetContext().User.ToList();
            items = Session1Entities.GetContext().Тарифы.ToList();
            DGridAp.ItemsSource = users;
            foreach (var item in items)
            {
                UsersComboBox.Items.Add(item.Навзание_тарифа);
            }
        }
        private void UsersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Работа с заявкой пользователя " + Convert.ToString(items[UsersComboBox.SelectedIndex].Навзание_тарифа) + " проведена");
        }

        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Выбранны работник отправлен на выезд");
        }
    }
}
