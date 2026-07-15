Hero hero1 = new Hero("Arthur", 25);
Hero hero2 = new Hero("Merlin", 47);
Hero hero3 = new Hero("Lancelot", 30);

hero1.Introduce();
hero2.Introduce();
hero3.Introduce();
Hero.PrintHeroCount();


class Hero
{
    private string _name;
    private int _age;
    private static int _heroCounter = 0;

    public Hero(string name, int age)
    {
        this._name = name;
        this._age = age;
        _heroCounter++;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {_name} and I am {_age} years old.");
    }

    public static void PrintHeroCount()
    {
        Console.WriteLine($"Total Heroes: {_heroCounter}");
    }

}