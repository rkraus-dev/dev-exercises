Person person1 = new Person("Arthur", 25);
person1.Introduce();
person1.Age = 26;
Console.WriteLine($"{person1.Name} is now {person1.Age} years old.");
person1.Age = -3;

class Person
{
    private string _name;
    private int _age;
    public string Name
{
    get { return _name; }
    set { _name = value; }
}
    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            if (value < 0)
            {
                _age = 0;
                Console.WriteLine("Invalid Age!");
            }
            else
            {
                _age = value;
            }
        }

    }

    public Person(string name, int age)
    {
        Age = age;
        Name = name;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }

}