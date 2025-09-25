using OOP.Lists.Exercise06.Business;
using OOP.Lists.Exercise06.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Product Manager *****");

        ProductManager manager = new ProductManager();

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1 - Add Product");
            Console.WriteLine("2 - List Products");
            Console.WriteLine("3 - Search Product by Code");
            Console.WriteLine("4 - Remove Product");
            Console.WriteLine("5 - Exit");

            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the product code: ");
                    int code = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Quantity in Stock: ");
                    int quantityInStock = int.Parse(Console.ReadLine());

                    manager.AddProduct(code, name, price, quantityInStock);
                    Console.WriteLine("Product added successfully.");
                    break;

                case 2:
                    Console.WriteLine("----- Product List -----");
                    var productList = manager.ListProducts();
                    foreach (var product in productList)
                    {
                        Console.WriteLine($"Code: {product.Code}, Name: {product.Name}, Price: {product.Price:C}, Quantity in Stock: {product.QuantityInStock}");
                    }
                    break;

                case 3:
                    Console.Write("Enter the code of the product to search: ");
                    int searchCode = int.Parse(Console.ReadLine());

                    Product searchedProduct = manager.SearchProductByCode(searchCode);

                    if (searchedProduct != null)
                    {
                        Console.WriteLine($"Product found: Code: {searchedProduct.Code}, Name: {searchedProduct.Name}, Price: {searchedProduct.Price:C}, Quantity in Stock: {searchedProduct.QuantityInStock}");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                    break;

                case 4:
                    Console.Write("Enter the code of the product to remove: ");
                    int removeCode = int.Parse(Console.ReadLine());

                    manager.RemoveProduct(removeCode);
                    Console.WriteLine("Product removed successfully.");
                    break;

                case 5:
                    Console.WriteLine("Shutting down the program.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}