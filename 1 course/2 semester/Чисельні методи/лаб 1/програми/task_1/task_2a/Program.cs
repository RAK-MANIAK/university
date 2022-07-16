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
            int xc, xcc;
            double x, y;

            Console.WriteLine("x ± y");
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
            int t = 0;
            do
            {
                xc = (int)x;

                xcc = (int)Math.Log10(xc) + 1;

                double z = 0.5;

                double xf = x;
                for (int i = 0; i < xcc; i++)
                {
                    xf = xf / 10;
                }
                int xff = 0;
                int count = 0;
                double xx = x;
                while (xx != (int)xx) 
                {
                    xx *= 10;
                    count++;
                }

                t = 0;
                for (int i = 0; i < count + xcc; i++)
                {
                    xf = xf - xff;
                    xf = Math.Round(xf, count + xcc);
                    xf = xf * 10.0;
                    xff = (int)xf;

                    if (y < z)
                        Console.WriteLine("∆=" + y + "<" + z + ", то цифра " + xff + " вірна у вузькому сенсі");
                    if (y >= z)
                    {
                        Console.WriteLine("∆=" + y + ">" + z + ", то цифра " + xff + " сумнівна у вузькому сенсі");
                        t++;
                    }
                    z = z / 10;

                }
                for(int i = 0; i < count + 1; i++)
                    xf = xf / 10.0;
                xf = Math.Round(xf, count + 1);
                for (int i = 0; i < t; i++)
                {
                    xx = xx / (double)10;
                }
                xx = (int)xx;
                count = (int)Math.Log10(xx) + 1;
                if (xcc < count)
                {
                    count = count - xcc;
                    for (int i = 0; i < count; i++)
                        xx = xx / (double)10;
                }
                y = y + xf;
                x = xx;
                if (t>0)
                Console.WriteLine("a1 = " + xx + "±" + y);
                if(t == 0)
                {
                    y = y - xf;
                    y = Math.Round(y, 4);
                    Console.WriteLine("a1 = " + xx + "±" + y);
                }
            } while (t > 0);

        }
    }
}
