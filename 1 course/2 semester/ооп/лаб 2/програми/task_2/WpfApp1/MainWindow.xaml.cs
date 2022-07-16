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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            label6.Visibility = Visibility.Hidden;
            label7.Visibility = Visibility.Hidden;
            textBox4.Visibility = Visibility.Hidden;
            textBox5.Visibility = Visibility.Hidden;
            textBox6.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, d, x1, x2;

            label4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            label6.Visibility = Visibility.Hidden;
            label7.Visibility = Visibility.Hidden;
            textBox4.Visibility = Visibility.Hidden;
            textBox5.Visibility = Visibility.Hidden;
            textBox6.Visibility = Visibility.Hidden;

            if (double.TryParse(textBox1.Text, out a))
            {
                a = double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення a!");
                textBox1.Text = null;
            }


            if (double.TryParse(textBox2.Text, out b))
            {
                b = double.Parse(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення b!");
                textBox2.Text = null;
            }


            if (double.TryParse(textBox3.Text, out c))
            {
                c = double.Parse(textBox3.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення c!");
                textBox3.Text = null;
            }

            if (a != 0 && b != 0 && c != 0)
            {
                d = Math.Pow(b, (double)2) - (double)4 * a * c;

                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / ((double)2 * a);
                    x2 = (-b - Math.Sqrt(d)) / ((double)2 * a);

                    x1 = Math.Round(x1, 2);
                    x2 = Math.Round(x2, 2);

                    textBox5.Text = x1.ToString();
                    textBox6.Text = x2.ToString();

                    textBox5.Visibility = Visibility.Visible;
                    textBox6.Visibility = Visibility.Visible;

                    label5.Visibility = Visibility.Visible;
                    label6.Visibility = Visibility.Visible;

                }

                if (d == 0)
                {
                    x1 = (-b) / ((double)2 * a);

                    x1 = Math.Round(x1, 2);

                    textBox4.Text = x1.ToString();
                    textBox4.Visibility = Visibility.Visible;
                    label4.Visibility = Visibility.Visible;
                }

                if (d < 0)
                {
                    label7.Visibility = Visibility.Visible;
                }
                d = Math.Round(d, 2);
                textBox7.Text = d.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
