namespace WinFormsApp2
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            double x, y, z, d1, d2;


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


            d1 = y / x;
            d2 = Math.Sqrt(z / x);
            if(d1 == d2)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }
    }
}