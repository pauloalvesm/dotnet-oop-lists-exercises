namespace OOP.Lists.Exercise08.Models;

public class Product
{
    private string _name;
    private Manufacturer _manufacturer;
    private double _price;

    public Product(string name, Manufacturer manufacturer, double price)
    {
        _name = name;
        _manufacturer = manufacturer;
        _price = price;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Error: The Product name cannot be null or empty.");
            }

            _name = value;
        }
    }

    public Manufacturer Manufacturer
    {
        get { return _manufacturer; }
        set { _manufacturer = value; }
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error: The price must be positive.");
            }

            _price = value;
        }
    }
}
