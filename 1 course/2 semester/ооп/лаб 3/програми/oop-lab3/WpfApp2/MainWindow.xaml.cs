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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


            pictureBox2.Visibility = Visibility.Hidden;
            pictureBox1.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pictureBox2.Visibility = Visibility.Hidden;
            pictureBox1.Visibility = Visibility.Hidden;
            double x, y, z, d1, d2;


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


            d1 = y / x;
            d2 = Math.Sqrt(z / x);
            if (d1 == d2)
            {
                pictureBox2.Visibility = Visibility.Visible;
            }
            else
            {
                pictureBox1.Visibility = Visibility.Visible;
            }

        }
    }
}
