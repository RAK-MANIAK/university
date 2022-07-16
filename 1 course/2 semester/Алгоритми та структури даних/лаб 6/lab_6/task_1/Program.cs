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
            Console.WriteLine("a) пірамідальне сортування (структура даних – масив);");
            Console.WriteLine("б) сортування Шелла(структура даних – масив);");
            Console.WriteLine("в) сортування підрахунком(структура даних – масив);\n");

            double[] piramida_10 = new double[10];
            double[] piramida_100 = new double[100];
            double[] piramida_500 = new double[500];
            double[] piramida_1000 = new double[1000];
            double[] piramida_2000 = new double[2000];
            double[] piramida_5000 = new double[5000];
            double[] piramida_10000 = new double[10000];

            float[] szela_10 = new float[10];
            float[] szela_100 = new float[100];
            float[] szela_500 = new float[500];
            float[] szela_1000 = new float[1000];
            float[] szela_2000 = new float[2000];
            float[] szela_5000 = new float[5000];
            float[] szela_10000 = new float[10000];

            char[] liczba_10 = new char[10];
            char[] liczba_100 = new char[100];
            char[] liczba_500 = new char[500];
            char[] liczba_1000 = new char[1000];
            char[] liczba_2000 = new char[2000];
            char[] liczba_5000 = new char[5000];
            char[] liczba_10000 = new char[10000];

            HeapSort heapSort = new HeapSort();
            ShellSort shellSort = new ShellSort();
            CountSort countSort = new CountSort();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////


            int count = 10;
            Console.WriteLine($"Розмірність: {count}");
            for (int i = 0; i < count; i++)
            {
                piramida_10[i] = random.NextDouble() * (100 - (-10)) - 10;
            }
            stopwatch.Start();
            heapSort.sort(piramida_10);
            stopwatch.Stop();
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                szela_10[i] = (float)random.NextDouble() * (200 - 0) - 0;
            }
            stopwatch.Start();
            shellSort.Sort(szela_10);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                liczba_10[i] = (char)random.Next(-100, -10);
            }
            stopwatch.Start();
            countSort.Sort(liczba_10);
            stopwatch.Stop();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////


            count = 100;
            Console.WriteLine($"\nРозмірність: {count}");
            for (int i = 0; i < count; i++)
            {
                piramida_100[i] = random.NextDouble() * (100 - (-10)) - 10;
            }
            stopwatch.Start();
            heapSort.sort(piramida_100);
            stopwatch.Stop();
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                szela_100[i] = (float)random.NextDouble() * (200 - 0) - 0;

            }
            stopwatch.Start();
            shellSort.Sort(szela_100);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                liczba_100[i] = (char)random.Next(-100, -10);
            }
            stopwatch.Start();
            countSort.Sort(liczba_100);
            stopwatch.Stop();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////


            count = 500;
            Console.WriteLine($"\nРозмірність: {count}");
            for (int i = 0; i < count; i++)
            {
                piramida_500[i] = random.NextDouble() * (100 - (-10)) - 10;
            }
            stopwatch.Start();
            heapSort.sort(piramida_500);
            stopwatch.Stop();
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                szela_500[i] = (float)random.NextDouble() * (200 - 0) - 0;

            }
            stopwatch.Start();
            shellSort.Sort(szela_500);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                liczba_500[i] = (char)random.Next(-100, -10);
            }
            stopwatch.Start();
            countSort.Sort(liczba_500);
            stopwatch.Stop();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////


            count = 1000;
            Console.WriteLine($"\nРозмірність: {count}");
            for (int i = 0; i < count; i++)
            {
                piramida_1000[i] = random.NextDouble() * (100 - (-10)) - 10;
            }
            stopwatch.Start();
            heapSort.sort(piramida_1000);
            stopwatch.Stop();
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                szela_1000[i] = (float)random.NextDouble() * (200 - 0) - 0;

            }
            stopwatch.Start();
            shellSort.Sort(szela_1000);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                liczba_1000[i] = (char)random.Next(-100, -10);
            }
            stopwatch.Start();
            countSort.Sort(liczba_1000);
            stopwatch.Stop();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////


            count = 2000;
            Console.WriteLine($"\nРозмірність: {count}");
            for (int i = 0; i < count; i++)
            {
                piramida_2000[i] = random.NextDouble() * (100 - (-10)) - 10;
            }
            stopwatch.Start();
            heapSort.sort(piramida_2000);
            stopwatch.Stop();
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                szela_2000[i] = (float)random.NextDouble() * (200 - 0) - 0;

            }
            stopwatch.Start();
            shellSort.Sort(szela_2000);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                liczba_2000[i] = (char)random.Next(-100, -10);
            }
            stopwatch.Start();
            countSort.Sort(liczba_2000);
            stopwatch.Stop();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////


            count = 5000;
            Console.WriteLine($"\nРозмірність: {count}");
            for (int i = 0; i < count; i++)
            {
                piramida_5000[i] = random.NextDouble() * (100 - (-10)) - 10;
            }
            stopwatch.Start();
            heapSort.sort(piramida_5000);
            stopwatch.Stop();
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                szela_5000[i] = (float)random.NextDouble() * (200 - 0) - 0;

            }
            stopwatch.Start();
            shellSort.Sort(szela_5000);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                liczba_5000[i] = (char)random.Next(-100, -10);
            }
            stopwatch.Start();
            countSort.Sort(liczba_5000);
            stopwatch.Stop();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////


            count = 10000;
            Console.WriteLine($"\nРозмірність: {count}");
            for (int i = 0; i < count; i++)
            {
                piramida_10000[i] = random.NextDouble() * (100 - (-10)) - 10;
            }
            stopwatch.Start();
            heapSort.sort(piramida_10000);
            stopwatch.Stop();
            Console.WriteLine($"а) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                szela_10000[i] = (float)random.NextDouble() * (200 - 0) - 0;

            }
            stopwatch.Start();
            shellSort.Sort(szela_10000);
            stopwatch.Stop();
            Console.WriteLine($"б) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
            for (int i = 0; i < count; i++)
            {
                liczba_10000[i] = (char)random.Next(-100, -10);
            }
            stopwatch.Start();
            countSort.Sort(liczba_10000);
            stopwatch.Stop();
            Console.WriteLine($"в) {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
        }
    }
    public class HeapSort
    {
        public void sort(double[] arr)
        {
            int n = arr.Length;
            //перегрупування масиву
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);//найбільше в кінець
            }
        }
        void heapify(double[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;//ліва частина
            int r = 2 * i + 2;//права частина
            if (l < n && arr[l] > arr[largest])//якщо лівий елемент більше
                largest = l;
            if (r < n && arr[r] > arr[largest])//якщо правий елемент більше
                largest = r;
            if (largest != i)//якщо неайбільше не корінь
            {
                var swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }
    }
    public class ShellSort
    {
        static void Swap(ref float a, ref float b)//заміна
        {
            var t = a;
            a = b;
            b = t;
        }
        public void Sort(float[] array)
        {
            var d = array.Length / 2;//відстань між елементами, які порівнюються
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))//пошук більшого
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }
                d = d / 2;//зменшення відстані
            }
        }
    }
    public class CountSort
    {
        public void Sort(char[] inputArray)
        {
            int[] countArray = new int[inputArray.Max() + 1];//мазив з кінцевим індексом максимального елемента
            for (int i = 0; i < inputArray.Length; i++)//елемент стає на індекс, відповідно свого числа
            {
                countArray[inputArray[i]]++;
            }

            int sortedArrayIndex = 0;//індекс відсортованого елемента
            for (int i = countArray.Length - 1; i >= 0; i--)//сортування
            {
                for (int j = 0; j < countArray[i]; j++)
                {
                    inputArray[sortedArrayIndex++] = (char)i;
                }
            }
        }
    }
}