using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.WriteLine("Лабораторна робота №2");
            Console.WriteLine("Виконав: Маньківський В.В., група ВТ-21-1");
            Console.WriteLine("Варіант №2");
            Console.WriteLine("Завдання 1.");

            bool n;
            double x, y, z, s;


            Console.WriteLine("Введіть x");
            do
            {
                n = true;
                if (double.TryParse(Console.ReadLine(), out x))
                { 
                    n = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз x");
                }
            } while (n);

            Console.WriteLine("Введіть y");
            do
            {
                n = true;
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    n = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз y");
                }
            } while (n);

            Console.WriteLine("Введіть z");
            do
            {
                n = true;
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    n = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз z");
                }
            } while (n);

            s = (Math.Pow((double)3 + (x - y), (double)1 / (double)3) / (Math.Pow(x, (double)2) + Math.Pow(z, (double)3) + (double)4)) - Math.Tan(z);
            Console.WriteLine("s = " + Math.Round(s, 3));
        }
    }
}
