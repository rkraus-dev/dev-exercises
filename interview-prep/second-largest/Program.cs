int[] scores1 = { 34, 78, 91, 78, 12, 56 };
int[] scores2 = { 90, 90, 75 };
int[] scores3 = { 7, 7, 7 };

Console.WriteLine("=== Tournament of Silberklamm ===");
PrintTournamentResult(scores1);
PrintTournamentResult(scores2);
PrintTournamentResult(scores3);

int? FindSecondHighest(int[] scores)
{
    if (scores == null || scores.Length < 2)
    {
        return null;
    }

    int? highest = null;
    int? secondHighest = null;

    foreach (int score in scores)
    {
        if (highest == null || score > highest)
        {
            secondHighest = highest;
            highest = score;
        }
        else if (score < highest && (secondHighest == null || score > secondHighest))
        {
            secondHighest = score;
        }
    }

    return secondHighest;
}

void PrintTournamentResult(int[] scores)
{
    Console.WriteLine($"Scores: {string.Join(", ", scores)}");

    int? secondHighest = FindSecondHighest(scores);

    if (secondHighest == null)
    {
        Console.WriteLine("No second place - the Silver Sword stays in the vault!");
    }
    else
    {
        int champion = FindHighest(scores);
        Console.WriteLine($"Champion: {champion} | Silver Sword goes to: {secondHighest}");
    }

    Console.WriteLine();
}

int FindHighest(int[] scores)
{
    int highest = scores[0]; 

    foreach (int score in scores)
    {
        if (score > highest)
        {
            highest = score;
        }
    }

    return highest;
}