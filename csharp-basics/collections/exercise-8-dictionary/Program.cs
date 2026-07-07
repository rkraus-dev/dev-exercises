Dictionary<string, int> skills = new Dictionary<string, int>()
{
    {"Fireball", 3},
    {"Dodge", 1},
    {"Shield Bash", 2}
};

// Print skills
Console.WriteLine("Skills:");
foreach (KeyValuePair<string, int> skill in skills)
{
    Console.WriteLine($"{skill.Key}: {skill.Value}");
}

// Add Heal
Console.WriteLine();
Console.WriteLine("Adding Heal...");
skills.Add("Heal", 1);

// Upgrade Fireball
Console.WriteLine("Upgrading Fireball...");
skills["Fireball"]++;

// Check if Assassin
Console.WriteLine();
Console.WriteLine($"Assassin in skill tree: {skills.ContainsKey("Assassin")}");

// Remove Doge
Console.WriteLine();
Console.WriteLine("Removing Dodge...");
skills.Remove("Dodge");

// Print updated skills
Console.WriteLine();
foreach (KeyValuePair<string, int> skill in skills)
{
    Console.WriteLine($"{skill.Key}: {skill.Value}");
}