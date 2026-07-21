Console.WriteLine(new Solution(6).GuessNumber(10));
Console.WriteLine(new Solution(1).GuessNumber(1));
Console.WriteLine(new Solution(1702766719).GuessNumber(2126753390));

public class Solution : GuessGame
{
    public Solution(int pick) : base(pick) { }
    public int GuessNumber(int n)
    {
        int low = 1;
        int high = n;
        while (true)
        {
            int mid = low + (high - low) / 2;
            int result = guess(mid);
            if (result == 0)
            {
                return mid;
            }
            else if (result == -1)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
    }
}

public class GuessGame
{
    private int pick;

    public GuessGame(int pick)
    {
        this.pick = pick;
    }

    protected int guess(int num)
    {
        if (num > pick) return -1;
        if (num < pick) return 1;
        return 0;
    }
}