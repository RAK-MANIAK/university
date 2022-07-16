using System.Diagnostics;
namespace lab_5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();
            LinkedList<int> list = new LinkedList<int>();
            int[] mass_1 = new int[10];
            int[] mass_2 = new int[100];
            int[] mass_3 = new int[500];
            int[] mass_4 = new int[1000];
            int[] mass_5 = new int[2000];
            int[] mass_6 = new int[5000];
            int[] mass_7 = new int[10000];
            Console.WriteLine("a) сортування вибором (структура даних – двусвязний список);");
            Console.WriteLine("б) сортування вставками (структура даних – масив);");
            Console.WriteLine("в) сортування вставками (структура даних – двусвязний список); ");
            int x = 10, num;
            Console.WriteLine($"\nРозмірність {x}:");
            for (int i = 0; i < x; i++)
            {
                num = random.Next(-x, x);
                list.AddLast(num);
                mass_1[i] = num;
            }

            stopwatch.Start();
            listSelectionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            for (int i = 0; i < x; i++)
            {
                list.AddLast(mass_1[i]);
            }
                Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");

            stopwatch.Reset();
            stopwatch.Start();
            massInsertionSort(mass_1);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");

            for (int i = 0; i < x; i++)
                list.AddLast(random.Next(-x, x));
            stopwatch.Reset();
            stopwatch.Start();
            listInsertionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");


            ////////////////////////////////////////////////////////////////////


            x = 100;
            Console.WriteLine($"\nРозмірність {x}:");
            for (int i = 0; i < x; i++)
            {
                num = random.Next(-x, x);
                list.AddLast(num);
                mass_2[i] = num;
            }
            stopwatch.Reset();
            stopwatch.Start();
            listSelectionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            for (int i = 0; i < x; i++)
            {
                list.AddLast(mass_2[i]);
            }
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");


            stopwatch.Reset();
            stopwatch.Start();
            massInsertionSort(mass_2);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");

            for (int i = 0; i < x; i++)
                list.AddLast(random.Next(-x, x));
            stopwatch.Reset();
            stopwatch.Start();
            listInsertionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");


            ////////////////////////////////////////////////////////////////////


            x = 500;
            Console.WriteLine($"\nРозмірність {x}:");
            for (int i = 0; i < x; i++)
            {
                num = random.Next(-x, x);
                list.AddLast(num);
                mass_3[i] = num;
            }
            stopwatch.Reset();
            stopwatch.Start();
            listSelectionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            for (int i = 0; i < x; i++)
            {
                list.AddLast(mass_3[i]);
            }
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");


            stopwatch.Reset();
            stopwatch.Start();
            massInsertionSort(mass_3);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");

            for (int i = 0; i < x; i++)
                list.AddLast(random.Next(-x, x));
            stopwatch.Reset();
            stopwatch.Start();
            listInsertionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");


            ////////////////////////////////////////////////////////////////////


            x = 1000;
            Console.WriteLine($"\nРозмірність {x}:");
            for (int i = 0; i < x; i++)
            {
                num = random.Next(-x, x);
                list.AddLast(num);
                mass_4[i] = num;
            }
            stopwatch.Reset();
            stopwatch.Start();
            listSelectionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            for (int i = 0; i < x; i++)
            {
                list.AddLast(mass_4[i]);
            }
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");


            stopwatch.Reset();
            stopwatch.Start();
            massInsertionSort(mass_4);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");

            for (int i = 0; i < x; i++)
                list.AddLast(random.Next(-x, x));
            stopwatch.Reset();
            stopwatch.Start();
            listInsertionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");


            ////////////////////////////////////////////////////////////////////


            x = 2000;
            Console.WriteLine($"\nРозмірність {x}:");
            for (int i = 0; i < x; i++)
            {
                num = random.Next(-x, x);
                list.AddLast(num);
                mass_5[i] = num;
            }
            stopwatch.Reset();
            stopwatch.Start();
            listSelectionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            for (int i = 0; i < x; i++)
            {
                list.AddLast(mass_5[i]);
            }
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");


            stopwatch.Reset();
            stopwatch.Start();
            massInsertionSort(mass_5);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");

            for (int i = 0; i < x; i++)
                list.AddLast(random.Next(-x, x));
            stopwatch.Reset();
            stopwatch.Start();
            listInsertionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");


            ////////////////////////////////////////////////////////////////////


            x = 5000;
            Console.WriteLine($"\nРозмірність {x}:");
            for (int i = 0; i < x; i++)
            {
                num = random.Next(-x, x);
                list.AddLast(num);
                mass_6[i] = num;
            }
            stopwatch.Reset();
            stopwatch.Start();
            listSelectionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            for (int i = 0; i < x; i++)
            {
                list.AddLast(mass_6[i]);
            }
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");


            stopwatch.Reset();
            stopwatch.Start();
            massInsertionSort(mass_6);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");

            for (int i = 0; i < x; i++)
                list.AddLast(random.Next(-x, x));
            stopwatch.Reset();
            stopwatch.Start();
            listInsertionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");


            ////////////////////////////////////////////////////////////////////


            x = 10000;
            Console.WriteLine($"\nРозмірність {x}:");
            for (int i = 0; i < x; i++)
            {
                num = random.Next(-x, x);
                list.AddLast(num);
                mass_7[i] = num;
            }
            stopwatch.Reset();
            stopwatch.Start();
            listSelectionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            for (int i = 0; i < x; i++)
            {
                list.AddLast(mass_7[i]);
            }
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");


            stopwatch.Reset();
            stopwatch.Start();
            massInsertionSort(mass_7);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");

            for (int i = 0; i < x; i++)
                list.AddLast(random.Next(-x, x));
            stopwatch.Reset();
            stopwatch.Start();
            listInsertionSort(list, x);
            stopwatch.Stop();
            list.Clear();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");





            //foreach (var person in list) Console.WriteLine(person);

        }

        static void listInsertionSort(LinkedList<int> list, int x)
        {
            int count = 1;
            int k;
            int j;
            int temp;
            var currentNode = list.First;
            for (int i = 1; i < x; i++)//початок сортування вставок для масиву
            {
                currentNode = list.First;
                for(count = 0; count < i; count++)//повернення до теперішнього елемента
                    currentNode = currentNode.Next;

                k = currentNode.Value;//теперішній елемент
                j = i;//індекс теперішнього елемента
                while (j > 0 && currentNode.Previous.Value > k)//заміна
                {
                    temp = currentNode.Value;
                    currentNode.Value = currentNode.Previous.Value;
                    currentNode.Previous.Value = temp;
                    j--;
                    currentNode = currentNode.Previous;
                }
                currentNode.Value = k;
            }
        }

        static void massInsertionSort(int[] mass)
        {
            int k;
            int j;
            int temp;
            for (int i = 1; i < mass.Length; i++)//початок сортування вставок для масиву
            {
                k = mass[i];//теперішній елемент
                j = i;//індекс теперішнього елемента
                while (j > 0 && mass[j - 1] > k)//заміна
                {
                    temp = mass[j];
                    mass[j] = mass[j-1];
                    mass[j-1] = temp;
                    j--;
                }
                mass[j] = k;
            }
        }


        static void listSelectionSort(LinkedList<int> list, int x, int currentIndex = 0, int count_1 = 50000, int index = 0, int i = -1, int count_2 = 50000)
        {
            for (currentIndex = 0; currentIndex < x; currentIndex++)//початок сортування вибором для списків
            {
                count_2 = 50000;
                i = -1;
                index = 0;
                foreach (var person in list)//пошук теперішнього та найменшого елемента
                {
                    i++;//індекс теперішнього елемента
                    if (person < count_2 && i > currentIndex)//найменший елемент
                    {
                        count_2 = person;//найменший знайдений елемент
                        index = i;//індекс найменшого елемента
                    }
                    if (i == currentIndex)//теперішній елемент
                        count_1 = person;
                }
                if (index != currentIndex && count_2 <= count_1)//заміна
                {
                    i = -1;
                    var currentNode = list.First;
                    while (currentNode != null)//пошук цих елементів
                    {
                        i++;
                        if (i == currentIndex)//заміна
                            currentNode.Value = count_2;
                        if (i == index)//заміна
                            currentNode.Value = count_1;
                        currentNode = currentNode.Next;
                    }
                }
            }
        }
    }
}