
Character c1 = new Character();
c1.SetName("Rudeus");
c1.SetLevel(27);
c1.SetHealth(100);
c1.PrintInfo();

Character c2 = new Character();
c2.SetName("Elsa");
c2.SetLevel(20);
c2.SetHealth(100);
c2.PrintInfo();

class Character
{
    private string name;
    private int level;
    private int health;

    public void SetName(string newName)
    {
        name = newName;
    }

    public void SetLevel(int newLevel)
    {
        level = newLevel;
    }

    public void SetHealth(int newHealth)
    {
        health = newHealth;
    }


    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}, Level: {level}, Health: {health}");
    }
}

