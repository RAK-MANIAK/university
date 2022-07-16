System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

Console.OutputEncoding = System.Text.Encoding.Default;
bool n0;
int x;
int n;
LinkedList<int> list = new LinkedList<int>();
Console.WriteLine("Введіть кількість елементів списку:");
do
{
    n0 = true;
    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
    {
        n0 = false;
    }
    else
    {
    Console.WriteLine("Введіть ще раз");
    }
} while (n0);

for (int i = 1; i <= n; i++)
{
    list.AddLast(i);
}
do
{
    Console.WriteLine();
    foreach (int i in list)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("\n\n1)додати елемент\n2)видалити елемент списку\n3)видалити список");
    do
    {
        n0 = true;
        if (int.TryParse(Console.ReadLine(), out x))
        {
            n0 = false;
        }
        else
        {
            Console.WriteLine("Введіть ще раз");
        }
    } while (n0);
    switch (x)
    {
        case 1:
            Console.WriteLine("Введіть елемент після якого додати новий");
            int k;
            do
            {
                n0 = true;
                if (int.TryParse(Console.ReadLine(), out k))
                {
                    foreach (int i in list)
                    {
                        if (k == i)
                        {
                            n0 = false;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Введіть ще раз");
                }
            } while (n0);

            Console.WriteLine("Введіть новий елемент");
            int g;
            do
            {
                n0 = true;
                if (int.TryParse(Console.ReadLine(), out g))
                {
                    n0 = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз");
                }
            } while (n0);

            LinkedListNode<int> lln = list.Find(k);
            list.AddAfter(lln, g);
            break;
        case 2:
            Console.WriteLine("Введіть елемент який хочете видалити:");
            int l;
            do
            {
                n0 = true;
                if (int.TryParse(Console.ReadLine(), out l))
                {
                    n0 = false;
                }
                else
                {
                    Console.WriteLine("Введіть ще раз");
                }
            } while (n0);
            LinkedListNode<int> lll = list.Find(l);
            list.Remove(lll);
            break;
        case 3:
            list.Clear();
            list.AddLast(0);
            break;
        default:
            x = 0;
            break;
    }
} while (x != 0);