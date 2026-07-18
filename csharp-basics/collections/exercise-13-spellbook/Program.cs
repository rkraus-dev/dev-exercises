Dictionary<string, int> spells = new Dictionary<string, int>
{
    {"Fireball", 30},
    {"Ice Spike", 20},
    {"Thunder", 45},
    {"Heal", 15}
};

Console.WriteLine("Spells:");
foreach (KeyValuePair<string, int> spell in spells)
{
    Console.WriteLine($"{spell.Key}: {spell.Value} mana");
}

Console.WriteLine();
Console.WriteLine("Adding Meteor...");
spells.Add("Meteor", 60);
Console.WriteLine("Upgrading Fireball...");
spells["Fireball"] = 35;
Console.WriteLine();

Console.WriteLine($"Shadow in spellbook: {spells.ContainsKey("Shadow")}");
Console.WriteLine();

string mostExpensiveSpell = "";
int mostExpensiveMana = 0;
foreach (KeyValuePair<string,int> spell in spells)
{
    if(spell.Value > mostExpensiveMana)
    {
        mostExpensiveSpell = spell.Key;
        mostExpensiveMana = spell.Value;
    }
}
Console.WriteLine($"Most expensive spell: {mostExpensiveSpell} ({mostExpensiveMana} mana)");
Console.WriteLine();

Console.WriteLine("Updated Spells:");
foreach (KeyValuePair<string, int> spell in spells)
{
    Console.WriteLine($"{spell.Key}: {spell.Value} mana");
}