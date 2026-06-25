string mana = "9823.7";
double manaDouble = double.Parse(mana);
int manaInt = (int)manaDouble;
decimal manaDeci = manaInt;

Console.WriteLine("=== Conversion Chain ===");
Console.WriteLine($"string → double: {manaDouble}");
Console.WriteLine($"double → int: {manaInt}");
Console.WriteLine($"int → decimal: {manaDeci}");