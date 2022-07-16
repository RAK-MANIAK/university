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

            double a = 228.6;
            double az = 0.06;

            double b = 86.4;
            double bz = 0.02;

            double c = 68.7;
            double cz = 0.05;

            double x;
            Console.WriteLine("1)Знаходимо наближені значення Х:");
            x = (Math.Sqrt(a) * b) / (c);
            Console.WriteLine("x = {0}", x);

            Console.WriteLine("2)Знаходимо граничні відносні похибки:");
            double da = az / a;
            double db = bz / b;
            double dc = cz / c;

            Console.WriteLine("δa = {0}", da);
            Console.WriteLine("δb = {0}", db);
            Console.WriteLine("δc = {0}", dc);

            Console.WriteLine("3)Відносна похибка результату:");
            double d = (da + db + dc) / 2;
            Console.WriteLine("δ = {0} ({1}%)", d, d*100);
            Console.WriteLine("Абсолютна похибка результату:");
            Console.WriteLine("X = {0} ± {1} (δx = {2}%)", x, x * d, d*100);


        }
    }
}
