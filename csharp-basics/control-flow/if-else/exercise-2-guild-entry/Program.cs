int level = 15;
bool hasWeapon = true;
string guildName = "Shadow Phantoms";

if (level >= 20 && hasWeapon)
{
    Console.WriteLine($"Welcome to {guildName}, adventurer!");
}
else if (level >= 20 && !hasWeapon)
{
    Console.WriteLine("You meet the level requirement, but you need a weapon.");
}
else if (level < 20 && hasWeapon)
{
    Console.WriteLine("Your weapon is impressive, but you need to reach level 20.");
}
else
{
    Console.WriteLine("You are not ready. Train harder and come back.");
}