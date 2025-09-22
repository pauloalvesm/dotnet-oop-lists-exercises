namespace OOP.Lists.Exercise01.Models;

public class Product
{
    private string _name;
    private double _price;
    private int _quantityInStock;

    public string Name 
    {
        get { return _name; }
        set 
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _name = value;
            }
            else 
            {
                Console.WriteLine("The name cannot be empty!");
            }
        }
    }

    public double Price 
    {
        get { return _price; }
        set 
        {
            if (value > 0)
            {
                _price = value;
            }
            else 
            {
                Console.WriteLine("The price must be greater than zero!");
            }
        }
    }

    public int QuantityInStock
    {
        get { return _quantityInStock; }
    }

    public Product(string name, double price, int quantityInStock)
    {
        Name = name;
        Price = price;
        _quantityInStock = quantityInStock;
    }

    public void AddItemToStock(int quantity)
    {
        if (quantity > 0)
        {
            _quantityInStock += quantity;
            Console.WriteLine($"{quantity} units of {_name} added to stock. New stock: {_quantityInStock} units.");
        }
        else
        {
            Console.WriteLine("The quantity to be added must be greater than zero!");
        }
    }

    public void RemoveItemFromStock(int quantity)
    {
        if (quantity > 0 && quantity <= _quantityInStock)
        {
            _quantityInStock -= quantity;
            Console.WriteLine($"{quantity} units of {_name} removed from stock. New stock: {_quantityInStock} units.");
        }
        else if (quantity > _quantityInStock)
        {
            Console.WriteLine("The quantity to be removed is greater than the quantity in stock.");
        }
        else
        {
            Console.WriteLine("The quantity to be removed must be greater than zero!");
        }
    }

    public void DisplayTotalStock()
    {
        Console.WriteLine($"Current total stock of {_name}: {_quantityInStock} units.");
    }
}
