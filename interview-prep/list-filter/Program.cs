// Part 1
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
List<int> evenNumbers = new List<int>();

Console.Write("Numbers:  ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
}

Console.WriteLine();
Console.Write("Even numbers:  ");
foreach (int number in evenNumbers)
{
    Console.Write(number + " ");
}

// Part 2
List<string> items = new List<string> { "Sword", "Shield", "Bow", "Axe", "Crossbow", "Dagger" };
List<string> longItems = new List<string>();

Console.WriteLine();
Console.WriteLine();
Console.Write("Items:  ");
foreach (string item in items)
{
    Console.Write(item + " ");
    if (item.Length > 5 )
    {
        longItems.Add(item);
    }
}

Console.WriteLine();
Console.Write("Long items:  ");
foreach(string item in longItems)
{
    Console.Write(item + " ");
}