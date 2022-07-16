using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Число m, де m<=20");
        bool n0;
        int m;
        double max = 0, zero = 1, maxn = 0;
        do
        {
            n0 = true;
            if (int.TryParse(Console.ReadLine(), out m) && m >= 0 && m <= 20)
            {
                n0 = false;
            }
            else
            {
                Console.WriteLine("Введіть ще раз");
            }
        } while (n0);
        stopwatch.Start();
        int []mass = new int[m];
        Random rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            mass[i] = rnd.Next(0, 8);
            Console.Write($"{mass[i]}\t");
            zero *= 10;
        }
        int s = 0;
        for (int i = 0; i < m; i++)
        {
            zero /= 10;
            maxn = 0;
            for (int j = 0; j < m; j++)
            {
                if (mass[j] > maxn && mass[j] != -1)
                {
                    maxn = mass[j];
                    s = j;
                }
            }
            max += maxn * zero;
            mass[s] = -1;
        }
        Console.WriteLine($"\nНайбільш можливе -> {max}");
        stopwatch.Stop();
        Console.WriteLine($"\nБуло витрачено {stopwatch.ElapsedMilliseconds * 1000000} наносекунд;");

    }
}