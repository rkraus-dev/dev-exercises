int level = 25;
bool hasGuildBadge = true;
bool isBlacklisted = false;
string dungeonName = "Abyss of Eternity";

if (isBlacklisted)
{
    Console.WriteLine($"You are banned from {dungeonName}. Leave immediately.");
}
else if (level >= 30 && hasGuildBadge)
{
    Console.WriteLine($"Access granted. Welcome to {dungeonName}.");
}
else if (level >= 30 && !hasGuildBadge)
{
    Console.WriteLine("Your level is sufficient, but you need a guild badge.");
}
else if (level >= 20 && hasGuildBadge)
{
    Console.WriteLine($"You may enter {dungeonName} with an escort only.");
}
else
{
    Console.WriteLine($"You are not worthy of {dungeonName}. Come back stronger.");
}