string[] ingredients = { "moonherb", "dragon-scale", "moonherb", "nightshade", "moonherb", "dragon-scale" };

Console.WriteLine("=== Alchemist's Satchel ===");
Console.WriteLine($"Ingredients: {string.Join(", ", ingredients)}");
Console.WriteLine();

Dictionary<string, int> counts = CountIngredients(ingredients);

if (counts.Count == 0)
{
    Console.WriteLine("The satchel is empty!");
}
else
{
    foreach (KeyValuePair<string, int> entry in counts)
    {
        Console.WriteLine($"{entry.Key} x{entry.Value}");
    }

    Console.WriteLine();

    List<string> duplicates = new List<string>();

    foreach (KeyValuePair<string, int> entry in counts)
    {
        if (entry.Value > 1)
        {
            duplicates.Add(entry.Key);
        }
    }

    if (duplicates.Count == 0)
    {
        Console.WriteLine("No duplicates - nothing to sell!");
    }
    else
    {
        Console.WriteLine($"Duplicates found: {string.Join(", ", duplicates)}");
    }
}

Dictionary<string, int> CountIngredients(string[] ingredients)
{
    Dictionary<string, int> counts = new Dictionary<string, int>();

    if (ingredients == null || ingredients.Length < 1)
    {
        return counts;
    }

    foreach (string ingredient in ingredients)
    {
        if (counts.ContainsKey(ingredient))
        {
            counts[ingredient]++;
        }
        else
        {
            counts.Add(ingredient, 1);
        }
    }

    return counts;
}