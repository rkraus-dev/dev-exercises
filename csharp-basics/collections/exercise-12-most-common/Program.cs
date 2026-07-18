List<string> drops = new List<string> { "Sword", "Coin", "Coin", "Shield", "Coin", "Sword", "Potion", "Coin" };
Dictionary<string, int> dropCount = new Dictionary<string, int>();

Console.Write($"Drops:");
foreach (string drop in drops)
{
    Console.Write(drop + " ");
    if (dropCount.ContainsKey(drop))
    {
        dropCount[drop]++;
    }
    else
    {
        dropCount.Add(drop, 1);
    }
}

string mostCommon = "";
int highestCount = 0;
foreach (KeyValuePair<string, int> value in dropCount)
{
    if (value.Value > highestCount)
    {
        mostCommon = value.Key;
        highestCount = value.Value;
    }
}
Console.WriteLine();
Console.WriteLine($"Most common drop: {mostCommon} ({highestCount}x)");