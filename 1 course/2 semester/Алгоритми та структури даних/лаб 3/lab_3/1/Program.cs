Console.WriteLine("f(n) = n");
Console.WriteLine("x\ty");
double f;
for(int n = 0; n <= 50; n++)
{
    f = n;
    Console.WriteLine($"{n}\t{f}");
}

Console.WriteLine("f(n) = lg(n)");
Console.WriteLine("x\ty");
for (int n = 0; n <= 50; n++)
{
    f = Math.Log10(n);
    Console.WriteLine($"{n}\t{Math.Round(f, 4)}");
}


Console.WriteLine("f(n) = n * lg(n)");
Console.WriteLine("x\ty");
for (int n = 0; n <= 50; n++)
{
    f = n * Math.Log10(n);
    Console.WriteLine($"{n}\t{Math.Round(f, 4)}");
}


Console.WriteLine("f(n) = n^2");
Console.WriteLine("x\ty");
for (int n = 0; n <= 50; n++)
{
    f = Math.Pow(n, 2);
    Console.WriteLine($"{n}\t{Math.Round(f, 4)}");
}


Console.WriteLine("f(n) = 2^n");
Console.WriteLine("x\ty");
for (int n = 0; n <= 50; n++)
{
    f = Math.Pow(2, n);
    Console.WriteLine($"{n}\t{Math.Round(f, 4)}");
}


Console.WriteLine("f(n) = n!");
Console.WriteLine("x\ty");
Console.WriteLine($"{0}\t{1}");
for (int n = 1; n <= 50; n++)
{
    f = 1;
    for (int k = 1; k <= n; k++)
    {
        f = f * k;
    }
    Console.WriteLine($"{n}\t{Math.Round(f, 4)}");
}