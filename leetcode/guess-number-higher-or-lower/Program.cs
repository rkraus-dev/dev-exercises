var solution = new Solution();
Console.WriteLine(solution.GuessNumber(10));
Console.WriteLine(solution.GuessNumber(1));
Console.WriteLine(solution.GuessNumber(2126753390));

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        // TODO – dein Ratespiel
        return 0;
    }
}

public class GuessGame
{
    private int pick = 6;

    protected int guess(int num)
    {
        if (num > pick) return -1;
        if (num < pick) return 1;
        return 0;
    }
}