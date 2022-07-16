using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = 0, x, sum = 0, feps1, feps2;
            bool fl = true;
            if (!double.TryParse(textBox1.Text, out double a)) { return; }
            if (!double.TryParse(textBox2.Text, out double b)) { return; }
            if (!int.TryParse(textBox3.Text, out int n)) { return; }
            richTextBox1.Text = null;
            h = (b - a) / n;
            x = a + h;

            for (int i = 1; i <= n - 1; i++)
            {
                sum = sum + Func(x);
                richTextBox1.Text += "  i = " + i + "   sum = " + Math.Round(sum, 2) + "    x = " + Math.Round(x, 2) + "\n";
                x += h;
            }
            x = a;
            feps1 = (FPAbs(x + h * n) / 12) * ((b - a) * h * h);

            textBox5.Text = (h * (((Func(x) + Func(x + h * n)) / 2) + sum)).ToString();
            textBox6.Text = (Math.Round(feps1, 10)).ToString();
            textBox4.Text = (Math.Round(Math.Abs(feps1) / Math.Abs(h * (((Func(x) + Func(x + h * n)) / 2) + sum)), 10)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double h = 0, x, sum = 0, feps1, feps2;
            bool fl = true;
            if (!double.TryParse(textBox1.Text, out double a)) { return; }
            if (!double.TryParse(textBox2.Text, out double b)) { return; }
            if (!int.TryParse(textBox3.Text, out int n)) { return; }
            richTextBox1.Text = null;
            h = (b - a) / n;
            x = a;

            for (int i = 0; i <= n - 1; i++)
            {
                sum = sum + Func(x);

                richTextBox1.Text += "  i = " + i + "   sum = " + Math.Round(sum * h, 2) + "    x = " + Math.Round(x, 2) + "\n";

                x += h;
            }
            textBox8.Text = (sum * h).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double h = 0, x, sum = 0, feps1, feps2;
            bool fl = true;
            if (!double.TryParse(textBox1.Text, out double a)) { return; }
            if (!double.TryParse(textBox2.Text, out double b)) { return; }
            if (!int.TryParse(textBox3.Text, out int n)) { return; }
            richTextBox1.Text = null;
            h = (b - a) / n;
            x = a + h;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + Func(x);

                richTextBox1.Text += "  i = " + i + "   sum = " + Math.Round(sum * h, 2) + "    x = " + Math.Round(x, 2) + "\n";
                x += h;
            }
            textBox10.Text = (sum * h).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double h = 0, x, sum = 0, feps1, feps2;
            bool fl = true;
            if (!double.TryParse(textBox1.Text, out double a)) { return; }
            if (!double.TryParse(textBox2.Text, out double b)) { return; }
            if (!int.TryParse(textBox3.Text, out int n)) { return; }
            richTextBox1.Text = null;
            h = (b - a) / n;
            x = a;

            for (int i = 0; i <= n - 1; i++)
            {
                sum = sum + Func(x + h / 2);

                richTextBox1.Text += "  i = " + i + "   sum = " + Math.Round(sum * h, 2) + "    x = " + Math.Round(x, 2) + "\n";

                x += h;
            }
            textBox12.Text = (sum * h).ToString();

            textBox9.Text = ((FP(b) / 24) * ((b - a) * h * h)).ToString();
            textBox7.Text = (Math.Abs((FP(b) / 24) * ((b - a) * h * h)) / Math.Abs(sum * h)).ToString();
        }


        public static double Func(double x)
        {
            return 0.5 * x + x * Math.Log(x);
        }
        public static double FP(double x)
        {
            return (1 / (Math.Log(10) * x));
        }
        public static double FPAbs(double x)
        {
            return Math.Abs(1 / (Math.Log(10) * x));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}