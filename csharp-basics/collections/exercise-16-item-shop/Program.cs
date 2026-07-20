Dictionary<string, int> inventory = new Dictionary<string, int>
{
  {"Sword", 150},
  {"Shield", 120},
  {"Potion", 30},
  {"Bow", 90},
  {"Armor", 200}

};
Console.WriteLine("Shop inventory:");
foreach (KeyValuePair<string, int> item in inventory)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

Console.WriteLine();
Console.WriteLine("Adding Elixir...");
inventory.Add("Elixir", 80);
Console.WriteLine("Price increase on Sword...");
inventory["Sword"] = 175;
Console.WriteLine();

//check if dagger is in shop
Console.WriteLine($"Dagger in shop: {inventory.ContainsKey("Dagger")}");

//cheapest item
int cheapestItemValue = int.MaxValue;
string cheapestItemName = "";
foreach (KeyValuePair<string, int> item in inventory)
{
    if (item.Value < cheapestItemValue)
    {
        cheapestItemValue = item.Value;
        cheapestItemName = item.Key;
    }
}

Console.WriteLine($"Cheapest Item: {cheapestItemName} ({cheapestItemValue})");

Console.WriteLine();
Console.WriteLine("Updated inventory:");
foreach (KeyValuePair<string, int> item in inventory)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
