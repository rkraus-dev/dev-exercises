HashSet<string> members = new HashSet<string>() {"Archer", "Mage", "Warrior"};
HashSet<string> members2 = new HashSet<string>() {"Paladin", "Mage", "Ranger"};

Console.WriteLine("Guild members: ");
foreach (string member in members)
{
    Console.WriteLine(member);
}

Console.WriteLine();
Console.WriteLine($"Adding Healer ... Success: {members.Add("Healer")}");
Console.WriteLine($"Adding Mage (duplicate) ... Success: {members.Add("Mage")}");
Console.WriteLine();
Console.WriteLine($"Archer in guild: {members.Contains("Archer")}");
Console.WriteLine();
Console.WriteLine("Removing Warrior...");
members.Remove("Warrior");

Console.Write("Second Guild members: ");
Console.Write(string.Join(", ", members2));

Console.WriteLine();
Console.WriteLine("After Union:");
members.UnionWith(members2);
foreach (string member in members)
{
    Console.WriteLine(member);
}
