namespace OOP.Lists.Exercise06.Models;

public class Product
{
    public int Code { get; private set; }
    public string Name { get; private set; }
    public double Price { get; private set; }
    public int QuantityInStock { get; private set; }

    public Product(int code, string name, double price, int quantityInStock)
    {
        Code = code;
        Name = name;
        Price = price;
        QuantityInStock = quantityInStock;
    }
}
