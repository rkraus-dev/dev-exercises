string[] weapons = { "Sword", "Shield", "Bow", "Axe", "Dagger" };
Console.WriteLine("Inventory:");
for (int i = 0; i < weapons.Length; i++)
{
    Console.WriteLine($"[{i}] {weapons[i]}");
}

Console.WriteLine();

// Find the strongest weapon
int length = 0;
string strongestWeapon = "";
foreach (string weapon in weapons)
{
    if (weapon.Length > length)
    {
        length = weapon.Length;
        strongestWeapon = weapon;
    }

}

Console.WriteLine($"Strongest Weapon: {strongestWeapon} ({length} chars)");
Console.WriteLine();

// Replace one weapon 
Console.WriteLine("Replacing slot 2...");
Console.WriteLine();
weapons[2] = "Crossbow";
Console.WriteLine("Updated Inventory: ");
for (int i = 0; i < weapons.Length; i++)
{
    Console.WriteLine($"[{i}] {weapons[i]}");
}