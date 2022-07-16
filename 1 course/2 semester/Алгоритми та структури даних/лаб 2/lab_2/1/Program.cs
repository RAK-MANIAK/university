int a = 1664525, c = 1013904223, n = 150, x = 0;
double k = 20000, m = 0, d = 0, q = 0;
int mod = (int)Math.Pow(2, 32);
int[] l = new int[n];
double[] p = new double[n];
int[] mass = new int[20000];

for (int i = 0; i < k ;)
{
    x = (a * x + c) % mod;
    mass[i] = x % n;
    if (x >= 0)
    {
        Console.WriteLine($"{i+1} - {x % n}");
        i++;
}
}
Console.WriteLine();

for (int i = 0; i < k; i++)
{
    l[mass[i]] = l[mass[i]] + 1;
}

for (int i = 0; i < k; i++)
{
    p[mass[i]] = l[mass[i]] / k;
}
for (int i = 0; i < n; i++)
    Console.WriteLine($"P({i}) = {p[i]} ({l[i]})");


for (int i = 0; i < n; i++)
{
    m = m + i * p[i];
}
Console.WriteLine($"\nM(X)={m:f2}");


for (int i = 0; i < n; i++)
{
    d = d + Math.Pow((i - m), 2) * p[i];
}
Console.WriteLine($"D(X)={d:f2}");


    q = Math.Sqrt(d);

Console.WriteLine($"q(X)={q:f2}");