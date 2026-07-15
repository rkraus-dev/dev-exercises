int a = 10;
int b = 25;

void Swap(ref int a, ref int b)
{
    int save = b;
    b = a;
    a = save;

}

Console.WriteLine($"Before: a = {a}, b = {b}");

Swap(ref a, ref b);

Console.WriteLine($"After: a = {a}, b = {b}");