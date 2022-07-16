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
            Console.WriteLine("Завдання 3.");

            bool t;
            int n, k;
            double s = 0;
            Console.WriteLine("Введіть n");
            do
            {
                t = true;
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    t = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз n");
                }
            } while (t);


            Console.WriteLine("Введіть k");
            do
            {
                t = true;
                if (int.TryParse(Console.ReadLine(), out k) && k > 0)
                {
                    t = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз k");
                }
            } while (t);



            for (int i = 1; i <= n; i++)
            {
                s = Math.Pow(i, k) + s;
            }
            Console.WriteLine("Сума дорівнює " + s);
        }
    }
}
