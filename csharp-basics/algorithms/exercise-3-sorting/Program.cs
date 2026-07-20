int[] numbers = {3, 7, 1, 2, 5, 10, 6, 4, 8, 9};
int[] numbers2 = {3, 7, 1, 2, 5, 10, 6, 4, 8, 9};

Console.WriteLine($"Unsorted: {string.Join(", ", numbers)}");
BubbleSort(numbers);
Console.WriteLine($"Sorted: {string.Join(", ", numbers)}");
Console.WriteLine();
Console.WriteLine($"Unsorted: {string.Join(", ", numbers2)}");
Array.Sort(numbers2);
Console.WriteLine($"Sorted: {string.Join(", ", numbers2)}");


void BubbleSort(int[] numbers)
{
    for(int i = 0; i < numbers.Length - 1; i++)
    {
        for(int j = 0; j < numbers.Length - 1 - i; j++)
        {
            if(numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
}


