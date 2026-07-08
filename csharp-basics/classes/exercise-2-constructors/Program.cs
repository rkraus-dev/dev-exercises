Item itm1 = new Item("Sword", 54, 10);
itm1.PrintInfo();

Item itm2 = new("Wand");
itm2.PrintInfo();


class Item
{
    private string name;
    private int damage;
    private int resistance;

    public Item(string name, int damage, int resistance)
    {
        this.name = name;
        this.damage = damage;
        this.resistance = resistance;
    }

    public Item(string name) : this(name, 10, 5)
    {
        
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}, Damage: {damage}, Resistance: {resistance}");
    }
}