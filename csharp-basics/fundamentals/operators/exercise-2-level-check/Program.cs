int level = 75;
double mana = 12000;
bool isReincarnated = true;


Console.WriteLine("=== Level Check ===");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Mana: {mana}");
Console.WriteLine($"Is Reincarnated: {isReincarnated}");
Console.WriteLine();

Console.WriteLine("=== Checks ===");
Console.WriteLine($"Level > 50: {level > 50}");
Console.WriteLine($"Mana between 5k-20k: {mana > 5000 && mana < 20000}");
Console.WriteLine($"Reincarnated AND Lv > 50: {isReincarnated && level > 50}");
Console.WriteLine($"NOT Reincarnated or Mana < 1000: {!isReincarnated || mana < 1000}");