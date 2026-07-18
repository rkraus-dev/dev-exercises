string dirtyInput = "   Hello WORLD, welcome to C#!   ";
string cleaned = dirtyInput.Trim().ToLower();
bool doesContain = cleaned.Contains("world");

Console.WriteLine($"Does it contain the word \"World\"?: {doesContain}");

string replaced = cleaned.Replace("hello", "bonjour");
Console.WriteLine(replaced);

string[] splitted = cleaned.Split(" ");
Console.WriteLine($"Length: {splitted.Length}");
foreach (string word in splitted)
{
    Console.WriteLine(word);
}