using System.Diagnostics;
namespace Radix_Sort
{
    class Program
    {
        public static int Max(int[] arr, int size)//знаходження максимального елемента
        {
            int max = arr[0];
            for (int i = 1; i < size; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
        public static void RadixSort(int[] arr, int size)//сортування за розрядами
        {
            int max = Max(arr, size);//максимальний елемент
            for (int exponent = 1; max / exponent > 0; exponent *= 10)//кількість ітерацій відповідна кількості розрядів максимального елемента
                CountingSort(arr, size, exponent);//сортування
        }
        public static void CountingSort(int[] arr, int size, int exponent)
        {
            int[] output = new int[size];//вихідний масив
            int[] count = new int[10];//масив для оперування над елементами
            for (int i = 0; i < 10; i++)//заповнення додаткового масива значенням '0'
                count[i] = 0;
            for (int i = 0; i < size; i++)//кількість цифр певного розряду від 0 до 9
                count[(arr[i] / exponent) % 10]++;
            for (int i = 1; i < 10; i++)//фактичне розміщення цифр
                count[i] += count[i - 1];
            for (int i = size - 1; i >= 0; i--)//встановлення елементів на їх відсортоване за розрядом місце
            {
                output[count[(arr[i] / exponent) % 10] - 1] = arr[i];
                count[(arr[i] / exponent) % 10]--;
            }
            for (int i = 0; i < size; i++)//копіювання в основний масив
                arr[i] = output[i];
        }
        public static void check(int[]arr, int k, int min, int max)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();
            for (int i = 0; i < k; i++)
                arr[i] = random.Next(min, max + 1);
            stopwatch.Start();
            RadixSort(arr, k);
            stopwatch.Stop();
            Console.WriteLine($"{k} -> {stopwatch.Elapsed.TotalMilliseconds} мс");
            stopwatch.Reset();
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Random random = new Random();

            Console.WriteLine("Сортування за розрядами");
            int size = 10, min = 0, max = 100;
            //k >= 1, min >= 0, max <= 2147483646;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = random.Next(min, max + 1);
            Console.WriteLine("\nВхідні дані: ");
            foreach (var x in arr)
            {
                Console.Write($" {x}");
            }
            RadixSort(arr, size);
            Console.WriteLine("\nВихідні дані: ");
            foreach (var x in arr)
            {
                Console.Write($" {x}");
            }
            Console.WriteLine("\n");


            ////////////////////////////////////////////////////////////
            

            min = 0;
            max = 2147483646;

            size = 10;
            int[] arr_10 = new int[size];
            check(arr_10, size, min, max);

            size = 50;
            int[] arr_50 = new int[size];
            check(arr_50, size, min, max);

            size = 100;
            int[] arr_100 = new int[size];
            check(arr_100, size, min, max);

            size = 500;
            int[] arr_500 = new int[size];
            check(arr_500, size, min, max);

            size = 1000;
            int[] arr_1000 = new int[size];
            check(arr_1000, size, min, max);

            size = 5000;
            int[] arr_5000 = new int[size];
            check(arr_5000, size, min, max);

            size = 10000;
            int[] arr_10000 = new int[size];
            check(arr_10000, size, min, max);

            size = 50000;
            int[] arr_50000 = new int[size];
            check(arr_50000, size, min, max);

            size = 100000;
            int[] arr_100000 = new int[size];
            check(arr_100000, size, min, max);

            size = 500000;
            int[] arr_500000 = new int[size];
            check(arr_500000, size, min, max);

            size = 1000000;
            int[] arr_1000000 = new int[size];
            check(arr_1000000, size, min, max);

            size = 5000000;
            int[] arr_5000000 = new int[size];
            check(arr_5000000, size, min, max);

            size = 10000000;
            int[] arr_10000000 = new int[size];
            check(arr_10000000, size, min, max);
////
//            size = 50000000;
//            int[] arr_50000000 = new int[size];
//            check(arr_50000000, size, min, max);

//            size = 100000000;
//            int[] arr_100000000 = new int[size];
//            check(arr_100000000, size, min, max);

//            size = 500000000;
//            int[] arr_500000000 = new int[size];
//            check(arr_500000000, size, min, max);

//            size = 1000000000;
//            int[] arr_1000000000 = new int[size];
//            check(arr_1000000000, size, min, max);
        }
    }
}