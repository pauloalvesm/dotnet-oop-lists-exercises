using OOP.Lists.Exercise02.Business;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Purchase Log *****");

        PurchaseLog log = new PurchaseLog();

        Console.WriteLine("Enter the purchase details: ");

        while (true)
        {
            Console.Write("Purchase date (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.Write("Product name: ");
                string product = Console.ReadLine();

                Console.Write("Purchase value: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    log.AddPurchase(date, product, value);
                }
                else
                {
                    Console.WriteLine("Invalid value. Make sure to enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date. Make sure to enter a date in YYYY-MM-DD format.");
            }

            Console.Write("Do you want to add another purchase? (Y/N): ");
            string answer = Console.ReadLine();

            if (answer.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }

        log.ListPurchases();

        Console.ReadKey();
    }
}