namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x1, x2;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            if (double.TryParse(textBox1.Text, out a))
            {
                a = double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення a!");
                textBox1.Text = null;
            }


            if (double.TryParse(textBox2.Text, out b))
            {
                b = double.Parse(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення b!");
                textBox2.Text = null;
            }


            if (double.TryParse(textBox3.Text, out c))
            {
                c = double.Parse(textBox3.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення c!");
                textBox3.Text = null;
            }

            if (a != 0 && b != 0 && c != 0)
            {
                d = Math.Pow(b, (double)2) - (double)4 * a * c;

                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / ((double)2 * a);
                    x2 = (-b - Math.Sqrt(d)) / ((double)2 * a);

                    x1 = Math.Round(x1, 2);
                    x2 = Math.Round(x2, 2);

                    textBox5.Text = x1.ToString();
                    textBox6.Text = x2.ToString();

                    textBox5.Visible = true;
                    textBox6.Visible = true;

                    label5.Visible = true;
                    label6.Visible = true;

                }

                if (d == 0)
                {
                    x1 = (-b) / ((double)2 * a);

                    x1 = Math.Round(x1, 2);

                    textBox4.Text = x1.ToString();
                    textBox4.Visible = true;
                    label4.Visible = true;
                }

                if (d < 0)
                {
                    label7.Visible = true;
                }
                d = Math.Round(d, 2);
                textBox7.Text = d.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
    }
}