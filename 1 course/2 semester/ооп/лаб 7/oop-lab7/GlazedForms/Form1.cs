using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazedForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a) && a > 0)
            {
                a = double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення!");
                textBox1.Text = null;
            }

            if (double.TryParse(textBox2.Text, out b) && b > 0)
            {
                b = double.Parse(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення!");
                textBox2.Text = null;
            }
            double f = a * b;
            ////

            if (radioButton1.Checked && comboBox1.SelectedIndex == 0)
                f *= 0.25;

            if (radioButton2.Checked && comboBox1.SelectedIndex == 0)
                f *= 0.30;

            if (radioButton1.Checked && comboBox1.SelectedIndex == 1)
                f *= 0.05;

            if (radioButton2.Checked && comboBox1.SelectedIndex == 1)
                f *= 0.10;

            if (radioButton1.Checked && comboBox1.SelectedIndex == 2)
                f *= 0.15;

            if (radioButton2.Checked && comboBox1.SelectedIndex == 2)
                f *= 0.20;

            if (checkBox1.Checked)
                f += 35;
            f = Math.Round(f, 2);
            label7.Text = f.ToString() + " грн";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
