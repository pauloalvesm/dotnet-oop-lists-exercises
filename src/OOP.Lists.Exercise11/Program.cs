using OOP.Lists.Exercise11.Models;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Vehicle Simulation Start ---");
        Console.WriteLine("--------------------------------");

        Car myCar = new Car("Ford Mustang", 2024);

        Console.WriteLine("\n--- Car Actions ---");
        Console.WriteLine($"Initial State: {myCar}");

        myCar.Accelerate(30);
        myCar.Accelerate(45);
        myCar.Brake(20);

        Console.WriteLine($"Final State: {myCar}");

        Console.WriteLine("\n--------------------------------");

        Motorcycle myBike = new Motorcycle("Honda CBR", 2023);

        Console.WriteLine("\n--- Motorcycle Actions ---");
        Console.WriteLine($"Initial State: {myBike}");

        myBike.Accelerate(50);
        myBike.Accelerate(60);
        myBike.Brake(35);

        Console.WriteLine($"Final State: {myBike}");

        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("--- Vehicle Simulation End ---");
        
        Console.ReadKey();
    }
}