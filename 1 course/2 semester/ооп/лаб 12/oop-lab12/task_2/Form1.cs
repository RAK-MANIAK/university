using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Regex regex = new Regex("\\+(([3][8][0])|([4][3])|([2][1][3]))[469][67853][0-9]{7}");
            Match match = regex.Match(s);
            if (match.Success)
            {
                label8.Visible = true;
                label8.Text = "OK";
            }
            else
            {
                label8.Visible = true;
                label8.Text = "помилка";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            Regex regex = new Regex("[0-9]{13}");
            Match match = regex.Match(s);
            if (match.Success)
            {
                label9.Visible = true;
                label9.Text = "OK";
            }
            else
            {
                label9.Visible = true;
                label9.Text = "помилка";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            int s1 = int.Parse(s);
            Regex regex = new Regex("[0-9]{5}");
            Match match = regex.Match(s);
            if (match.Success && s1 > 10311 && s1 < 89645)
            {
                label10.Visible = true;
                label10.Text = "OK";
            }
            else
            {
                label10.Visible = true;
                label10.Text = "помилка";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            Regex regex = new Regex("[А-Я][а-я]{1,}");
            Match match = regex.Match(s);
            if (match.Success)
            {
                label11.Visible = true;
                label11.Text = "OK";
            }
            else
            {
                label11.Visible = true;
                label11.Text = "помилка";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = textBox5.Text;
            Regex regex = new Regex("(([0-1][0-9])|([2][0-3]))\\:[0-5][0-9]");
            Match match = regex.Match(s);
            if (match.Success)
            {
                label12.Visible = true;
                label12.Text = "OK";
            }
            else
            {
                label12.Visible = true;
                label12.Text = "помилка";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = textBox6.Text;
            Regex regex = new Regex("[a-z]{4,}\\S{0,}[0-9]{0,}[a-z]{0,}\\S{0,}[a-z]{0,}\\@[g][m][a][i][l]\\.[c][o][m]");
            Match match = regex.Match(s);
            if (match.Success)
            {
                label13.Visible = true;
                label13.Text = "OK";
            }
            else
            {
                label13.Visible = true;
                label13.Text = "помилка";
            }
        }
    }
}
