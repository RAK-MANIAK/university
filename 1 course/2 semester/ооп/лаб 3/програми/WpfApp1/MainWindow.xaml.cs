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

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            listBox1.Items.Clear();
            double a, b, x, y, h;



            if (double.TryParse(textBox1.Text, out a))
            {
                a = double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення a!");
                textBox1.Text = null;
            }


            if (double.TryParse(textBox2.Text, out b) && a <= b)
            {
                b = double.Parse(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення b!");
                textBox2.Text = null;
            }


            if (double.TryParse(textBox3.Text, out h))
            {
                h = double.Parse(textBox3.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення h!");
                textBox3.Text = null;
            }

            listBox1.Items.Add("x            y");
            while (a <= b)
            {
                x = a;
                y = (2 * x + 8) / (Math.Abs(Math.Cos(3 * x)) + 1);

                listBox1.Items.Add($"{Math.Round(x, 3):F3}     {Math.Round(y, 3):F3}");

                a = a + h;
            }
        }
    }
}
