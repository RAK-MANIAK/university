using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            int n, k = 1;
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

           for(int i = n; i > 1; i--)
            {
                s = Math.Pow(k, i) + s;
                k++;
            }
            s = s + n;
            Console.WriteLine("Сума дорівнює " +s);
        }
    }
}
