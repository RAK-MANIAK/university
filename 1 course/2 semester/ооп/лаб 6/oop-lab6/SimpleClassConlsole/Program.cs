
namespace oop_6
{
    class Program
    {
        static void Main()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            Console.Title = "Лабораторна робота №5";
            Console.SetWindowSize(100, 25);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Лабораторна робота №5");
            Console.WriteLine("Виконав: Маньківський В.В., група ВТ-21-1");
            Console.WriteLine("Варіант №2");
            Console.WriteLine("Завдання 1");



            Console.WriteLine("Кількість записів");

            bool n0;
            int fl;

            do
            {
                n0 = true;

                if (int.TryParse(Console.ReadLine(), out fl))
                {
                    n0 = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз");
                }
            } while (n0);
            fl += 2;
            Product[] pro = new Product[fl];

            ReadProductsArray(fl, pro);

            PrintProducts(fl, pro);
            for (; ; )
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Виберіть дію:\n1)Вивести всі дані\n2)Вивести однин товар\n3)Найбільша/найменша ціна\n4)Сортування ціна\n5)Сортування кількість\n6)Ціна в грн\n7)Загальна вартість\n8)Загальна вага\n9)Додати термін придатності\n10)Вивести термін придатності");
                int t, maxi = 0, mini = 0;
                double max, min;
                do
                {
                    n0 = true;

                    if (int.TryParse(Console.ReadLine(), out t) && t > 0 && t < 11)
                    {
                        n0 = false;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);

                switch (t)
                {
                    case 1:
                        PrintProducts(fl, pro);
                        break;

                    case 2:
                        PrintProduct(fl, pro);
                        break;

                    case 3:
                        GetProductsInfo(fl, pro, out max, out min, ref maxi, ref mini);
                        Console.WriteLine($"Товар {pro[maxi].Name} -> {max} грн");
                        Console.WriteLine($"Товар {pro[mini].Name} -> {min} грн");
                        break;

                    case 4:
                        SortProductsByPrice(fl, pro);
                        PrintProducts(fl, pro);
                        break;

                    case 5:
                        SortProductsByCount(fl, pro);
                        PrintProducts(fl, pro);
                        break;

                    case 6:
                        for (int i = 0; i < fl; i++)
                        {
                            Console.WriteLine($"{pro[i].Name} -> {pro[i].GetPriceInUAH()} грн\n");
                        }
                        break;
                    case 7:
                        for (int i = 0; i < fl; i++)
                        {
                            Console.WriteLine($"{pro[i].Name} -> {pro[i].GetTotalPriceInUAH()} грн\n");
                        }
                        break;

                    case 8:
                        for (int i = 0; i < fl; i++)
                        {
                            Console.WriteLine($"{pro[i].Name} -> {pro[i].GetTotalWeight()} г\n");
                        }
                        break;

                    case 9:
                        for (; ; )
                        {
                            Console.WriteLine("Введіть '0' для повернення у меню");
                            Console.WriteLine("Введіть номер запису, для зміни терміни придатності:");
                            int p;
                            do
                            {
                                n0 = true;

                                if (int.TryParse(Console.ReadLine(), out p) && p >= 0 && p <= fl)
                                {
                                    n0 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Введіть ще раз");
                                }
                            } while (n0);
                            if (p == 0)
                                break;

                            pro[p-1].SetSuitability();
                        }
                        break;

                    case 10:
                        PrintSuitability(fl, pro);
                        break;


                    default:
                        Console.WriteLine($"Неправильний ввід");
                        break;

                }
            }
        }



        static void PrintSuitability(int fl, Product[] pro)
        {
            for (int i = 0; i < fl; i++)
            {
                if(pro[i].Suitability_1 > 0)
                Console.Write($"\nДанні №{i + 1}\nНазва товару -> {pro[i].Name}\nТермін придатності(доба) -> {pro[i].Suitability_1}\nТермін придатності(місяць) -> {Math.Round(pro[i].Suitability_1 / 30.0, 2)}\nТермін придатності(рік) -> {Math.Round(pro[i].Suitability_1 / 365.0, 2)}\n");
                Console.WriteLine();
            }
        }



        public static int SortInfoBy2(Product a, Product b)
        {

            if (a.Quantity > b.Quantity)
                return 1;
            if (a.Quantity < b.Quantity)
                return -1;
            return 0;
        }

        static void SortProductsByCount(int fl, Product[] pro)
        {
            Array.Sort(pro, SortInfoBy2);
        }


        public static int SortInfoBy1(Product a, Product b)
        {

            if ((a.Price * a.cost.Exrate) > (b.Price * b.cost.Exrate))
                return 1;
            if ((a.Price * a.cost.Exrate) < (b.Price * b.cost.Exrate))
                return -1;
            return 0;
        }

        static void SortProductsByPrice(int fl, Product[] pro)
        {
            Array.Sort(pro, SortInfoBy1);
        }



        static void GetProductsInfo(int fl, Product[] pro, out double max, out double min, ref int maxi, ref int mini)
        {
            max = 0;
            min = 99999;

            for (int i = 0; i < fl; i++)
            {
                if ((pro[i].Price * pro[i].cost.Exrate) > max)
                {
                    max = Math.Round((pro[i].Price * pro[i].cost.Exrate), 2);
                    maxi = i;
                }
                if ((pro[i].Price * pro[i].cost.Exrate) < min)
                {
                    min = Math.Round((pro[i].Price * pro[i].cost.Exrate), 2);
                    mini = i;
                }
            }

        }


        static void PrintProducts(int fl, Product[] pro)
        {
            for (int i = 0; i < fl; i++)
            {
                Console.Write($"\nДанні №{i + 1}\nНазва товару -> {pro[i].Name}\nВартість одиниці товару -> {pro[i].Price}\nНазва валюти -> {pro[i].cost.Name}\nКурс -> {pro[i].cost.Exrate}\nКількість наявних товарів на складі -> {pro[i].Quantity}\nНазва компанії-виробника -> {pro[i].Producer}\nВага одиниці товару -> {pro[i].Weight}\n");
                Console.WriteLine();
            }
        }



        static void PrintProduct(int fl, Product[] pro)
        {
            bool n0;
            int i;
            Console.WriteLine("Введіть номер запису");
            do
            {
                n0 = true;

                if (int.TryParse(Console.ReadLine(), out i) && i <= fl && i > 0)
                {
                    n0 = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз");
                }
            } while (n0);
            i -= 1;
            Console.Write($"\nДанні №{i + 1}\nНазва товару -> {pro[i].Name}\nВартість одиниці товару -> {pro[i].Price}\nНазва валюти -> {pro[i].cost.Name}\nКурс -> {pro[i].cost.Exrate}\nКількість наявних товарів на складі -> {pro[i].Quantity}\nНазва компанії-виробника -> {pro[i].Producer}\nВага одиниці товару -> {pro[i].Weight}\n");
        }



        static void ReadProductsArray(int fl, Product[] pro)
        {
            pro[0] = new Product();
            bool n0;
            for (int i = 1; i < fl - 1; i++)
            {
                Console.WriteLine($"--- Данні №{i + 1} ---");
                string n;
                Console.WriteLine("Назва товару");
                do
                {
                    n0 = true;
                    n = Console.ReadLine();
                    if (n.Length > 0)
                    {
                        n0 = false;
                        //pro[i].Name = n;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);

                ////

                Console.WriteLine("Вартість одиниці товару");
                float d;

                do
                {
                    n0 = true;

                    if (float.TryParse(Console.ReadLine(), out d))
                    {
                        n0 = false;
                        //pro[i].Price = d;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);

                ////

                Console.WriteLine("Назва валюти");
                string s;
                do
                {
                    n0 = true;
                    s = Console.ReadLine();
                    if (s.Length > 0)
                    {
                        n0 = false;
                        //pro[i].cost.Name = s;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);

                ////

                Console.WriteLine("Курс");
                float p;
                do
                {
                    n0 = true;

                    if (float.TryParse(Console.ReadLine(), out p))
                    {
                        n0 = false;
                        //pro[i].cost.Exrate = p;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);

                ////

                Console.WriteLine("Кількість наявних товарів на складі");
                int c;

                do
                {
                    n0 = true;

                    if (int.TryParse(Console.ReadLine(), out c))
                    {
                        n0 = false;
                        //pro[i].Quantity = c;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);

                ////

                Console.WriteLine("Назва компанії-виробника");
                string a;
                do
                {
                    n0 = true;

                    a = Console.ReadLine();
                    if (a.Length > 0)
                    {
                        n0 = false;
                        //pro[i].Producer = a;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);

                ////

                Console.WriteLine("Вага одиниці товару");
                int v;

                do
                {
                    n0 = true;

                    if (int.TryParse(Console.ReadLine(), out v))
                    {
                        n0 = false;
                        //pro[i].Weight = v;
                    }
                    else
                    {
                        Console.WriteLine("Введіть ще раз");
                    }
                } while (n0);

                pro[i] = new Product(n, d, c, a, v);
                pro[i].cost = new Currency(s, p);

            }
            pro[fl - 1] = new Product(pro[0]);
        }
    }
}