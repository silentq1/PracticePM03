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
    /// Логика взаимодействия для Abonent.xaml
    /// </summary>
    public partial class Abonent : Page
    {
        public Abonent()
        {
            InitializeComponent();
            DGridSubs.ItemsSource = Session1Entities.GetContext().User.ToList();
        }
    }
}
