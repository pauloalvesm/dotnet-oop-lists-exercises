namespace OOP.Lists.Exercise03.Models;

public class RealEstate
{
    public string Address { get; private set; }
    public string Type { get; private set; }
    public double Price { get; set; }

    public RealEstate(string address, string type, double price)
    {
        Address = address;
        Type = type;
        Price = price;
    }
}
