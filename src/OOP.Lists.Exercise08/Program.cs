using OOP.Lists.Exercise08.Business;
using OOP.Lists.Exercise08.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Products and Manufacturers *****");

        try
        {
            List<Manufacturer> manufacturers = Utility.CreateSampleManufacturers();

            Utility.DisplayManufacturers(manufacturers);

            List<Product> products = Utility.CreateSampleProducts(manufacturers);

            Utility.DisplayProducts(products);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn error occurred during execution: {ex.Message}");
        }

        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("Execution complete. Press any key to exit...");
        Console.ReadKey();
    }
}