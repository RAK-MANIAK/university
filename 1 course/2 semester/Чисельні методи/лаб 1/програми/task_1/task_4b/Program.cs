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
            Console.WriteLine("Завдання 3a.");

            double a = 13.5;
            double az = 0.02;

            double b = 3.7;
            double bz = 0.02;

            double c = 34.5;
            double cz = 0.02;

            double d = 23.725;
            double dz = 0.005;

            double m = 4.22;
            double mz = 0.004;

            double x;

            double ab = a + b;
            double abz = az + bz;

            double cd = c - d;
            double cdz = cz - dz;

            Console.WriteLine("a + b = {0} ± {1}", ab, abz);
            Console.WriteLine("c - d = {0} ± {1}", cd, cdz);
            x = (Math.Pow(m, (double)3) * ab) / cd;
            Console.WriteLine("x = {0}", x);

            Console.WriteLine("2)Відносна похибка результату:");

            double d1 = abz / (ab * 3) + mz / m + cdz / cd;
            Console.WriteLine("δ = {0} ({1}%)", d1, d1*100);
            double e = x * d1;
            Console.WriteLine("Абсолютна похибка результату:");
            Console.WriteLine("x = {0} ± {1} (δx = {2}%)", x, e, d1*100);
        }
    }
}
