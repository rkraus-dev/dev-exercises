int[] stats = { 42, 17, 85, 3, 66, 29 };
int biggestNum = stats[0];
int lowestNum = stats[0];

Console.Write("Stats: ");
foreach (int stat in stats)
{
    Console.Write(stat + " ");

    if(biggestNum < stat)
    {
        biggestNum = stat;
    }

    if(lowestNum > stat)
    {
        lowestNum = stat;
    }
}

Console.WriteLine();
Console.WriteLine($"Max: {biggestNum}");
Console.WriteLine($"Min: {lowestNum}");
