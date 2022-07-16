namespace Arrays1DWinForms
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

            double[] mas;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void defolt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            defolt.AllowUserToAddRows = false;
            defolt.AllowUserToDeleteRows = false;
            defolt.AllowUserToOrderColumns = false;
            defolt.ReadOnly = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {


            defolt.Rows.Clear();
            newm.Rows.Clear();
            int n;
            n = (int)count1.Value;
            defolt.RowCount = 1;
            defolt.ColumnCount = n;
            

            mas = new double[n];

            double max = 7.003, min = -42.312;
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.NextDouble() * (max - min) + min;
                mas[i] = Math.Round(mas[i], 3);

                defolt[i, 0].Value = mas[i];
                defolt.Columns[i].HeaderText = i.ToString();


            }

        }

        private void count1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            newm.Rows.Clear();
            double sum1 = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 == 0 && mas[i] > 0)
                    sum1 = sum1 + mas[i];
            }
            sum1 = Math.Round(sum1, 3);
            sum.Text = sum1.ToString();

            int n;
            n = (int)count1.Value;
            newm.RowCount = 1;
            newm.ColumnCount = n;

            int k;
            k = (int)count2.Value;
            if (k < n)
            {

                double temp;
                for (int i = mas.Length - k; i < mas.Length - 1; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] < mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < mas.Length; i++)
                {
                    newm[i, 0].Value = mas[i];
                    newm.Columns[i].HeaderText = i.ToString();


                }

            }
        }

        private void newm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            defolt.AllowUserToAddRows = false;
            defolt.AllowUserToDeleteRows = false;
            defolt.AllowUserToOrderColumns = false;
            defolt.ReadOnly = true;
        }
    }
}