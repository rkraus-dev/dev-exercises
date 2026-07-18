Console.WriteLine("--- Character Sheet ---");
Console.Write("Enter your hero's name: ");
string name = Console.ReadLine() ?? "Unknown";

Console.Write("Enter your level (1-10): ");
int level = 0;
while (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 10)
{
    Console.Write("Please enter a valid level (1-10): ");
}

int strength = 30;
double hp = 100.0;
bool isAlive = true;

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Strength: {strength}");
Console.WriteLine($"Is Alive: {isAlive}");
Console.WriteLine($"Total Damage: {strength * level}");
Console.WriteLine($"HP after attack {hp - (strength * 0.5):F2}");
