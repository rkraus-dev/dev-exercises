int[] numbers = { 1, 2, 3, 2, 4, 3, 5, 1 };
int[] cleaned = new int[numbers.Length];

int counter = 0;

for (int i = 0; i < numbers.Length; i++)
{
    bool isDuplicate = false;

    for (int j = 0; j < counter; j++)
    {
        if (cleaned[j] == numbers[i])
        {
            isDuplicate = true;
        }
    }

    if (!isDuplicate)
    {
        cleaned[counter] = numbers[i];
        counter++;
    }
}

// Print
Console.Write("Original: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();
Console.Write("Cleaned: ");
foreach (int clean in cleaned)
{
    if (clean != 0)
        Console.Write(clean + " ");
}