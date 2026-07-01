// Part A
int CalculateSum(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}

int FindMax(int[] numbers)
{
    int max = numbers[0]; // Startwert = erstes Element, nicht 0!
    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }
    return max;
}

int[] scores = { 334, 579, 1034, 3002, 58 };

foreach (int score in scores)
{
    Console.WriteLine(score);
}

Console.WriteLine($"Sum: {CalculateSum(scores)}");
Console.WriteLine($"Biggest Value: {FindMax(scores)}");
Console.WriteLine(); // Space between Part A and B output

// Part B
int[,] grid =
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

for (int row = 0; row < grid.GetLength(0); row++)
{
    for (int col = 0; col < grid.GetLength(1); col++)
    {
        Console.Write(grid[row, col] + " ");
    }

    Console.WriteLine();

}


