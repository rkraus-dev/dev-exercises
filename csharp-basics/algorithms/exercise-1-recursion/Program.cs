Console.WriteLine($"Factorial: {Factorial(0)}");
Console.WriteLine($"Factorial: {Factorial(1)}");
Console.WriteLine($"Factorial: {Factorial(5)}");
Console.WriteLine();

Console.Write("Fibonacci: ");
for(int i = 0; i <= 10; i++)
{
    Console.Write($"{Fibonacci(i)} ");
}

int Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    return n * Factorial(n - 1);

}


int Fibonacci(int n)
{
    if(n <= 1)
    {
        return n;
    }
    return Fibonacci(n -1) + Fibonacci(n - 2);

}