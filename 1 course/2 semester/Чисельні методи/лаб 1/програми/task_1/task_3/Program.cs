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

            Console.WriteLine("Лабораторна робота №1");
            Console.WriteLine("Виконав: Маньківський В.В., група ВТ-21-1");
            Console.WriteLine("Варіант №2");
            Console.WriteLine("Завдання 1.");

            bool n;
            double x;

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

            Console.WriteLine("У вузькому сенсі");
            double y = x;
            int count = 0;

            while (y != (int)y)
            {
                y *= 10;
                count++;
            }
            double z = 0.5;
            for(int i = 0; i < count; i++)
            {
                z = z / 10;
            }
            Console.WriteLine("∆={0}/{1} = {2} ({3}%)", z, x, z/x, (z/x)*100.0);
        }
    }
}
