using OOP.Lists.Exercise03.Business;
using OOP.Lists.Exercise03.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Real Estate Brokerage *****");

        RealEstateBroker broker = new RealEstateBroker();

        while (true)
        {
            int option;

            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a property");
            Console.WriteLine("2. Change a property's price");
            Console.WriteLine("3. List of properties");
            Console.WriteLine("4. Calculate the average price of properties");
            Console.WriteLine("5. Exit");
            Console.Write("\nChosen Option: ");

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Please try again.");
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.Write("Property address: ");
                    string address = Console.ReadLine();
                    Console.Write("Property price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Property type: ");
                    string type = Console.ReadLine();
                    broker.AddProperty(address, price, type);
                    break;

                case 2:
                    Console.Write("Address of the property to be changed: ");
                    string addressToChange = Console.ReadLine();
                    Console.Write("New price: ");
                    double newPrice = double.Parse(Console.ReadLine());
                    broker.ChangePropertyPrice(addressToChange, newPrice);
                    break;

                case 3:
                    broker.ListProperties();
                    break;

                case 4:
                    double averagePrice = broker.CalculateAveragePrice();
                    Console.WriteLine($"The average price of the properties is: R${averagePrice}");
                    break;

                case 5:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}