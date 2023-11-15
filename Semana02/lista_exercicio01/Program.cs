#region Example 01

for (var i = 0; i <= 30; i++)
{
    if (i % 3 == 0 || i % 4 == 0) Console.WriteLine($"{i}");

}

Console.WriteLine(" ");
#endregion

#region Example 02

int aux = 0, aux02 = 1;
for (int fib = 0; fib < 100;)
{
    fib = aux + aux02;
    aux = aux02;
    aux02 = fib;
    Console.WriteLine($"Fibonacci {fib}");

}

#endregion

#region Example 03

int n;
for (var i = 1; i < 9; i++)
{
    Console.Write(i);
    for (var j = 2; j <= i; j++)
    {
        n = i * j;
        Console.Write($" {n}");
    }
    Console.WriteLine(" ");
}

#endregion