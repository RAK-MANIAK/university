using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
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

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

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
            textBox21.Text = null;
            textBox22.Text = null;
            textBox23.Text = null;
            textBox24.Text = null;
            textBox25.Text = null;
            richTextBox1.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            double[,] x = new double[100, 4];
            bool check = true;
            double X11, X12, X13, X14, X21, X22, X23, X24, X31, X32, X33, X34, X41, X42, X43, X44, 
                B1, B2, B3, B4, res1, res2, res3, res4, Eps, temp1, temp2,
                temp3, temp4, tempm1, tempm2, tempm3;


            while (!double.TryParse(textBox1.Text, out X11))
            {
                MessageBox.Show("Помилка введення!");
                return;
            }

            while (!double.TryParse(textBox2.Text, out X12))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox3.Text, out X13))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox4.Text, out X14))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox10.Text, out X21))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox9.Text, out X22))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox8.Text, out X23))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox7.Text, out X24))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox15.Text, out X31))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox14.Text, out X32))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox13.Text, out X33))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox12.Text, out X34))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox20.Text, out X41))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox19.Text, out X42))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox18.Text, out X43))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox17.Text, out X44))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox5.Text, out B1))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox6.Text, out B2))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox11.Text, out B3))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox16.Text, out B4))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox26.Text, out Eps))
            {
                MessageBox.Show("Помилка введення!");
            }

            x[0, 0] = B1;
            x[0, 1] = B2;
            x[0, 2] = B3;
            x[0, 3] = B4;

            X12 /= -X11;
            X13 /= -X11;
            X14 /= -X11;
            B1 /= X11;
            X11 = 0;
            X21 /= -X22;
            X23 /= -X22;
            X24 /= -X22;
            B2 /= X22;
            X22 = 0;
            X31 /= -X33;
            X32 /= -X33;
            X34 /= -X33;
            B3 /= X33;
            X33 = 0;
            X41 /= -X44;
            X42 /= -X44;
            X43 /= -X44;
            B4 /= X44;
            X44 = 0;

            temp1 = Math.Abs(X11 + X12 + X13 + X14);
            temp2 = Math.Abs(X21 + X22 + X23 + X24);
            temp3 = Math.Abs(X31 + X32 + X33 + X34);
            temp4 = Math.Abs(X41 + X42 + X43 + X44);
            if (temp1 < 1 && temp2 < 1 && temp3 < 1 && temp4 < 1)
            {
                tempm1 = Math.Max(temp1, temp2);
                tempm2 = Math.Max(temp3, temp4);
                tempm3 = Math.Max(tempm1, tempm2);
                if (tempm3 < 1)
                {
                    int i = 1, j = 0;
                    do
                    {
                        x[i, j] = B1 + (X11 * x[i - 1, j] + X12 * x[i - 1, j + 1] + X13 * x[i - 1, j + 2] + X14 * x[i - 1, j + 3]);
                        x[i, j + 1] = B2 + (X21 * x[i - 1, j] + X22 * x[i - 1, j + 1] + X23 * x[i - 1, j + 2] + X24 * x[i - 1, j + 3]);
                        x[i, j + 2] = B3 + (X31 * x[i - 1, j] + X32 * x[i - 1, j + 1] + X33 * x[i - 1, j + 2] + X34 * x[i - 1, j + 3]);
                        x[i, j + 3] = B4 + (X41 * x[i - 1, j] + X42 * x[i - 1, j + 1] + X43 * x[i - 1, j + 2] + X44 * x[i - 1, j + 3]);
                        temp1 = Math.Abs(x[i, j] - x[i - 1, j]);
                        temp2 = Math.Abs(x[i, j + 1] - x[i - 1, j + 1]);
                        temp3 = Math.Abs(x[i, j + 2] - x[i - 1, j + 2]);
                        temp4 = Math.Abs(x[i, j + 3] - x[i - 1, j + 3]);
                        tempm1 = Math.Max(temp1, temp2);
                        tempm2 = Math.Max(temp3, temp4);
                        tempm3 = Math.Max(tempm1, tempm2);
                        res1 = x[i, j];
                        res2 = x[i, j + 1];
                        res3 = x[i, j + 2];
                        res4 = x[i, j + 3];
                        richTextBox1.Text += "X1 = " + res1 + "\t" + "X2 = " + res2 + "\t" + "X3 = " + res3 + "\t" + "X4 = " + res4 + "\tEps = " + tempm3 + "\n";
                        if (tempm3 < Eps)
                        {
                            check = false;
                            textBox25.Text = i.ToString();
                            textBox24.Text = res1.ToString();
                            textBox23.Text = res2.ToString();
                            textBox22.Text = res3.ToString();
                            textBox21.Text = res4.ToString();
                        }
                        i++;
                    } while (check);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            double[,] x = new double[100, 4];
            bool check = true;
            double X11, X12, X13, X14, X21, X22, X23, X24, X31, X32, X33, X34, X41, X42, X43, X44,
                B1, B2, B3, B4, res1, res2, res3, res4, Eps, temp1, temp2,
                temp3, temp4, tempm1, tempm2, tempm3;


            while (!double.TryParse(textBox1.Text, out X11))
            {
                MessageBox.Show("Помилка введення!");
                return;
            }

            while (!double.TryParse(textBox2.Text, out X12))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox3.Text, out X13))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox4.Text, out X14))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox10.Text, out X21))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox9.Text, out X22))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox8.Text, out X23))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox7.Text, out X24))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox15.Text, out X31))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox14.Text, out X32))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox13.Text, out X33))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox12.Text, out X34))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox20.Text, out X41))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox19.Text, out X42))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox18.Text, out X43))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox17.Text, out X44))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox5.Text, out B1))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox6.Text, out B2))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox11.Text, out B3))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox16.Text, out B4))
            {
                MessageBox.Show("Помилка введення!");
            }

            while (!double.TryParse(textBox26.Text, out Eps))
            {
                MessageBox.Show("Помилка введення!");
            }

            x[0, 0] = B1;
            x[0, 1] = B2;
            x[0, 2] = B3;
            x[0, 3] = B4;

            X12 /= -X11;
            X13 /= -X11;
            X14 /= -X11;
            B1 /= X11;
            X11 = 0;
            X21 /= -X22;
            X23 /= -X22;
            X24 /= -X22;
            B2 /= X22;
            X22 = 0;
            X31 /= -X33;
            X32 /= -X33;
            X34 /= -X33;
            B3 /= X33;
            X33 = 0;
            X41 /= -X44;
            X42 /= -X44;
            X43 /= -X44;
            B4 /= X44;
            X44 = 0;

            temp1 = Math.Abs(X11 + X12 + X13 + X14);
            temp2 = Math.Abs(X21 + X22 + X23 + X24);
            temp3 = Math.Abs(X31 + X32 + X33 + X34);
            temp4 = Math.Abs(X41 + X42 + X43 + X44);
            if (temp1 < 1 && temp2 < 1 && temp3 < 1 && temp4 < 1)
            {
                tempm1 = Math.Max(temp1, temp2);
                tempm2 = Math.Max(temp3, temp4);
                tempm3 = Math.Max(tempm1, tempm2);
                if (tempm3 < 1)
                {
                    int i = 1, j = 0;
                    do
                    {
                        x[i, j] = B1 + (X11 * x[i - 1, j] + X12 * x[i - 1, j + 1] + X13 * x[i - 1, j + 2] + X14 * x[i - 1, j + 3]);
                        x[i, j + 1] = B2 + (X21 * x[i, j] + X22 * x[i - 1, j + 1] + X23 * x[i - 1, j + 2] + X24 * x[i - 1, j + 3]);
                        x[i, j + 2] = B3 + (X31 * x[i, j] + X32 * x[i - 1, j + 1] + X33 * x[i - 1, j + 2] + X34 * x[i - 1, j + 3]);
                        x[i, j + 3] = B4 + (X41 * x[i, j] + X42 * x[i - 1, j + 1] + X43 * x[i - 1, j + 2] + X44 * x[i - 1, j + 3]);
                        temp1 = Math.Abs(x[i, j] - x[i - 1, j]);
                        temp2 = Math.Abs(x[i, j + 1] - x[i - 1, j + 1]);
                        temp3 = Math.Abs(x[i, j + 2] - x[i - 1, j + 2]);
                        temp4 = Math.Abs(x[i, j + 3] - x[i - 1, j + 3]);
                        tempm1 = Math.Max(temp1, temp2);
                        tempm2 = Math.Max(temp3, temp4);
                        tempm3 = Math.Max(tempm1, tempm2);
                        res1 = x[i, j];
                        res2 = x[i, j + 1];
                        res3 = x[i, j + 2];
                        res4 = x[i, j + 3];

                        richTextBox1.Text += "X1 = " + res1 + "\t" + "X2 = " + res2 + "\t" + "X3 = " + res3 + "\t" + "X4 = " + res4 + "\tEps = " + tempm3 + "\n";
                        if (tempm3 < Eps)
                        {
                            check = false;
                            textBox25.Text = i.ToString();
                            textBox24.Text = res1.ToString();
                            textBox23.Text = res2.ToString();
                            textBox22.Text = res3.ToString();
                            textBox21.Text = res4.ToString();
                        }
                        i++;
                    } while (check);
                }
            }
        }
    }
}