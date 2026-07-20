var solution = new Solution();

Console.WriteLine(solution.MergeAlternately("abcfg", "pqrs"));  
Console.WriteLine(solution.MergeAlternately("ab", "pqrs"));   
Console.WriteLine(solution.MergeAlternately("abcd", "pq"));  

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        string merged = "";

        int shorterLength;
        if (word1.Length < word2.Length)
        {
            shorterLength = word1.Length;
        }
        else
        {
            shorterLength = word2.Length;
        }

        for (int i = 0; i < shorterLength; i++)
        {
            merged += word1[i];
            merged += word2[i];
        }

        for (int i = shorterLength; i < word1.Length; i++)
        {
            merged += word1[i];
        }

        for (int i = shorterLength; i < word2.Length; i++)
        {
            merged += word2[i];
        }


        return merged;
    }
}