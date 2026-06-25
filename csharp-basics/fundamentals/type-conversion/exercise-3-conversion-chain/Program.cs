string rawMana = "9823.7";
double manaAsDouble = double.Parse(rawMana, System.Globalization.CultureInfo.InvariantCulture);
int manaAsInt = (int)manaAsDouble;
decimal manaValue = manaAsInt;

Console.WriteLine("=== Conversion Chain ===");
Console.WriteLine($"string → double: {manaAsDouble}");
Console.WriteLine($"double → int: {manaAsInt}");
Console.WriteLine($"int → decimal: {manaValue}");