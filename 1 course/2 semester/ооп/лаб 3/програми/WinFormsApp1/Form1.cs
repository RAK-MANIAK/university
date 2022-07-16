namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            double a, b, x, y, h;



            if (double.TryParse(textBox1.Text, out a))
            {
                a = double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Помилка введення значення a!");
                textBox1.Text = null;
            }


            if (double.TryParse(textBox2.Text, out b) && a <= b)
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

            listBox1.Items.Add("x            y");
            while (a <= b)
            {
                x = a;
                y = (2*x+8) / (Math.Abs(Math.Cos(3*x))+1);

                listBox1.Items.Add($"{Math.Round(x, 3):F3}     {Math.Round(y, 3):F3}");

                a = a + h;
            }

        }
    }
}