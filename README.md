# 2026.11.02.-csharp-orai
Órai csharp feladatok: Abs_max; Fibonacci
```c#
//1 Abs Max
int abs_max(int a, int b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);
    return Math.Max(a, b);
}
Console.WriteLine(abs_max(12, -15));


//2 Fibonacci
int fibo(int n)
{
    if (n == 0) 
    {
        return 0;
    }
    if (n <= 2)
    { 
        return 1;
    }

    return fibo(n - 1) + fibo(n - 2);
}
Console.WriteLine(fibo(10));

```