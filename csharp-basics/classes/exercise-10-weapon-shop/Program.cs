Weapon sword = new Weapon("Sword", 50, 100);
Weapon bow = new Weapon("Bow", 50, 80);

sword.DisplayInfo();
bow.DisplayInfo();
Console.WriteLine();
sword.ApplyDiscount(20);
sword.DisplayInfo();
bow.Damage = -20;

class Weapon
{
    // Fields
    private string _name;
    private int _damage;
    private double _price;

    // Properties
    public string Name
{
    get { return _name; }
    set { _name = value; }
}
    public int Damage
    {
        get { return _damage; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Invalid value!");
                _damage = 0;
            }
            else
            {
                _damage = value;
            }
        }
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Invalid value!");
                _price = 0;
            }
            else
            {
                _price = value;
            }
        }
    }

    // Constructor
    public Weapon(string name, int damage, int price)
    {
        Name = name;
        Damage = damage;
        Price = price;

    }

    //Methods
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name} | Damage: {Damage} | Price: {Price}");
    }

    public void ApplyDiscount(int percent)
    {
        Console.WriteLine($"Applying {percent}% discount to {Name}...");
        Price *= (100 - percent) / 100.0;

    }

}