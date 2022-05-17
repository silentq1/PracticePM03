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

namespace Session1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User sh;
        string qwe;
        int qw;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cnclBtn_Click(object sender, RoutedEventArgs e)
        {
            numba.Text = "";
            passwprd.Text = "";
            kod.Text = "";

        }

        private void numba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && numba.Text != String.Empty)
            {
                using (Session1Entities zxc = new Session1Entities())
                {
                    sh = zxc.User.FirstOrDefault(b => b.Phone_Number == numba.Text);
                }
                if (sh != null)
                {
                    passwprd.IsEnabled = true;
                }
                MessageBox.Show(sh.Password);
            }
        }

        private void passwprd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && passwprd.Text != String.Empty)
            {
                if (sh.Password == passwprd.Text)
                {
                    Random rand = new Random();
                    string code = null;
                    for (int i = 0; i < 3; i++)
                        code += Convert.ToString(rand.Next(0, 9));
                    qwe = code;
                    qw = DateTime.Now.Second;
                    MessageBox.Show("Код для входа: " + code);
                    refresh.IsEnabled = true;
                    kod.IsEnabled = true;
                    entBtn.IsEnabled = true;
                    cnclBtn.IsEnabled = true;
                }
               
            }

        }

        private void entBtn_Click(object sender, RoutedEventArgs e)
        {
            if (qwe == kod.Text && (Math.Abs(DateTime.Now.Second - qw)) < 10)
            {
                MessageBox.Show(sh.FIO);
            }
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            if (passwprd.Text != String.Empty && numba.Text != String.Empty)
            {
                Random rand = new Random();
                string code = null;
                for (int i = 0; i < 3; i++)
                    code += Convert.ToString(rand.Next(0, 9));
                qwe = code;
                qw = DateTime.Now.Second;
                MessageBox.Show("Код для входа: " + code);
            }
        }
    }
}
