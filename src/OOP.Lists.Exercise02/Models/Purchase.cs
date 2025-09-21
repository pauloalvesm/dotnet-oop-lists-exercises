namespace OOP.Lists.Exercise02.Models;

public class Purchase
{
    public DateTime Date { get; set; }
    public string Product { get; set; }
    public double Value { get; set; }

    public Purchase(DateTime date, string product, double value)
    {
        Date = date;
        Product = product;
        Value = value;
    }
}
