using OOP.Lists.Exercise10.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Inheritance Demonstration (Dog and Cat) *****\n");

        Console.WriteLine("--- Creating a Dog ---");
        Console.Write("Dog's Name: ");
        string dogName = Console.ReadLine();
        Console.Write("Dog's Age: ");
        int dogAge = int.Parse(Console.ReadLine());

        Dog myDog = new Dog(dogName, dogAge);

        Console.WriteLine("\n----- Dog Result -----");
        Console.WriteLine($"Name: {myDog.Name}");
        Console.WriteLine($"Species: {myDog.Species}");
        Console.WriteLine($"Age: {myDog.Age} years");
        myDog.MakeSound();

        Console.WriteLine("\n----------------------------------------------------");

        Console.WriteLine("\n--- Creating a Cat ---");
        Console.Write("Cat's Name: ");
        string catName = Console.ReadLine();
        Console.Write("Cat's Age: ");
        int catAge = int.Parse(Console.ReadLine());

        Cat myCat = new Cat(catName, catAge);

        Console.WriteLine("\n----- Cat Result -----");
        Console.WriteLine($"Name: {myCat.Name}");
        Console.WriteLine($"Species: {myCat.Species}");
        Console.WriteLine($"Age: {myCat.Age} years");
        myCat.MakeSound();

        Console.ReadKey();
    }
}