HashSet<string> guild1 = new HashSet<string> { "Archer", "Mage", "Warrior", "Healer" };
HashSet<string> guild2 = new HashSet<string> { "Mage", "Paladin", "Warrior", "Rogue" };

// Print Guild 1
Console.Write("Guild 1: ");
foreach (string hero in guild1)
{
    Console.Write(hero + " ");
}

Console.WriteLine();

// Print Guild 2
Console.Write("Guild 2: ");
foreach (string hero in guild2)
{
    Console.Write(hero + " ");
}

Console.WriteLine();
Console.WriteLine();

// Print Common Members
HashSet<string> guild1Copy = new HashSet<string>(guild1);
guild1Copy.IntersectWith(guild2);
Console.Write("Common members: ");
foreach (string hero in guild1Copy)
{
    Console.Write(hero + " ");
}

Console.WriteLine();

// Print only in guild 1
HashSet<string> guild1Copy2 = new HashSet<string>(guild1);
guild1Copy2.ExceptWith(guild2);
Console.Write("Only in Guild 1: ");
foreach (string hero in guild1Copy2)
{
    Console.Write(hero + " ");
}
