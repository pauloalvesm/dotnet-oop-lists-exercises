namespace OOP.Lists.Exercise08.Models;

public class Manufacturer
{
    private string _name;
    private string _address;
    private string _city;

    public Manufacturer(string name, string address, string city)
    {
        _name = name;
        _address = address;
        _city = city;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Error: The Manufacturer's name cannot be null or empty.");
            }

            _name = value;
        }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
}
