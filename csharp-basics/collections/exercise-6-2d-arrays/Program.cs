int enemyCount = 0;
string[,] grid =
{
     {".", "E", "."},
     {"A", ".", "E"},
     {".", ".", "A"}
};

for (int i = 0; i < grid.GetLength(0); i++)
{
    for (int j = 0; j < grid.GetLength(1); j++)
    {
        Console.Write(grid[i, j] + " ");
        if (grid[i, j] == "E")
        {
            enemyCount++;
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Enemy Count: {enemyCount}");

// Find first enemy
for (int i = 0; i < grid.GetLength(0); i++)
{
    for (int j = 0; j < grid.GetLength(1); j++)
    {
        if (grid[i, j] == "E")
        {
            Console.WriteLine($"First enemy at: [{i}, {j}]");
            return;
        }
    }
}


