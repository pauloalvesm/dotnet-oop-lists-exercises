using System.Globalization;
using OOP.Lists.Exercise08.Models;

namespace OOP.Lists.Exercise08.Business
{
    public static class Utility
    {
        public static List<Manufacturer> CreateSampleManufacturers()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>
            {
                new Manufacturer("Sony", "1000 Sony Dr", "San Diego"),
                new Manufacturer("Nintendo", "4600 150th Ave NE", "Redmond"),
                new Manufacturer("Microsoft", "One Microsoft Way", "Redmond"),
                new Manufacturer("Apple", "Apple Park Way", "Cupertino")
            };

            return manufacturers;
        }

        public static List<Product> CreateSampleProducts(List<Manufacturer> manufacturers)
        {
            Manufacturer sony = manufacturers.FirstOrDefault(m => m.Name == "Sony");
            Manufacturer nintendo = manufacturers.FirstOrDefault(m => m.Name == "Nintendo");
            Manufacturer microsoft = manufacturers.FirstOrDefault(m => m.Name == "Microsoft");
            Manufacturer apple = manufacturers.FirstOrDefault(m => m.Name == "Apple");

            List<Product> products = new List<Product>
            {
                new Product("PlayStation 5", sony ?? new Manufacturer("Unknown", "", ""), 499.99),
                new Product("Nintendo Switch OLED", nintendo ?? new Manufacturer("Unknown", "", ""), 349.99),
                new Product("Xbox Series X", microsoft ?? new Manufacturer("Unknown", "", ""), 499.99),
                new Product("iPhone 15 Pro", apple ?? new Manufacturer("Unknown", "", ""), 999.00),
                new Product("MacBook Air M2", apple ?? new Manufacturer("Unknown", "", ""), 1199.00),
                new Product("Sony WH-1000XM5", sony ?? new Manufacturer("Unknown", "", ""), 399.99)
            };

            return products;
        }

        public static void DisplayManufacturers(List<Manufacturer> manufacturers)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("  LIST OF REGISTERED MANUFACTURERS");
            Console.WriteLine("=================================");

            if (manufacturers == null || manufacturers.Count == 0)
            {
                Console.WriteLine("No manufacturers in the list.");
                return;
            }

            foreach (var m in manufacturers)
            {
                Console.WriteLine($"- Name: {m.Name,-15} | City: {m.City,-10} | Address: {m.Address}");
            }
        }

        public static void DisplayProducts(List<Product> products)
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("  LIST OF REGISTERED PRODUCTS");
            Console.WriteLine("=============================");

            if (products == null || products.Count == 0)
            {
                Console.WriteLine("No products in the list.");
                return;
            }

            foreach (var p in products.OrderBy(p => p.Price))
            {
                Console.WriteLine($"- Product: {p.Name,-25} | Manufacturer: {p.Manufacturer.Name,-15} | Price: ${p.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
