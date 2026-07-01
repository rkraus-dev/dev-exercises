List<string> items = new List<string> { "Shield", "Sword", "Wand" };
items.Add("Boots");
items.Add("Cape");
items.Remove("Wand");
bool isInInventory = items.Contains("Sword");

Console.WriteLine($"Sword is in inventory: {isInInventory}");

foreach (string item in items)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Total: {items.Count}");

