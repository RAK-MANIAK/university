namespace lab_7_8
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int v = 19;
            int[] dfs = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            string[] city = { "Київ", "Житомир", "Новоград-Волинський", "Рівне", "Луцьк",
                    "Бердичів","Вінниця","Хмельницький", "Тернопіль",
                    "Шепетівка",
                    "Біла церква", "Умань",
                    "Черкаси", "Кременчук",
                    "Полтава", "Харків",
                    "Прилуки", "Суми",
                    "Миргород"};
            int[] km = { 135, 80, 100, 68, 38, 73, 110, 104, 115, 78, 115, 146, 105, 181, 130, 128, 175, 109 };
            int[,] edges = new int[v, v];
            bool[] visited = new bool[v];
            edges[0, 1] = 1;
            edges[1, 2] = 1;
            edges[2, 3] = 1;
            edges[3, 4] = 1;
            edges[1, 5] = 1;
            edges[5, 6] = 1;
            edges[6, 7] = 1;
            edges[7, 8] = 1;
            edges[1, 9] = 1;
            edges[0, 10] = 1;
            edges[10, 11] = 1;
            edges[10, 12] = 1;
            edges[12, 13] = 1;
            edges[10, 14] = 1;
            edges[14, 15] = 1;
            edges[0, 16] = 1;
            edges[16, 17] = 1;
            edges[16, 18] = 1;
            Console.WriteLine("DFS");
            for (int i = 0; i < v; i++)
            {
                if (!visited[i])
                    DFS(edges, v, visited, i, city);
            }
            for (int i = 0; i < v; i++)
            {
                visited[i] = false;
            }
            Console.WriteLine();
            Console.WriteLine("BFS");
            for (int i = 0; i < v; i++)
            {
                if (!visited[i])
                    BFS(edges, v, visited, i, dfs[i], city);
            }
            Console.WriteLine($"\nКиїв - Житомир:{km[0]}");
            Console.WriteLine($"Київ - Житомир - Новоград-Волинський:{km[0] + km[1]}");
            Console.WriteLine($"Київ - Житомир - Новоград-Волинський - Рівне:{km[0] + km[1] + km[2]}");
            Console.WriteLine($"Київ - Житомир - Новоград-Волинський - Рівне - Луцьк:{km[0] + km[1] + km[2] + km[3]}");
            Console.WriteLine($"Київ - Житомир - Бердичів:{km[0] + km[4]}");
            Console.WriteLine($"Київ - Житомир - Бердичів - Вінниця:{km[0] + km[4] + km[5]}");
            Console.WriteLine($"Київ - Житомир - Бердичів - Вінниця - Хмельницький:{km[0] + km[4] + km[5] + km[6]}");
            Console.WriteLine($"Київ - Житомир - Бердичів - Вінниця - Хмельницький - Тернопіль:{km[0] + km[4] + km[5] + km[6] + km[7]}");
            Console.WriteLine($"Київ - Житомир - Шепетівка: {km[0] + km[8]}");
            Console.WriteLine($"Київ - Біла церква - Умань: {km[9] + km[10]}");
            Console.WriteLine($"Київ - Біла церква - Черкаси - Кременчук: {km[9] + km[11] + km[12]}");
            Console.WriteLine($"Київ - Біла церква - Полтава - Харків: {km[9] + km[13] + km[14]}");
            Console.WriteLine($"Київ - Прилуки - Суми: {km[15] + km[16]}");
            Console.WriteLine($"Київ - Прилуки - Миргород: {km[15] + km[17]}");
        }
        static void DFS(int[,] edges, int v, bool[] visited, int si, string[] city)//по вертикалі
        {
            visited[si] = true;//відвідане
            Console.Write($"{city[si]} ");
            for (int i = 0; i < v; i++)
            {
                if (i == si)
                    continue;
                if (!visited[i] && edges[si, i] == 1)
                {
                    DFS(edges, v, visited, i, city);//пошук зв'язаниг графів
                }
            }
        }
        static void BFS(int[,] edges, int v, bool[] visited, int j, int si, string[] city)//по горизонталі
        {
            Queue<int> queue = new Queue<int>();//створення черги (перший зайшов, перший вийшов)
            queue.Enqueue(si);//запис в кінець черги 
            visited[si] = true;
            while (queue.Count != 0)
            {
                int currentVertex = queue.Dequeue();
                Console.Write($"{city[currentVertex]} ");
                for (int i = 0; i < v; i++)//пошук графів на цьому рівні
                {
                    if (i == j)
                        continue;
                    if (!visited[i] && edges[currentVertex, i] == 1)
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }
    }
}