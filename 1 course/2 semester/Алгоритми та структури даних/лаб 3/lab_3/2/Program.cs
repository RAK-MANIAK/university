using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Число a, де 0<=a<=20");
        bool n0;
        int a;
        do
        {
            n0 = true;
            if (int.TryParse(Console.ReadLine(), out a) && a >=0 && a<=20)
            {
                n0 = false;
            }
            else
            {
                Console.WriteLine("Введіть ще раз");
            }
        } while (n0);
        stopwatch.Start();
        Console.WriteLine($"{a}! = {fact(a)}");

        stopwatch.Stop();
        Console.WriteLine($"\nБуло витрачено {stopwatch.ElapsedMilliseconds * 1000000} наносекунд;");

    }

    static double fact(int a)
    {
        if (a <= 1) return 1;

        return a * fact(a - 1);
    }
}