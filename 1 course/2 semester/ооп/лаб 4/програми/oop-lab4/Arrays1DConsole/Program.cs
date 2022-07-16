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
        Console.WriteLine("Завдання 1 a");


        bool n0;
        int n;

        Console.WriteLine("Введіть кількість елементів");
        do
        {
            n0 = true;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                n0 = false;
            }
            else
            {
                Console.WriteLine("Введіть ще раз кількість елементів");
            }
        } while (n0);

        double[] mas = new double[n];

        double max = 7.003, min = -42.312;
        Random rnd = new Random();
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = rnd.NextDouble(min, max);
            mas[i] = Math.Round(mas[i], 3);
        }

        for(int i = 0; i < mas.Length; i++)
            Console.Write($"{mas[i]}    ");

        Console.WriteLine("");
        Console.WriteLine("№1");

        double sum = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if(i % 2 == 0 && mas[i] > 0)
                sum = sum + mas[i];
        }
        sum = Math.Round(sum, 3);
        Console.WriteLine($"Сума додатніх чисел, з парним індексом ---> {sum}");

        Console.WriteLine("№2");

        int k;
        Console.WriteLine("Введіть кількість останніх елементів для впорядкування");
        do
        {
            n0 = true;
            if (int.TryParse(Console.ReadLine(), out k) && k < mas.Length)
            {
                n0 = false;
            }
            else
            {
                Console.WriteLine("Введіть ще раз кількість елементів");
            }
        } while (n0);





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
            Console.Write($"{mas[i]}    ");





    }



}