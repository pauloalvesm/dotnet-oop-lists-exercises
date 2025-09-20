using OOP.Lists.Exercise01.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Add and Remove Products *****");

        Console.WriteLine("Enter the product data: ");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Quantity in Stock: ");
        int quantityInStock = int.Parse(Console.ReadLine());

        Product product = new Product(name, price, quantityInStock);

        Console.WriteLine("----- Stock -----");

        Console.WriteLine();

        Console.Write("Add items to stock: ");
        int addItem = int.Parse(Console.ReadLine());

        product.AddItemToStock(addItem);

        Console.WriteLine();

        Console.Write("Remove items from stock: ");
        int removeItem = int.Parse(Console.ReadLine());

        product.RemoveItemFromStock(removeItem);

        Console.WriteLine();

        product.DisplayTotalStock();

        Console.ReadKey();
    }
}