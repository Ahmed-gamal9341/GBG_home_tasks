abstract class vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public abstract double price { get; }

    public vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public abstract double CalculateRentalCost(int days);
    public virtual void DisplayInfo(string brand, string model)
    {
        Console.WriteLine($"Vehicle: {brand} {model}");
    }

}

class Car : vehicle
{
    int numberOfDoors;
    public override double price { get; }

    public Car(string brand, string model, double price, int numberOfDoors) : base(brand, model)
    {
        this.price = price;
        this.numberOfDoors = numberOfDoors;
    }

    public override double CalculateRentalCost(int days)
    {
        return price * days;
    }
}

class Motorcycle : vehicle
{
    string colour;
    public override double price { get; }

    public Motorcycle(string brand, string model, double price, string colour) : base(brand, model)
    {
        this.price = price;
        this.colour = colour;
    }

    public override double CalculateRentalCost(int days)
    {
        return price * days;
    }
}

class truck : vehicle
{
    double loadCapacity;
    public override double price { get; }

    public truck(string brand, string model, double price, double loadCapacity) : base(brand, model)
    {
        this.price = price;
        this.loadCapacity = loadCapacity;
    }

    public override double CalculateRentalCost(int days)
    {
        return price * days;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("hundyai", "elantera", 50, 4);
        Motorcycle motorcycle = new Motorcycle("Honda", "race", 30, "Red");
        truck truck = new truck("Ford", "na2l", 80, 1000);

        Console.WriteLine($"Car Rental Cost for 3 days: ${car.CalculateRentalCost(3)}");
        Console.WriteLine($"Motorcycle Rental Cost for 2 days: ${motorcycle.CalculateRentalCost(2)}");
        Console.WriteLine($"Truck Rental Cost for 5 days: ${truck.CalculateRentalCost(5)}");

        car.DisplayInfo(car.Brand, car.Model);
        motorcycle.DisplayInfo(motorcycle.Brand, motorcycle.Model);
        truck.DisplayInfo(truck.Brand, truck.Model);
    }
}