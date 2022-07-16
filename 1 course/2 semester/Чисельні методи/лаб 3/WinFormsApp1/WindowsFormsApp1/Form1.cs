using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private double a, b, h, eps;
        private double x, y;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Visible = true;
            listBox1.Visible = false;

            if (double.TryParse(textBox1.Text, out a) && a <= 2.59)
            {
                a = double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення a!");
                textBox1.Text = null;
            }
            if (double.TryParse(textBox2.Text, out b) && b >= -2.59)
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

            if (checkBox1.Checked)
            {
                x = a;
                this.chart1.Series[0].Points.Clear();
                while(x <= b)
                {
                    y = Math.Sin(x) - 0.2 * x;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            else
            {
                this.chart1.Series[0].Points.Clear();
            }

            if (checkBox2.Checked)
            {
                x = a;
                this.chart1.Series[1].Points.Clear();
                while (x <= b)
                {
                    y = x;
                    this.chart1.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }

            else
            {
                this.chart1.Series[1].Points.Clear();
            }


            if (checkBox3.Checked)
            {
                x = a;
                this.chart1.Series[2].Points.Clear();
                while (x <= b)
                {
                    y = x - ((Math.Sin(x) - 0.2 * x) / 2);
                    this.chart1.Series[2].Points.AddXY(x, y);
                    x += h;
                }
            }

            else
            {
                this.chart1.Series[2].Points.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            chart1.Visible = false;
            listBox1.Visible = true;

            if (double.TryParse(textBox1.Text, out a) && a <= 2.59)
            {
                a = double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення a!");
                textBox1.Text = null;
            }
            if (double.TryParse(textBox2.Text, out b) && b >= -2.59)
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
            if (double.TryParse(textBox4.Text, out eps))
            {
                eps = double.Parse(textBox4.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення eps!");
                textBox4.Text = null;
            }


            if (radioButton1.Checked)
            {

                double[] x = new double[100];
                x[0] = a;
                int i = 0;
                double fx, fxx, eq = 0, s;
                bool q = true;
                do
                {
                    listBox1.Items.Add($"x[{i}] = {x[i]:f6}");
                    fx = Math.Sin(x[i]) - 0.2 * x[i];
                    fxx = Math.Cos(x[i]) - 0.2;
                    s = fx / fxx;
                    if (i > 0)
                    {
                        eq = Math.Abs(x[i] - x[i - 1]);
                    }
                    if (eq < eps && i > 0)
                    {
                        listBox1.Items.Add($"Відповідь:{x[i]:f4}+-{eps:f4}");
                        textBox5.Text = x[i].ToString("0.0000+-") + eps.ToString("0.0000");
                        q = false;
                    }
                    x[i + 1] = x[i] - s;
                    i++;
                } while (q);


            }



            if (radioButton2.Checked)
            {


                double[] xq = new double[100];
                double[] x1 = new double[100];
                x1[0] = a;
                double[] fx = new double[100];
                xq[0] = x1[0];
                int i = 0;
                double eq = 0, q;
                bool w = true;
                q = (Math.Cos(a) - 0.2);



                do
                {
                    listBox1.Items.Add($"x[{i}] = {xq[i]:f6}");
                    fx[i] = xq[i] - ((Math.Sin(xq[i]) - 0.2 * xq[i]) / (Math.Cos(xq[i]) - 0.2));
                    if (i > 0)
                    {
                        eq = Math.Abs(xq[i] - xq[i - 1]);
                    }
                    if (eq < eps && i > 0)
                    {
                        listBox1.Items.Add($"Відповідь:{xq[i]:f4}+-{eps:f4}");
                        textBox5.Text = xq[i].ToString("0.0000+-") + eps.ToString("0.0000");
                        w = false;
                    }
                    xq[i + 1] = fx[i];




                    //if (Math.Abs((25 * Math.Pow(Math.Cos(x), 2) - 25 + 5 * x * Math.Sin(x)) / Math.Pow(5 * Math.Cos(x) - 1, 2)) <= q)
                    //{
                    //    w = false;
                    //}
                    i++;
                } while (w);


            }



        }

        public Form1()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            chart1.Visible = false;
            listBox1.Visible = false;

            textBox1.Text = "2";
            textBox2.Text = "3";
            textBox3.Text = "0.5";
            textBox4.Text = "0.01";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
