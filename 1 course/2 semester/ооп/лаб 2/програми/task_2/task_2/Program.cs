using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            Console.WriteLine("Завдання 2.");

            bool t;
            double a, b, c, d, x1, x2;

            Console.WriteLine("Введіть a");
            do
            {
                t = true;
                if (double.TryParse(Console.ReadLine(), out a) && a != 0)
                {
                    t = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз a");
                }
            } while (t);


            Console.WriteLine("Введіть b");
            do
            {
                t = true;
                if (double.TryParse(Console.ReadLine(), out b) && b != 0)
                {
                    t = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз b");
                }
            } while (t);


            Console.WriteLine("Введіть c");
            do
            {
                t = true;
                if (double.TryParse(Console.ReadLine(), out c) && b != 0)
                {
                    t = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз c");
                }
            } while (t);

            d = Math.Pow(b, (double)2) - (double)4 * a * c;
            Console.WriteLine("d = " + Math.Round(d, 3));

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / ((double)2 * a);
                x2 = (-b - Math.Sqrt(d)) / ((double)2 * a);

                Console.WriteLine("x1 = "+ Math.Round(x1, 3));
                Console.WriteLine("x2 = " + Math.Round(x2, 3));
            }

            if (d == 0)
            {
                x1 = (-b) / ((double)2 * a);

                Console.WriteLine("x = " + Math.Round(x1, 3));
            }

            if (d < 0)
            {
                Console.WriteLine("Коренів немає");
            }


        }
    }
}
