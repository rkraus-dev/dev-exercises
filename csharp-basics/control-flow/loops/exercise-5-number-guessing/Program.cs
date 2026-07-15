int goal = 7;
int counter = 0;
bool hasGuessed = false;

do
{
    Console.Write("Guess a number between 1 and 10: ");

    //user input
    string input = Console.ReadLine() ?? "";
    // check if input is null
    if (!int.TryParse(input, out int userGuess))
    {
        Console.WriteLine("Please enter a valid number!");
        Console.WriteLine();
    }
    else if (userGuess == goal)
    {
        Console.WriteLine($"Correct! You guessed it in {counter} attempts.");
    }
    else if (userGuess >= 1 && userGuess <= 10)
    {
        if (userGuess > goal)
        {
            Console.WriteLine("Too high!");
        }
        else if (userGuess < goal)
        {
            Console.WriteLine("Too low!");
        }
    }
    else
    {
        Console.WriteLine("Please enter a number between 1 and 10!");
        Console.WriteLine();
    }

    counter++;

} while (!hasGuessed);




