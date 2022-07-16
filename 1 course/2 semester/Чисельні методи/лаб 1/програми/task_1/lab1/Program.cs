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
            double x, y, xc, xz, xo, yo, ys;


            Console.WriteLine("Введіть x чисельник");
            do
            {
                n = true;
                if (double.TryParse(Console.ReadLine(), out xc))
                {
                    n = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз x чисельник");
                }
            } while (n);

            Console.WriteLine("Введіть x знаменник");
            do
            {
                n = true;
                if (double.TryParse(Console.ReadLine(), out xz))
                {
                    n = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз x знаменник");
                }
            } while (n);

            Console.WriteLine("Введіть y");
            do
            {
                n = true;
                if (double.TryParse(Console.ReadLine(), out ys))
                {
                    n = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз y");
                }
            } while (n);

            x = xc / xz;
            y = Math.Sqrt(ys);
            xo = Math.Round(x, 3);
            yo = Math.Round(y, 2);

            Console.WriteLine("Граничні абсолютні похибки:");
            Console.WriteLine("Δ1 = |" + x+"-"+xo+"| <= " +Math.Abs(x-xo));
            Console.WriteLine("Δ2 = |" + y + "-" + yo + "| <= " + Math.Abs(y - yo));
            Console.WriteLine("Граничні відносні похибки:");
            Console.WriteLine("δ1 = " + Math.Abs(x - xo)+" / "+xo+" = "+(Math.Abs(x - xo)/xo)+" ("+ (Math.Abs(x - xo) / xo)*100+"%)");
            Console.WriteLine("δ2 = " + Math.Abs(y - yo) + " / " + yo + " = " + (Math.Abs(y - yo) / yo) + " (" + (Math.Abs(y - yo) / yo) * 100 + "%)");
            if ((Math.Abs(x - xo) / xo) > (Math.Abs(y - yo) / yo))
                Console.WriteLine("δ1 > δ2, тоді √" + ys + " є більш точною.");

            if ((Math.Abs(x - xo) / xo) < (Math.Abs(y - yo) / yo))
                Console.WriteLine("δ1 < δ2, тоді " + xc + "/" +xz + " є більш точною.");

            if ((Math.Abs(x - xo) / xo) == (Math.Abs(y - yo) / yo))
                Console.WriteLine("δ1 = δ2, тоді " + xc + "/" + xz + " та √"+ys+" однакові у точності.");
        }
    }
}
