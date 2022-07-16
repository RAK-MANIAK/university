namespace lab_10
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Fraction x1 = new Fraction(1, 2);
            Fraction x2 = new Fraction(2, 3);
            Console.WriteLine($"x1 = 1/2");
            Console.WriteLine($"x2 = 2/3");
            Fraction x = x1 + x2;
            Console.WriteLine("x1 + x2 = " + x);
            Fraction res1 = x1 - x2;
            Console.WriteLine("x1 - x2 = " + res1);
            Fraction res2 = x1 * x2;
            Console.Write("x1 * x2 = " + res2 + " ");
            Fraction ress = Fraction.Nod(res2);
            Console.WriteLine($"Скорочений = {ress}");
            Fraction res3 = x1 / x2;
            Console.WriteLine("x1 / x2 = " + res3);
            Fraction res4 = ++x1;
            Console.WriteLine("x1++ = " + res4);
            Fraction res5 = --x1;
            Console.WriteLine("x1-- = " + res5);
            if (x1 == x2)
            {
                Console.WriteLine("Дроби рівні");
            }
            if (x1 > x2)
            {
                Console.WriteLine("1 дріб більший");
            }
            if (x1 >= x2)
            {
                Console.WriteLine("1 дріб більший або дорівнює другому");
            }
            if (x1 < x2)
            {
                Console.WriteLine("1 дріб менший");
            }
            if (x1 <= x2)
            {
                Console.WriteLine("1 дріб менший або дорівнює другому");
            }
            if (x1 != x2)
            {
                Console.WriteLine("1 дріб не дорівнює другому");
            }
            double k1 = (double)x;
            Console.WriteLine($"(double res) = {k1:f2}");
        }
        
    }
}
