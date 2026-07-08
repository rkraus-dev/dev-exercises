int[] attackStats = { 42, 17, 85, 3, 66, 29 };
bool hasSwitched = false; // tracks if numbers have been switched
int num = 0;

// print original
Console.Write("Original: ");
foreach(int attack in attackStats)
{
    Console.Write(attack + " ");
}

// Sort array
while (!hasSwitched)
{
    hasSwitched = true; // assume no switches will be made
    for (int i = 0; i < attackStats.Length - 1; i++)
    {
        if (attackStats[i] > attackStats[i + 1])
        {
            num = attackStats[i];
            attackStats[i] = attackStats[i + 1];
            attackStats[i + 1] = num;
            hasSwitched = false;
        }
    }
}

// Print sorted array
Console.WriteLine();
Console.Write("Sorted: ");
foreach(int attack in attackStats)
{
    Console.Write(attack + " ");
}

