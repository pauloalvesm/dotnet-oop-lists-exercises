using System.Globalization;
using OOP.Lists.Exercise03.Models;

namespace OOP.Lists.Exercise03.Business;

public class RealEstateBroker
{
    private List<RealEstate> realEstatesList = new List<RealEstate>();

    public void AddProperty(string address, double price, string type)
    {
        RealEstate realEstate = new RealEstate(address, type, price);
        realEstatesList.Add(realEstate);
        Console.WriteLine("\nReal estate successfully added!");
    }

    public void ChangePropertyPrice(string informedAddress, double newPrice)
    {
        RealEstate realEstate = realEstatesList.Find(p => p.Address == informedAddress);

        if (realEstate != null)
        {
            realEstate.Price = newPrice;
            Console.WriteLine("Real estate price successfully changed!");
        }
        else
        {
            Console.WriteLine("Real estate not found.");
        }
    }

    public void ListProperties()
    {
        Console.WriteLine("Available properties:");

        foreach (RealEstate realEstate in realEstatesList)
        {
            Console.WriteLine($"Address: {realEstate.Address}, Type: {realEstate.Type}, Price: R${realEstate.Price.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

    public double CalculateAveragePrice()
    {
        if (realEstatesList.Count == 0)
        {
            return 0;
        }

        double sumOfPrices = realEstatesList.Sum(realEstate => realEstate.Price);
        sumOfPrices.ToString("F2", CultureInfo.InvariantCulture);
        return sumOfPrices / realEstatesList.Count;
    }

}
