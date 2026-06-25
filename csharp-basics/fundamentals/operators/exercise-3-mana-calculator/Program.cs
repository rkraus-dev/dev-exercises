int baseMana = 5000;
int level = 42;
bool isProdigy = true;

int totalMana = baseMana + (level * 150);
double manaCostPerSpell = totalMana / 5.0;

if (isProdigy)
    manaCostPerSpell *= 0.75;

int remainingMana = totalMana - ((int)manaCostPerSpell * 3);
bool isAboveHalf = remainingMana > (totalMana / 2);

Console.WriteLine("=== Mana Calculator ===");
Console.WriteLine($"Base Mana: {baseMana}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Is Prodigy: {isProdigy}");
Console.WriteLine();
Console.WriteLine("=== Results ===");
Console.WriteLine($"Total Mana: {totalMana}");
Console.WriteLine($"Cost per Spell: {manaCostPerSpell}");
Console.WriteLine($"Remaining Mana: {remainingMana}");
Console.WriteLine($"Above Half: {isAboveHalf}");
