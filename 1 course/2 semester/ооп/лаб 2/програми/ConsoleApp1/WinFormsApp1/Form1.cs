namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
            double x, y, z, s;


                if (double.TryParse(textBox1.Text, out x))
                {
                x = double.Parse(textBox1.Text);
                }
                else
                {
                MessageBox.Show("Помилка введення значення x!");
                textBox1.Text = null;
            }


            if (double.TryParse(textBox2.Text, out y))
            {
                y = double.Parse(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення y!");
                textBox2.Text = null;
            }


            if (double.TryParse(textBox3.Text, out z))
            {
                z = double.Parse(textBox3.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення z!");
                textBox3.Text = null;
            }

            s = (Math.Pow((double)3 + (x - y), (double)1 / (double)3) / (Math.Pow(x, (double)2) + Math.Pow(z, (double)3) + (double)4)) - Math.Tan(z);
            s = Math.Round(s, 2);
            if(x != 0 && y != 0 && z != 0)
            textBox4.Text = s.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}