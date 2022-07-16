public static class RandomExtensions
{
    public static double NextDouble(this Random random, double minValue, double maxValue)
    {
        return random.NextDouble() * (maxValue - minValue) + minValue;
    }
}

class Program
{
    static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        Console.OutputEncoding = System.Text.Encoding.Default;

        Console.WriteLine("Лабораторна робота №4");
        Console.WriteLine("Виконав: Маньківський В.В., група ВТ-21-1");
        Console.WriteLine("Варіант №2");
        Console.WriteLine("Завдання 2");


        bool n;
        int r, s;

        Console.WriteLine("Введіть кількість рядків");
        do
        {
            n = true;
            if (int.TryParse(Console.ReadLine(), out r))
            {
                n = false;
            }
            else
            {
                Console.WriteLine("Введіть ще раз кількість рядків");
            }
        } while (n);


        Console.WriteLine("Введіть кількість стовпців");
        do
        {
            n = true;
            if (int.TryParse(Console.ReadLine(), out s))
            {
                n = false;
            }
            else
            {
                Console.WriteLine("Введіть ще раз кількість стовпців");
            }
        } while (n);
        Console.WriteLine("");
        double[,] mas = new double[r, s];


        double max = 60.3, min = -2.9;
        Random rnd = new Random();
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < s; j++)
            {
                mas[i, j] = rnd.NextDouble(min, max);
                mas[i, j] = Math.Round(mas[i, j], 1);
            }
        }

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < s; j++)
            {
                Console.Write($"{mas[i, j]}\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine("№1");

        int kr = 0, count = 0;

        for (int i = 0; i < r; i++)
        {
            count = 0;
            for (int j = 0; j < s; j++)
            {
                if(mas[i, j] < 0)
                    count++;
            }
            if (count == 0)
                kr++;
        }
        Console.WriteLine($"Кількість рядків, з невід'ємними елементами ---> {kr}");


        Console.WriteLine("№2");

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
                Console.Write($"{mas[i, j]}\t");
            }
            Console.WriteLine("");
        }
    }
}