string[] drops = { "Coin", "Slime", "Feather" };

Dictionary<string, int> dropCounts = new Dictionary<string, int>();

// fill drops
foreach (string drop in drops)
{
    dropCounts.Add(drop, 0);
}

// manuell setting count of items
dropCounts["Coin"] = 200;
dropCounts["Slime"] = 87;
dropCounts["Feather"] = 10;

HashSet<string> rareItems = new HashSet<string>() { "Sword" };

// Print all
Console.WriteLine($"Possible drops: ");
foreach (string drop in drops)
{
    Console.WriteLine(drop);
}
Console.WriteLine();
Console.WriteLine("Collected Drops: ");
foreach (KeyValuePair<string, int> drop in dropCounts)
{
    Console.WriteLine($"{drop.Key}: {drop.Value}");
}

Console.WriteLine();
Console.WriteLine($"Try adding sword to list.... Success: {rareItems.Add("Sword")}");
Console.WriteLine("Legendary drop:");
foreach (string legendary in rareItems)
{
    Console.WriteLine(legendary);
}