class Program
{
    static void Main()
    {
        Car car = new Car
        {
            Brand = "Toyota",
            Speed = 120,
            Seats = 5
        };

        Motorcycle bike = new Motorcycle
        {
            Brand = "Yamaha",
            Speed = 100,
            HasCarrier = true
        };

        // Base class methods – reuse
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}