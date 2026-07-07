int[] numbers = { 1, 2, 3, 4, 5 };

// output original
Console.Write("Original: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();

// output reverse
int indexer = 1;
for(int i = 0; i < numbers.Length / 2; i++)
{
    int temp = numbers[i];
    numbers[i] = numbers[numbers.Length - indexer];
    numbers[numbers.Length - indexer] = temp;
    indexer++;

}

Console.Write("Reversed: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}