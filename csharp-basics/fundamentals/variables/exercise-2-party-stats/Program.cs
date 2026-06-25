string nameMember1 = "Rudeus Greyrat";
int levelMember1 = 42;
decimal manaMember1 = 9823.5m;

string nameMember2 = "Eris Boreas";
int levelMember2 = 38;
decimal manaMember2 = 4200.0m;

string nameMember3 = "Roxy Migurdia";
int levelMember3 = 55;
decimal manaMember3 = 15000.0m;

int avgLevel = (levelMember1 + levelMember2 + levelMember3) / 3;
decimal avgMana = (manaMember1 + manaMember2 + manaMember3) / 3;

Console.WriteLine("=== Party Stats ===");
Console.WriteLine($"Member 1: {nameMember1}     | Level: {levelMember1} | Mana: {manaMember1}");
Console.WriteLine($"Member 2: {nameMember2}     | Level: {levelMember2} | Mana: {manaMember2}");
Console.WriteLine($"Member 3: {nameMember3}     | Level: {levelMember3} | Mana: {manaMember3}");
Console.WriteLine();
Console.WriteLine("=== Party Average ===");
Console.WriteLine($"Avg Level: {avgLevel}");
Console.WriteLine($"Avg Mana:  {avgMana}");

