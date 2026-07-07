int[] numbers = { 1, 2, 3, 2, 4, 3, 5, 1 };
HashSet<int> cleaned = new HashSet<int>();

// Print original and remove duplicates
Console.Write("Original: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
    cleaned.Add(number);
}

// fill new array with cleaned Hashset
int[] cleanedArray = new int[cleaned.Count];
int indexer = 0;
foreach (int number in cleaned)
{
    cleanedArray[indexer] = number;
    indexer++;
}

// output cleaned array
Console.WriteLine();
Console.Write("Cleaned: ");
foreach (int number in cleanedArray)
{
    Console.Write(number + " ");
}