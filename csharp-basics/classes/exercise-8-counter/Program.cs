Hero hero1 = new Hero("Arthur");
Console.WriteLine($"{hero1.Name} joined the guild.");
Hero.PrintCount();

Hero hero2 = new Hero("Merlin");
Console.WriteLine($"{hero2.Name} joined the guild.");
Hero.PrintCount();

Hero hero3 = new Hero("Lancelot");
Console.WriteLine($"{hero3.Name} joined the guild.");
Hero.PrintCount();

class Hero
{
    private string _name;
    private static int _heroCount = 0;

    public string Name
    {
        get { return _name;}
    }

    public static int HeroCount
    {
        get{ return _heroCount;}
    }

    public Hero(string name)
    {
        _name = name;
        _heroCount++;
        
    }

    public static void PrintCount()
{
    Console.WriteLine($"Total heroes: {_heroCount}");
}

}