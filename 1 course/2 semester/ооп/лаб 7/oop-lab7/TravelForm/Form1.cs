using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox1.Text, out a) && a > 0)
            {
                a = int.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення!");
                textBox1.Text = null;
            }

            ////

            if (radioButton1.Checked && comboBox1.SelectedIndex == 0)
                a *= 100;

            if (radioButton2.Checked && comboBox1.SelectedIndex == 0)
                a *= 150;

            if (radioButton1.Checked && comboBox1.SelectedIndex == 1)
                a *= 160;

            if (radioButton2.Checked && comboBox1.SelectedIndex == 1)
                a *= 200;

            if (radioButton1.Checked && comboBox1.SelectedIndex == 2)
                a *= 120;

            if (radioButton2.Checked && comboBox1.SelectedIndex == 2)
                a *= 180;

            if (checkBox1.Checked)
                a += 50;
            label7.Text = a.ToString() + " $";
        }
    }
}
