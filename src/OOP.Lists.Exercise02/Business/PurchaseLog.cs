using System.Globalization;
using OOP.Lists.Exercise02.Models;

namespace OOP.Lists.Exercise02.Business
{
    public class PurchaseLog
    {
        private List<Purchase> purchases;

        public PurchaseLog()
        {
            purchases = new List<Purchase>();
        }

        public void AddPurchase(DateTime date, string product, double value)
        {
            Purchase newPurchase = new Purchase(date, product, value);
            purchases.Add(newPurchase);
        }

        public void ListPurchases()
        {
            Console.WriteLine("\n----- List of Purchases: -----");

            foreach (Purchase purchase in purchases)
            {
                Console.WriteLine($"Date: {purchase.Date}, Product: {purchase.Product}, Value: {purchase.Value.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
