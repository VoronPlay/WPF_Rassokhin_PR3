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

namespace WPF_Rassokhin_PR4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pusk_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(X.Text);

            Itog.Text += "При Х" + X.Text + Environment.NewLine;

            int n = 0;
            double u;

            if (Radio2.IsChecked == true) n = 1; 
            else if (Radio3.IsChecked == true) n = 2;

            switch(n)
            {
                case 0:
                     u = ((-x * x * x) + 9) ;
                    Itog.Text += "U =" + Convert.ToString(u) + Environment.NewLine;
                    break;
                case 1:
                    u = (-3 / x + 1);
                    Itog.Text += "U =" + Convert.ToString(u) + Environment.NewLine;
                    break;
                default:
                    Itog.Text += "Решение не найдено" + Environment.NewLine;
                    break;

            }
        }

        private void kc(object sender, EventArgs e)
        {
            Itog.Text = "";
            Itog.Text = "";
        }
    }
}
