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
    /// Логика взаимодействия для Billing.xaml
    /// </summary>
    public partial class Billing : Page
    {
        public Billing()
        {
            InitializeComponent();
            DGridTariff.ItemsSource = Session1Entities.GetContext().Тарифы.ToList();
            DGridPayment.ItemsSource = Session1Entities.GetContext().Payments.ToList();
            Search.Items.Add("Интернет");
            Search.Items.Add("Видеонаблюдение");
            Search.Items.Add("Телевидение");
            Search.Items.Add("Мобильная связь");
            Search.Items.Add("Интернет и телефидение");
            Search.Items.Add("Интернет, телефидение и видео наблюдение");
            DateNow.Items.Add("5.17.2022");
            DateNow.Items.Add("6.17.2022");
            DateNow.Items.Add("7.17.2022");
            DateNow.Items.Add("8.17.2022");
            DateNow.Items.Add("9.17.2022");
            DateNow.Items.Add("10.17.2022");
        }
    }
}
