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
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z, s;


            if (double.TryParse(textBox1.Text, out x))
            {
                x = double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення x!");
                textBox1.Text = null;
            }


            if (double.TryParse(textBox2.Text, out y))
            {
                y = double.Parse(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення y!");
                textBox2.Text = null;
            }


            if (double.TryParse(textBox3.Text, out z))
            {
                z = double.Parse(textBox3.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення z!");
                textBox3.Text = null;
            }

            s = (Math.Pow((double)3 + (x - y), (double)1 / (double)3) / (Math.Pow(x, (double)2) + Math.Pow(z, (double)3) + (double)4)) - Math.Tan(z);
            s = Math.Round(s, 2);
            if (x != 0 && y != 0 && z != 0)
                textBox4.Text = s.ToString();
        }
    }
}
