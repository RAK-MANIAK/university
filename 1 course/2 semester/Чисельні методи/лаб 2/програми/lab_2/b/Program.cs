internal class Program
{
    public static double F(double x)
    {
        return Math.Sin(x) - 0.2 * x;
    }

    private static void Main()
    {
        System.Globalization.CultureInfo customCulture =
(System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        Console.OutputEncoding = System.Text.Encoding.Default;

        double accuracy = 1e-9, min = 0, max = 0, k, er, x;
        //accuracy - точність
        //min - мінімум інтервала
        //max - максимум інтервала
        //k - довжина інтервала
        //er - початкова помилка
        //x - корінь
        Console.Write("x = ");
        for (int i = 0; i < 3; i++) {
           

            if(i == 0)
            {
                min = -5;
                max = 0;
            }

            if (i == 1)
            {
                min = -5;
                max = 5;
            }

            if (i == 2)
            {
                min = 0;
                max = 5;
            }

            k = max - min;
            er = k;
            x = -5;

            while (er > accuracy && F(x) != 0)
            {
                x = (min + max) / 2;
                if (F(min) * F(x) < 0)
                {
                    max = x;
                }
                else if (F(x) * F(max) < 0)
                {
                    min = x;
                }
                er = (max - min) / k;
            }

            Console.Write(Math.Round(x, 9) + "\t");
        }
        Console.WriteLine();
    }
}