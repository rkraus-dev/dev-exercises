Circle c1 = new Circle("Circle", 12.2);
c1.PrintInfo();

Rectangle r1 = new Rectangle("Rectangle", 3, 4);
r1.PrintInfo();

abstract class Shape
{
    public string Name { get; set; }

    public Shape(string name)
    {
        Name = name;
    }

    public abstract double CalculateArea();

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Area: {CalculateArea()}");
    }

}

class Circle : Shape
{
    public double Radius { get; set; }
    public const double pi = 3.14;

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return pi * (Radius * Radius);
    }
}

class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public Rectangle(string name, double height, double width) : base(name)
    {
        Height = height;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Height * Width;
    }

}