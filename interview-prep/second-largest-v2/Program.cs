int[] gems1 = { 120, 870, 450, 870, 300 };
int[] gems2 = { 500, 500, 320 };
int[] gems3 = { 999 };

Console.WriteLine("=== Vault of Vorgash ===");
PrintVaultResult(gems1);
Console.WriteLine();
PrintVaultResult(gems2);
Console.WriteLine();
PrintVaultResult(gems3);

void PrintVaultResult(int[] gems)
{
    Console.WriteLine($"Gems: {string.Join(", ", gems)}");

    int? second = FindSecondMostValuable(gems, out int? cursedGem);

    if (second == null)
    {
        Console.WriteLine("Too risky - the guild leaves empty-handed!");
    }
    else
    {
        Console.WriteLine($"Cursed gem: {cursedGem} | The guild takes: {second}");
    }
}

int? FindSecondMostValuable(int[] gems, out int? cursedGem)
{
    cursedGem = null;

    // guard: no array or not enough gems for a second place
    if (gems == null || gems.Length < 2)
    {
        return null;
    }

    int? highest = null;
    int? second = null;

    foreach (int gem in gems)
    {
        if (highest == null || gem > highest)
        {
            second = highest;   // old champion drops down to second
            highest = gem;
        }
        else if (gem < highest && (second == null || gem > second))
        {
            second = gem;       // fits between second and highest
        }
        // gem == highest -> duplicate of the champion, ignore
    }

    cursedGem = highest;
    return second;
}