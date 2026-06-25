double mana = 9823.7;
int manaInt = (int)mana;

string level = "42";
int levelInt = int.Parse(level);

bool isProdigy = true;
int isProdigyInt = Convert.ToInt32(isProdigy);

Console.WriteLine("=== Type Conversion Demo ===");
Console.WriteLine($"[Cast] double {mana}  → int {manaInt}");
Console.WriteLine($"[Parse] string \"{level}\"  → int {levelInt}");
Console.WriteLine($"[Convert] bool {isProdigy}  → int {isProdigyInt}");

