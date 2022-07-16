using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        int[,] n = new int[3, 3];
        int[,] c = new int[3, 1];
        private void button3_Click(object sender, EventArgs e)
        {
            int[,] slar = new int[5, 3];
            int res_1, res_2, res_3, res_4, res_5;

            if (!int.TryParse(textBox1.Text, out slar[0, 0])) { return; }
            if (!int.TryParse(textBox2.Text, out slar[0, 1])) { return; }
            if (!int.TryParse(textBox3.Text, out slar[0, 2])) { return; }
            if (!int.TryParse(textBox4.Text, out res_1)) { return; }

            if (!int.TryParse(textBox10.Text, out slar[1, 0])) { return; }
            if (!int.TryParse(textBox9.Text, out slar[1, 1])) { return; }
            if (!int.TryParse(textBox8.Text, out slar[1, 2])) { return; }
            if (!int.TryParse(textBox7.Text, out res_2)) { return; }

            if (!int.TryParse(textBox15.Text, out slar[2, 0])) { return; }
            if (!int.TryParse(textBox14.Text, out slar[2, 1])) { return; }
            if (!int.TryParse(textBox13.Text, out slar[2, 2])) { return; }
            if (!int.TryParse(textBox12.Text, out res_3)) { return; }

            if (!int.TryParse(textBox20.Text, out slar[3, 0])) { return; }
            if (!int.TryParse(textBox19.Text, out slar[3, 1])) { return; }
            if (!int.TryParse(textBox18.Text, out slar[3, 2])) { return; }
            if (!int.TryParse(textBox17.Text, out res_4)) { return; }

            if (!int.TryParse(textBox16.Text, out slar[4, 0])) { return; }
            if (!int.TryParse(textBox11.Text, out slar[4, 1])) { return; }
            if (!int.TryParse(textBox6.Text, out slar[4, 2])) { return; }
            if (!int.TryParse(textBox5.Text, out res_5)) { return; }

            n[0, 0] = slar[0, 0] * slar[0, 0] + slar[1, 0] * slar[1, 0] + slar[2, 0] * slar[2, 0] + slar[3, 0] * slar[3, 0] + slar[4, 0] * slar[4, 0];
            n[0, 1] = slar[0, 0] * slar[0, 1] + slar[1, 0] * slar[1, 1] + slar[2, 0] * slar[2, 1] + slar[3, 0] * slar[3, 1] + slar[4, 0] * slar[4, 1];
            n[0, 2] = slar[0, 0] * slar[0, 2] + slar[1, 0] * slar[1, 2] + slar[2, 0] * slar[2, 2] + slar[3, 0] * slar[3, 2] + slar[4, 0] * slar[4, 2];
            n[1, 0] = slar[0, 1] * slar[0, 0] + slar[1, 1] * slar[1, 0] + slar[2, 1] * slar[2, 0] + slar[3, 1] * slar[3, 0] + slar[4, 1] * slar[4, 0];
            n[1, 1] = slar[0, 1] * slar[0, 1] + slar[1, 1] * slar[1, 1] + slar[2, 1] * slar[2, 1] + slar[3, 1] * slar[3, 1] + slar[4, 1] * slar[4, 1];
            n[1, 2] = slar[0, 1] * slar[0, 2] + slar[1, 1] * slar[1, 2] + slar[2, 1] * slar[2, 2] + slar[3, 1] * slar[3, 2] + slar[4, 1] * slar[4, 2];
            n[2, 0] = slar[0, 2] * slar[0, 0] + slar[1, 2] * slar[1, 0] + slar[2, 2] * slar[2, 0] + slar[3, 2] * slar[3, 0] + slar[4, 2] * slar[4, 0];
            n[2, 1] = slar[0, 2] * slar[0, 1] + slar[1, 2] * slar[1, 1] + slar[2, 2] * slar[2, 1] + slar[3, 2] * slar[3, 1] + slar[4, 2] * slar[4, 1];
            n[2, 2] = slar[0, 2] * slar[0, 2] + slar[1, 2] * slar[1, 2] + slar[2, 2] * slar[2, 2] + slar[3, 2] * slar[3, 2] + slar[4, 2] * slar[4, 2];
            c[0, 0] = slar[0, 0] * res_1 + slar[1, 0] * res_2 + slar[2, 0] * res_3 + slar[3, 0] * res_4 + slar[4, 0] * res_5;
            c[1, 0] = slar[0, 1] * res_1 + slar[1, 1] * res_2 + slar[2, 1] * res_3 + slar[3, 1] * res_4 + slar[4, 1] * res_5;
            c[2, 0] = slar[0, 2] * res_1 + slar[1, 2] * res_2 + slar[2, 2] * res_3 + slar[3, 2] * res_4 + slar[4, 2] * res_5;
            richTextBox1.Text = "Нормальна система рівнянь в матричній формі";
            richTextBox1.Text += "\n" + n[0, 0] + "\t" + n[0, 1] + "\t" + n[0, 2] + "\t" + c[0, 0];
            richTextBox1.Text += "\n" + n[1, 0] + "\t" + n[1, 1] + "\t" + n[1, 2] + "\t" + c[1, 0];
            richTextBox1.Text += "\n" + n[2, 0] + "\t" + n[2, 1] + "\t" + n[2, 2] + "\t" + c[2, 0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
            textBox14.Text = null;
            textBox15.Text = null;
            textBox16.Text = null;
            textBox17.Text = null;
            textBox18.Text = null;
            textBox19.Text = null;
            textBox20.Text = null;
            textBox22.Text = null;
            textBox23.Text = null;
            textBox24.Text = null;
            richTextBox1.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
            double[,] u = new double[3, 3];
            double y1, y2, y3, x1, x2, x3;
            int det;
            det = n[0, 0] * n[1, 1] * n[2, 2] + n[0, 1] * n[1, 2] * n[2, 0] + n[0, 2] * n[1, 0] * n[2, 1] - n[0, 2] * n[1, 2] * n[2, 0] - n[0, 0] * n[1, 2] * n[2, 1] - n[0, 1] * n[1, 0] * n[2, 2];

            richTextBox1.Text = "Визначник = " + det;
            if (det <= 0)
            {
                richTextBox1.Text += "Визначник менше 0!";
                return;
            }
            u[0, 0] = Math.Sqrt(n[0, 0]);
            u[1, 0] = n[1, 0] / u[0, 0];
            u[2, 0] = n[2, 0] / u[0, 0];
            u[1, 1] = Math.Sqrt((n[1, 1] - Math.Pow(u[1, 0], 2)));
            u[2, 1] = (n[2, 1] - u[2, 0] * u[1, 0]) / u[1, 1];
            u[2, 2] = Math.Sqrt((n[2, 2] - Math.Pow(u[2, 0], 2) - Math.Pow(u[2, 1], 2)));
            y1 = c[0, 0] / u[0, 0];
            y2 = (c[1, 0] - u[1, 0] * y1) / u[1, 1];
            y3 = (c[2, 0] - (u[2, 0] * y1 + u[2, 1] * y2)) / u[2, 2];
            x3 = y3 / u[2, 2];
            x2 = (y2 - (u[2, 1] * x3)) / u[1, 1];
            x1 = (y1 - (u[2, 0] * x3 + u[1, 0] * x2)) / u[0, 0];
            richTextBox1.Text += "\nМатриця U";

            richTextBox1.Text += "\n" + u[0, 0].ToString("0.000") + "\t" + u[0, 1].ToString("0.000") + "\t" + u[0, 2].ToString("0.000") + "\t" + c[0, 0].ToString("0.000");
            richTextBox1.Text += "\n" + u[1, 0].ToString("0.000") + "\t" + u[1, 1].ToString("0.000") + "\t" + u[1, 2].ToString("0.000") + "\t" + c[1, 0].ToString("0.000");
            richTextBox1.Text += "\n" + u[2, 0].ToString("0.000") + "\t" + u[2, 1].ToString("0.000") + "\t" + u[2, 2].ToString("0.000") + "\t" + c[2, 0].ToString("0.000");

            richTextBox1.Text += "\n\nМатриця UT";

            richTextBox1.Text += "\n" + u[0, 0].ToString("0.000") + "\t" + u[1, 0].ToString("0.000") + "\t" + u[2, 0].ToString("0.000") + "\t" + y1.ToString("0.000");
            richTextBox1.Text += "\n" + u[0, 1].ToString("0.000") + "\t" + u[1, 1].ToString("0.000") + "\t" + u[2, 1].ToString("0.000") + "\t" + y2.ToString("0.000");
            richTextBox1.Text += "\n" + u[0, 2].ToString("0.000") + "\t" + u[1, 2].ToString("0.000") + "\t" + u[2, 2].ToString("0.000") + "\t" + y3.ToString("0.000");

            richTextBox1.Text += "\n\nx1 = " + x1.ToString("0.000") + "\tx2 = " + x2.ToString("0.000") + "\tx3 = " + x3.ToString("0.000");

            textBox24.Text = x1.ToString("0.000");
            textBox23.Text = x2.ToString("0.000");
            textBox22.Text = x3.ToString("0.000");
        }
    }
}