class Program
{
    public static double F(double x)
    {
        return Math.Sin(x) - 0.2 * x;
    }

    static void Main(string[] args)
    {
        System.Globalization.CultureInfo customCulture =
(System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        Console.OutputEncoding = System.Text.Encoding.Default;

        double x_prev = 0, x_curr = 0, e = 1e-9, x_next = 0, tmp;


        Console.Write("x = ");

        for (int i = 0; i < 3; i++)
        {
            if(i == 0)
            {
                x_prev = -10;
                x_curr = -2;
                x_next = -1;
            }
            if(i == 1)
            {
                x_prev = -10;
                x_curr = 10;
                x_next = -1;
            }
            if (i == 2)
            {
                x_prev = 2;
                x_curr = 10;
                x_next = 1;
            }
            do
            {
                tmp = x_next;
                x_next = x_curr - F(x_curr) * (x_prev - x_curr) / (F(x_prev) - F(x_curr));
                x_prev = x_curr;
                x_curr = tmp;
            } while (Math.Abs(x_next - x_curr) > e);
            Console.Write(Math.Round(x_next, 9) + "\t");
        }
        Console.WriteLine();
    }
}