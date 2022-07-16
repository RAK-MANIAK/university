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
            Console.WriteLine("Завдання 4c.");

            double a = 8.53;


            double b = 6.271;


            double h = 12.48;

            double x = (((a + b) * Math.Pow(h, 3.0)) / 4.0) + (((a + b) * h) / 12.0);

            Console.WriteLine("x = {0}", x);

        }
    }
}
