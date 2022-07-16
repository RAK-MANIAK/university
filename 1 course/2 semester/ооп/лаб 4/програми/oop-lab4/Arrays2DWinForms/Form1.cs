namespace Arrays2DWinForms
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
        double[,] mas;
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.Rows.Clear();
            int r, s;
            r = (int)count1.Value;
            s = (int)count2.Value;
            dataGridViewMatrix.RowCount = r;
            dataGridViewMatrix.ColumnCount = s;

            for (int j = 0; j < r; j++)
                dataGridViewMatrix.Rows[j].HeaderCell.Value = j.ToString();
            for (int i = 0; i < s; i++)
            {
                dataGridViewMatrix.Columns[i].HeaderText = i.ToString();
                dataGridViewMatrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            mas = new double[r, s];

            double max = 60.3, min = -2.9;
            Random rnd = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    mas[i, j] = rnd.NextDouble() * (max - min) + min;
                    mas[i, j] = Math.Round(mas[i, j], 1);

                    dataGridViewMatrix[j, i].Value = mas[i, j];
                }
            }


            int kr = 0, count = 0;

            for (int i = 0; i < r; i++)
            {
                count = 0;
                for (int j = 0; j < s; j++)
                {
                    if (mas[i, j] < 0)
                        count++;
                }
                if (count == 0)
                    kr++;
            }

            sum.Text = kr.ToString();
        }

        private void dataGridViewMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.AllowUserToDeleteRows = false;
            dataGridViewMatrix.AllowUserToOrderColumns = false;
            dataGridViewMatrix.ReadOnly = true;
        }

        private void dataGridViewMatrix_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(e.RowIndex.ToString(),
                    e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.Rows.Clear();
            int r, s;
            r = (int)count1.Value;
            s = (int)count2.Value;
            dataGridViewMatrix.RowCount = r;
            dataGridViewMatrix.ColumnCount = s;

            for (int j = 0; j < r; j++)
                dataGridViewMatrix.Rows[j].HeaderCell.Value = j.ToString();
            for (int i = 0; i < s; i++)
            {
                dataGridViewMatrix.Columns[i].HeaderText = i.ToString();
                dataGridViewMatrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }



            double suml = 0, sum = 0, temp;
            int t = 0;

            for (int i = 0; i < r - 1; i++)
            {
                t = 0;
                sum = 0;
                suml = 0;
                for (int j = 0; j < s; j++)
                    suml = suml + mas[i, j];
                for (int k = i + 1; k < r; k++)
                {
                    for (int j = 0; j < s; j++)
                        sum = sum + mas[k, j];

                    if (suml < sum)
                    {
                        for (int j = 0; j < s; j++)
                        {
                            temp = mas[i, j];
                            mas[i, j] = mas[k, j];
                            mas[k, j] = temp;
                            t++;


                        }
                    }
                    sum = 0;
                    if (t > 0)
                    {
                        i = -1;
                        break;
                    }
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    dataGridViewMatrix[j, i].Value = mas[i, j];
                }
            }


        }
    }
}