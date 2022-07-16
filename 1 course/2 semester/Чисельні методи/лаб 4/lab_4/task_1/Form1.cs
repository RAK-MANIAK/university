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
        double[,] matrix = new double[3, 3];
        double det, b1 = -56.5, b2 = -100, b3 = -210;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Метод Гаусса\n";
            matrix[0, 0] = -3;
            matrix[0, 1] = 0.5;
            matrix[0, 2] = 0.5;
            matrix[1, 0] = 0.5;
            matrix[1, 1] = -6;
            matrix[1, 2] = 0.5;
            matrix[2, 0] = 0.5;
            matrix[2, 1] = 0.5;
            matrix[2, 2] = -3;

            b1 /= matrix[0, 0];
            matrix[0, 1] /= matrix[0, 0];
            matrix[0, 2] /= matrix[0, 0];
            matrix[0, 0] /= matrix[0, 0];
            richTextBox2.Text += "1 рядок ділимо на " + Math.Round(matrix[0, 0], 4).ToString();

            richTextBox2.Text += "\n" + matrix[0, 0].ToString("0.0000") + "\t\t" + matrix[0, 1].ToString("0.0000") + "\t\t" + matrix[0, 2].ToString("0.0000") + "|\t\t" + b1.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[1, 0].ToString("0.0000") + "\t\t" + matrix[1, 1].ToString("0.0000") + "\t\t" + matrix[1, 2].ToString("0.0000") + "|\t\t" + b2.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[2, 0].ToString("0.0000") + "\t\t" + matrix[2, 1].ToString("0.0000") + "\t\t" + matrix[2, 2].ToString("0.0000") + "|\t\t" + b3.ToString("0.0000");


            richTextBox2.Text += "\nВід 2 рядка віднімаємо 1 рядок, помножений на " + Math.Round(matrix[1, 0], 4).ToString() + "\nВід 3 рядка віднімаємо 1 рядок, помножений на " + Math.Round(matrix[2, 0], 4).ToString();
            matrix[1, 1] -= matrix[0, 1] * matrix[1, 0];
            matrix[1, 2] -= matrix[0, 2] * matrix[1, 0];
            b2 -= b1 * matrix[1, 0];
            matrix[1, 0] -= matrix[0, 0] * matrix[1, 0];
            matrix[2, 1] -= matrix[0, 1] * matrix[2, 0];
            matrix[2, 2] -= matrix[0, 2] * matrix[2, 0];
            b3 -= b1 * matrix[2, 0];
            matrix[2, 0] -= matrix[0, 0] * matrix[2, 0];


            richTextBox2.Text += "\n" + matrix[0, 0].ToString("0.0000") + "\t\t" + matrix[0, 1].ToString("0.0000") + "\t\t" + matrix[0, 2].ToString("0.0000") + "|\t\t" + b1.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[1, 0].ToString("0.0000") + "\t\t" + matrix[1, 1].ToString("0.0000") + "\t\t" + matrix[1, 2].ToString("0.0000") + "|\t\t" + b2.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[2, 0].ToString("0.0000") + "\t\t" + matrix[2, 1].ToString("0.0000") + "\t\t" + matrix[2, 2].ToString("0.0000") + "|\t\t" + b3.ToString("0.0000");
            
            richTextBox2.Text += "\n2 рядок ділимо на " + Math.Round(matrix[1, 1], 4).ToString();

            b2 /= matrix[1, 1];
            matrix[1, 0] /= matrix[1, 1];
            matrix[1, 2] /= matrix[1, 1];
            matrix[1, 1] /= matrix[1, 1];

            richTextBox2.Text += "\n" + matrix[0, 0].ToString("0.0000") + "\t\t" + matrix[0, 1].ToString("0.0000") + "\t\t" + matrix[0, 2].ToString("0.0000") + "|\t\t" + b1.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[1, 0].ToString("0.0000") + "\t\t" + matrix[1, 1].ToString("0.0000") + "\t\t" + matrix[1, 2].ToString("0.0000") + "|\t\t" + b2.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[2, 0].ToString("0.0000") + "\t\t" + matrix[2, 1].ToString("0.0000") + "\t\t" + matrix[2, 2].ToString("0.0000") + "|\t\t" + b3.ToString("0.0000");

            richTextBox2.Text += "\nВід 1 рядка віднімаємо 2 рядок, помножений на " + Math.Round(matrix[0, 1], 4).ToString() + "\nВід 3 рядка віднімаємо 2 рядок, помножений на " + Math.Round(matrix[2, 1], 4).ToString();
            matrix[0, 0] -= matrix[1, 0] * matrix[0, 1];
            matrix[0, 2] -= matrix[1, 2] * matrix[0, 1];
            b1 -= b2 * matrix[0, 1];
            matrix[0, 1] -= matrix[1, 1] * matrix[0, 1];
            matrix[2, 0] -= matrix[1, 0] * Math.Abs(matrix[2, 1]);
            matrix[2, 2] -= matrix[1, 2] * Math.Abs(matrix[2, 1]);
            b3 -= b2 * matrix[2, 1];
            matrix[2, 1] -= matrix[1, 1] * Math.Abs(matrix[2, 1]);

            richTextBox2.Text += "\n" + matrix[0, 0].ToString("0.0000") + "\t\t" + matrix[0, 1].ToString("0.0000") + "\t\t" + matrix[0, 2].ToString("0.0000") + "|\t\t" + b1.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[1, 0].ToString("0.0000") + "\t\t" + matrix[1, 1].ToString("0.0000") + "\t\t" + matrix[1, 2].ToString("0.0000") + "|\t\t" + b2.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[2, 0].ToString("0.0000") + "\t\t" + matrix[2, 1].ToString("0.0000") + "\t\t" + matrix[2, 2].ToString("0.0000") + "|\t\t" + b3.ToString("0.0000");


            richTextBox2.Text += "\n3 рядок ділимо на " + Math.Round(matrix[2, 2], 4).ToString();
            b3 /= matrix[2, 2];
            matrix[2, 0] /= matrix[2, 2];
            matrix[2, 1] /= matrix[2, 2];
            matrix[2, 2] /= matrix[2, 2];

            richTextBox2.Text += "\n" + matrix[0, 0].ToString("0.0000") + "\t\t" + matrix[0, 1].ToString("0.0000") + "\t\t" + matrix[0, 2].ToString("0.0000") + "|\t\t" + b1.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[1, 0].ToString("0.0000") + "\t\t" + matrix[1, 1].ToString("0.0000") + "\t\t" + matrix[1, 2].ToString("0.0000") + "|\t\t" + b2.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[2, 0].ToString("0.0000") + "\t\t" + matrix[2, 1].ToString("0.0000") + "\t\t" + matrix[2, 2].ToString("0.0000") + "|\t\t" + b3.ToString("0.0000");


            richTextBox2.Text += "\nВід 1 рядка віднімаємо 3 рядок, помножений на " + Math.Round(matrix[0, 2], 4).ToString() + "\nВід 2 рядка віднімаємо 3 рядок, помножений на " + Math.Round(matrix[1, 2], 4).ToString();
            matrix[0, 0] -= matrix[2, 0] * matrix[0, 2];
            matrix[0, 1] -= matrix[2, 1] * matrix[0, 2];
            b1 -= b3 * matrix[0, 2];
            matrix[0, 2] -= matrix[2, 2] * matrix[0, 2];
            matrix[1, 0] -= matrix[2, 0] * matrix[1, 2];
            matrix[1, 1] -= matrix[2, 1] * matrix[1, 2];
            b2 -= b3 * matrix[1, 2];
            matrix[1, 2] -= matrix[2, 2] * matrix[1, 2];



            richTextBox2.Text += "\n" + matrix[0, 0].ToString("0.0000") + "\t\t" + matrix[0, 1].ToString("0.0000") + "\t\t" + matrix[0, 2].ToString("0.0000") + "|\t\t" + b1.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[1, 0].ToString("0.0000") + "\t\t" + matrix[1, 1].ToString("0.0000") + "\t\t" + matrix[1, 2].ToString("0.0000") + "|\t\t" + b2.ToString("0.0000");
            richTextBox2.Text += "\n" + matrix[2, 0].ToString("0.0000") + "\t\t" + matrix[2, 1].ToString("0.0000") + "\t\t" + matrix[2, 2].ToString("0.0000") + "|\t\t" + b3.ToString("0.0000");


            richTextBox2.Text += "\nx1 = " + Math.Round(b1, 4).ToString();
            richTextBox2.Text += "\nx2 = " + Math.Round(b2, 4).ToString();
            richTextBox2.Text += "\nx3 = " + Math.Round(b3, 4).ToString();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Метод прогонки\n";
            double b1 = 2, c1 = 1, a2 = 2, b2 = 3, c2 = -1, a3 = 1, b3 = -1, c3 = 3, a4 = 1, b4 = -1, d1 = 4, d2 = 9, d3 = 12, d4 = -4;
            double A1, B1, A2, B2, A3, B3, B4, x1, x2, x3, x4;

            A1 = -(c1 / b1);
            B1 = d1 / b1;
            A2 = -(c2 / (a2 * A1 + b2));
            B2 = (d2 - a2 * B1) / (a2 * A1 + b2);
            A3 = -(c3 / (a3 * A2 + b3));
            B3 = (d3 - a3 * B2) / (a4 * A3 + b4);
            B4 = (d4 - a4 * B3) / (a4 * A3 + b4);

            richTextBox2.Text += "a1 = " + Math.Round(A1, 4).ToString();
            richTextBox2.Text += "\nb1 = " + Math.Round(B1, 4).ToString();
            richTextBox2.Text += "\na2 = " + Math.Round(A2, 4).ToString();
            richTextBox2.Text += "\nb2 = " + Math.Round(B2, 4).ToString();
            richTextBox2.Text += "\na3 = " + Math.Round(A3, 4).ToString();
            richTextBox2.Text += "\nb3 = " + Math.Round(B3, 4).ToString();
            richTextBox2.Text += "\nb4 = " + Math.Round(B4, 4).ToString();

            x4 = B4;
            x3 = A3 * x4 + B3;
            x2 = A2 * x3 + B2;
            x1 = A1 * x2 + B1;
            richTextBox2.Text += "\n\nx1 = " + Math.Round(x1, 4).ToString();
            richTextBox2.Text += "\nx2 = " + Math.Round(x2, 4).ToString();
            richTextBox2.Text += "\nx3 = " + Math.Round(x3, 4).ToString();
            richTextBox2.Text += "\nx4 = " + Math.Round(x4, 4).ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            matrix[0, 0] = -3;
            matrix[0, 1] = 0.5;
            matrix[0, 2] = 0.5;
            matrix[1, 0] = 0.5;
            matrix[1, 1] = -6;
            matrix[1, 2] = 0.5;
            matrix[2, 0] = 0.5;
            matrix[2, 1] = 0.5;
            matrix[2, 2] = -3;

            det = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[1, 0] * matrix[0, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1] * matrix[0, 0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Метод Крамера\n";
            double det1, det2, det3, x1, x2, x3;
            b1 = -56.5;
            b2 = -100;
            b3 = -210;
            matrix[0, 0] = -3;
            matrix[0, 1] = 0.5;
            matrix[0, 2] = 0.5;
            matrix[1, 0] = 0.5;
            matrix[1, 1] = -6;
            matrix[1, 2] = 0.5;
            matrix[2, 0] = 0.5;
            matrix[2, 1] = 0.5;
            matrix[2, 2] = -3;

            richTextBox2.Text += "Det = " + det.ToString();

            matrix[0, 0] = b1;
            matrix[1, 0] = b2;
            matrix[2, 0] = b3;

            det1 = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[1, 0] * matrix[0, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1] * matrix[0, 0];

            richTextBox2.Text += "\nDet 1 = " + det1.ToString();

            matrix[0, 0] = -3;
            matrix[1, 0] = 0.5;
            matrix[2, 0] = 0.5;
            matrix[0, 1] = b1;
            matrix[1, 1] = b2;
            matrix[2, 1] = b3;

            det2 = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[1, 0] * matrix[0, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1] * matrix[0, 0];

            richTextBox2.Text += "\nDet 2 = " + det2.ToString();

            matrix[0, 1] = 0.5;
            matrix[1, 1] = -6;
            matrix[2, 1] = 0.5;
            matrix[0, 2] = b1;
            matrix[1, 2] = b2;
            matrix[2, 2] = b3;

            det3 = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[1, 0] * matrix[0, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1] * matrix[0, 0];

            richTextBox2.Text += "\nDet 3 = " + det3.ToString();

            x1 = det1 / det;
            x2 = det2 / det;
            x3 = det3 / det;

            richTextBox2.Text += "\n\nx1 = " + Math.Round(x1, 4).ToString();
            richTextBox2.Text += "\nx2 = " + Math.Round(x2, 4).ToString();
            richTextBox2.Text += "\nx3 = " + Math.Round(x3, 4).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b1 = -56.5;
            b2 = -100;
            b3 = -210;
            richTextBox2.Text = "Матричний метод\n";
            double[,] tran = new double[3, 3];
            double[,] ober = new double[3, 3];
            double x1, x2, x3;

            richTextBox2.Text += "Det = " + det.ToString();

            matrix[0, 0] = -3;
            matrix[0, 1] = 0.5;
            matrix[0, 2] = 0.5;
            matrix[1, 0] = 0.5;
            matrix[1, 1] = -6;
            matrix[1, 2] = 0.5;
            matrix[2, 0] = 0.5;
            matrix[2, 1] = 0.5;
            matrix[2, 2] = -3;

            if (det != 0)
            {
                tran[0, 0] = matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1];
                tran[0, 1] = -(matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
                tran[0, 2] = matrix[1, 0] * matrix[2, 1] - matrix[2, 0] * matrix[1, 1];
                tran[1, 0] = -(matrix[0, 1] * matrix[2, 2] - matrix[2, 1] * matrix[0, 2]);
                tran[1, 1] = matrix[0, 0] * matrix[2, 2] - matrix[2, 0] * matrix[0, 2];
                tran[1, 2] = -(matrix[0, 0] * matrix[2, 1] - matrix[2, 0] * matrix[0, 1]);
                tran[2, 0] = matrix[0, 1] * matrix[1, 2] - matrix[1, 1] * matrix[0, 2];
                tran[2, 1] = -(matrix[0, 0] * matrix[1, 2] - matrix[1, 0] * matrix[0, 2]);
                tran[2, 2] = matrix[1, 1] * matrix[0, 0] - matrix[1, 0] * matrix[0, 1];
                richTextBox2.Text += "\nТранспонована союзна матриця:";
                richTextBox2.Text += "\n" + Math.Round(tran[0, 0], 4).ToString() + "\t\t" + Math.Round(tran[1, 0], 4).ToString() + "\t\t" + Math.Round(tran[2, 0], 4).ToString();
                richTextBox2.Text += "\n" + Math.Round(tran[0, 1], 4).ToString() + "\t\t" + Math.Round(tran[1, 1], 4).ToString() + "\t\t" + Math.Round(tran[2, 1], 4).ToString();
                richTextBox2.Text += "\n" + Math.Round(tran[0, 2], 4).ToString() + "\t\t" + Math.Round(tran[1, 2], 4).ToString() + "\t\t" + Math.Round(tran[2, 2], 4).ToString();
                ober[0, 0] = tran[0, 0] / det;
                ober[0, 1] = tran[1, 0] / det;
                ober[0, 2] = tran[2, 0] / det;
                ober[1, 0] = tran[0, 1] / det;
                ober[1, 1] = tran[1, 1] / det;
                ober[1, 2] = tran[2, 1] / det;
                ober[2, 0] = tran[0, 2] / det;
                ober[2, 1] = tran[1, 2] / det;
                ober[2, 2] = tran[2, 2] / det;
                richTextBox2.Text += "\nОбернена матриця:";
                richTextBox2.Text += "\n" + Math.Round(ober[0, 0], 4).ToString() + "\t\t" + Math.Round(ober[0, 1], 4).ToString() + "\t\t" + Math.Round(ober[0, 2], 4).ToString();
                richTextBox2.Text += "\n" + Math.Round(ober[1, 0], 4).ToString() + "\t\t" + Math.Round(ober[1, 1], 4).ToString() + "\t\t" + Math.Round(ober[1, 2], 4).ToString();
                richTextBox2.Text += "\n" + Math.Round(ober[2, 0], 4).ToString() + "\t\t" + Math.Round(ober[2, 1], 4).ToString() + "\t\t" + Math.Round(ober[2, 2], 4).ToString();

                x1 = ober[0, 0] * b1 + ober[0, 1] * b2 + ober[0, 2] * b3;
                x2 = ober[1, 0] * b1 + ober[1, 1] * b2 + ober[1, 2] * b3;
                x3 = ober[2, 0] * b1 + ober[2, 1] * b2 + ober[2, 2] * b3;

                richTextBox2.Text += "\n\nx1 = " + Math.Round(x1, 4).ToString();
                richTextBox2.Text += "\nx2 = " + Math.Round(x2, 4).ToString();
                richTextBox2.Text += "\nx3 = " + Math.Round(x3, 4).ToString();

            }


        }
    }
}
