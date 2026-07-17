Random rnd = new Random();
int damage;
int criticalHits = 0;

do
{
    // 5 Rounds
    for (int i = 1; i <= 5; i++)
    {
        damage = rnd.Next(0, 101);

        Console.Write($"Round {i}: {damage} - ");
        if (damage > 80)
        {
            Console.Write("Critical Hit!");
            criticalHits++;
        }
        else if (damage > 50)
        {
            Console.Write("Normal Hit!");
        }
        else
        {
            Console.Write("Weak Hit!");
        }

        Console.WriteLine();

    }

    Console.WriteLine();
    Console.WriteLine($"Critical Hits: {criticalHits}");

    string appraise = criticalHits switch
    {
        0 => "Defeated",
        1 or 2 => "Rookie",
        3 or 4 => "Elite",
        5 => "Legendary",
        _ => "Defeated"
    };

    Console.WriteLine($"Rank: {appraise}");

    string battleResult = criticalHits > 3 ? "Victory!" : "Defeat!";
    Console.WriteLine($"Result: {battleResult}");

    Console.WriteLine();
    Console.WriteLine("Play again? (y/n)?");
    string userInput = Console.ReadLine() ?? "n";
    if (userInput == "y")
    {
        criticalHits = 0;
        continue;
    }
    else
    {
        break;
    }

} while (true);