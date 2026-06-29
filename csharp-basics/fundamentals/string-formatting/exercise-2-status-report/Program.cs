string name = "Kirito";
double maxHp = 100;
double currentHp = 85.5;
double gold = 1500.75;
double playTime = 4250.0;
string savePath = @"C:\SAO\Players\Kirito\save.dat";

Console.WriteLine("=== Status Report ===");
Console.WriteLine($"Name: {name, -25}");
Console.WriteLine($"HP: {(currentHp / maxHp * 100):F1}%");
Console.WriteLine($"Gold: {gold:C}");
Console.WriteLine($"Play Time: {playTime:N1} hrs");
Console.WriteLine($"Save Path: {savePath}");