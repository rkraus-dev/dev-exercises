// print array
string[] classes = { "Warrior", "Mage", "Archer" };
List<string> heroes = new List<string>();

// Filling list with array and output array
foreach (string starter in classes)
{
    Console.WriteLine(starter);
    heroes.Add(starter);
}

heroes.Add("Healer"); // add Hero
heroes.Remove("Mage");

Console.WriteLine();
Dictionary<string, int> quests = new Dictionary<string, int>();
foreach (string hero in heroes)
{
    quests.Add(hero, 0);
}

quests["Warrior"] += 2;
quests["Archer"] += 1;
quests["Healer"] += 1;

HashSet<string> cities = new HashSet<string>();
cities.Add("Henessys");
cities.Add("Riverdale");
Console.WriteLine($"Adding Riverdale (duplicate)... Success: {cities.Add("Riverdale")}");

// print all
// active heroes
Console.WriteLine("Heroes:");
foreach(string hero in heroes)
{
    Console.WriteLine(hero);
}

// Quest-Stats
Console.WriteLine();
Console.WriteLine("Quest-Stats:");
foreach(KeyValuePair<string,int> quest in quests)
{
    Console.WriteLine($"{quest.Key}: {quest.Value}");
}

//Citys
Console.WriteLine();
Console.WriteLine("Visited cities:");
foreach(string city in cities)
{
    Console.WriteLine(city);
}