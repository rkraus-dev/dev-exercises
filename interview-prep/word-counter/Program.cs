string userInput = "";
bool isValid = false;

// User Input
do
{
    Console.Write("Please enter a sentence: ");
    userInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.WriteLine("Please enter a valid input!");
    }
    else
    {
        isValid = true;
    }

} while (!isValid);

// Count words
Dictionary<string, int> words = new Dictionary<string, int>();
string[] splitInput = userInput.Trim().ToLower().Split(" ");

foreach (string word in splitInput)
{
    if (words.ContainsKey(word))
    {
        words[word]++;
    }
    else
    {
        words[word] = 1;
    }
}

HashSet<string> duplicates = new HashSet<string>();
foreach (KeyValuePair<string, int> word in words)
{
    if (word.Value > 1)
    {
        duplicates.Add(word.Key);
    }
}

// Print Word count
Console.WriteLine("Word Counts:");
foreach (KeyValuePair<string, int> word in words)
{
    Console.WriteLine($"{word.Key}: {word.Value}");
}

// Print duplicates
Console.WriteLine(); // Space between word count and duplicates
Console.WriteLine("Duplicates:");
foreach (string duplicate in duplicates)
{
    Console.WriteLine(duplicate);
}