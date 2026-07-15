Car car1 = new Car("BMW", 230, 4);
car1.Describe();

Motorcycle  bike1 = new Motorcycle ("Duccati", 240, false);
bike1.Describe();


class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"Brandname: {Brand}, Speed: {Speed} kmh");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, int speed, int numberOfDoors) : base(brand, speed)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"The Car have {NumberOfDoors} Doors");
    }

}

class Motorcycle   : Vehicle
{
    public bool HasSideCar{ get; set;}

    public Motorcycle (string brand, int speed, bool hasSideCar) : base(brand, speed)
    {
        HasSideCar = hasSideCar;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"Does Motorcylce has a sidecar?: {HasSideCar}");
    }
}