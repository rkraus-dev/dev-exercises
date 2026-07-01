class Program
{
    static void DisplayInfo(string name)
    {
        Console.WriteLine($"Hey, my name is {name}");
    }

    static void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Hey, my name is {name}, im {age} years old.");
    }

    static void DisplayInfo(string name, int age, string job)
    {
        Console.WriteLine($"Hey, my name is {name}, im {age} years old and my job is {job}");
    }

    static void Main()
    {
        DisplayInfo("Robert");
        DisplayInfo("Robert", 28);
        DisplayInfo("Robert", 28, "Developer");
    }
}