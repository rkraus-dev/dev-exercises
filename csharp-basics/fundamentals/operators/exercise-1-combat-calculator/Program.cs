int attackPower = 150;
double manaMultiplier = 1.5;
int defense = 100;
bool isElite = true;

Console.WriteLine("=== Combat Calculator ===");
Console.WriteLine($"Attack Power: {attackPower}");
Console.WriteLine($"Mana Multiplier: {manaMultiplier}");
Console.WriteLine($"Defense: {defense}");
Console.WriteLine($"Is Elite: {isElite}");
Console.WriteLine("");

if (isElite)
    defense *= 2;

double rawDamage = attackPower * manaMultiplier;
int finalDamage = (int)rawDamage - defense;

Console.WriteLine("=== Results ===");
Console.WriteLine($"Raw Damage: {rawDamage}");
Console.WriteLine($"Final Damage: {finalDamage}");
Console.WriteLine($"Victory: {finalDamage > 0}");
