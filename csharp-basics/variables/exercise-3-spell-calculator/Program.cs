string name = "Rudeus Greyrat";
decimal baseMana = 10000;
double manaMultiplikator = 1.75;
int spellCount = 5;
bool isProdigy = true;
decimal prodigyDiscount = 0;

decimal effectiveMana = baseMana * (decimal)manaMultiplikator;
decimal manaPerSpell = effectiveMana / spellCount;
decimal finalCostPerSpell = manaPerSpell;

if (isProdigy)
{
    prodigyDiscount = manaPerSpell * 0.2m;
    finalCostPerSpell = manaPerSpell * 0.8m;
}

Console.WriteLine("=== Spell Calculator ===");
Console.WriteLine($"Caster: {name}");
Console.WriteLine($"Base Mana: {baseMana}");
Console.WriteLine($"Multiplier: {manaMultiplikator}");
Console.WriteLine($"Spell Count: {spellCount}");
Console.WriteLine($"Is Prodigy: {isProdigy}");
Console.WriteLine();
Console.WriteLine("=== Results ===");
Console.WriteLine($"Effective Mana: {effectiveMana:F2}");
Console.WriteLine($"Mana per Spell: {manaPerSpell:F2}");
Console.WriteLine($"Prodigy Discount: -{prodigyDiscount:F2}");
Console.WriteLine($"Final Cost per Spell: {finalCostPerSpell:F2}");