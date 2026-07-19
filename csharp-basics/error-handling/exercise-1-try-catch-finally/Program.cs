try
{
    Console.WriteLine(Divide(10, 2));
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong: " + ex.Message);
}
finally
{
    Console.WriteLine("Attempt finished.");
}

Console.WriteLine();

try
{
    Divide(10, 0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Cannot divide by zero: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong: " + ex.Message);
}
finally
{
    Console.WriteLine("Attempt finished.");
}

Console.WriteLine();

int[] row = { 1, 2, 3 };

try
{
    Console.WriteLine(row[10]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Invalid index: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong: " + ex.Message);
}
finally
{
    Console.WriteLine("Attempt finished.");
}

int Divide(int a, int b)
{
    return a / b;
}