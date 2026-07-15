Console.Write("Enter a word: ");
string input = Console.ReadLine() ?? "";
string userInput = input.Trim().ToLower();
int length = userInput.Length;
int middle = userInput.Length / 2;
bool isPalindrom = true;

for (int i = 0; i < middle; i++)
{
    length--;
    if (userInput[i] != userInput[length])
    {
        isPalindrom = false;
        break;
    }

}

if (isPalindrom)
    Console.WriteLine($"{userInput} is a palindrome!");
else
    Console.WriteLine($"{userInput} is not a palindrome!");