List<string> heroes = new List<string>(){"Archer", "Mage", "Warrior"};

// Print list
Console.WriteLine("Party:");
for(int i = 0; i < heroes.Count; i++)
{
    Console.WriteLine($"[{i}] {heroes[i]}");
}
Console.WriteLine();

// Add a hero
Console.WriteLine("Adding Healer...");
heroes.Add("Healer");

// Removing a hero
Console.WriteLine("Removing Mage...");
heroes.Remove("Mage");

// Is Healer in party?
Console.WriteLine();
Console.WriteLine($"Healer in party: {heroes.Contains("Healer")}");

// Sort and print list
heroes.Sort();
Console.WriteLine();
Console.WriteLine("Sorted Party:");
for(int i = 0; i < heroes.Count; i++)
{
    Console.WriteLine($"[{i}] {heroes[i]}");
}
