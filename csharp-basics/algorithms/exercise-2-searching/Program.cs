int[] unsortedArr = { 3, 14, 57, 1, 17, 20, 5, 8 };
int[] sortedArr = { 1, 3, 5, 8, 14, 17, 20, 57 };

Console.WriteLine($"Linear search for: 20 | Found at Index: {LinearSearch(unsortedArr, 20)}");
Console.WriteLine($"Linear search for: 109 | Found at Index: {LinearSearch(unsortedArr, 109)}");
Console.WriteLine();
Console.WriteLine($"Binary search for: 57 | Found at Index: {BinarySearch(sortedArr, 57)}");
Console.WriteLine($"Binary search for: 109 | Found at Index: {BinarySearch(sortedArr, 109)}");


int LinearSearch(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }

    return -1;
}

int BinarySearch(int[] numbers, int target)
{
    int left = 0;
    int right = numbers.Length - 1;

    while (left <= right)
    {
        int middle = (left + right) / 2;
        if (numbers[middle] == target)
        {
            return middle;
        }
        else if (numbers[middle] < target)
        {
            left = middle + 1;
        }
        else
        {
            right = middle - 1;
        }
    }

    return - 1;
}