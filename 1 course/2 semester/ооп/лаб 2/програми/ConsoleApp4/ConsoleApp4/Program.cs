using System;

namespace ConsoleApp4
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
            Console.WriteLine("Завдання 4.");

            int n, par = 0, nepar = 0, dod = 0, vid = 0;
            Console.WriteLine("Введіть числа");
            do
            {
                if (int.TryParse(Console.ReadLine(), out n) && n != 0)
                {
                    if (n % 2 == 0)
                        par++;
                    else
                        nepar++;

                    if (n > 0)
                        dod++;
                    else
                        vid++;
                }
                else
                {
                    if(n != 0)
                    Console.WriteLine("Введіть ще раз число");
                }
            } while (n != 0);

            Console.WriteLine("Парних --- "+par);
            Console.WriteLine("Непарних --- " + nepar);
            Console.WriteLine("Додатних --- " + dod);
            Console.WriteLine("Від'ємних --- " + vid);

        }
    }
}
