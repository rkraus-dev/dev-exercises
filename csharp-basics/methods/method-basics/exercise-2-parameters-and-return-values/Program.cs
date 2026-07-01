int AddNumbers(int a, int b)
{
    return a + b;
}

double CalculateAverage(int a, int b, int c)
{
    return (double)(a + b + c) / 3;
}

void PrintResult(string label, double value)
{
    Console.WriteLine($"{label}: {value}");
}

int resultAdd = AddNumbers(3, 7);
double resultAverage = CalculateAverage(3, 4, 5);

PrintResult("Sum", resultAdd);
PrintResult("Average", resultAverage);