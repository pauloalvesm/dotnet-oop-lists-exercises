using OOP.Lists.Exercise06.Models;

namespace OOP.Lists.Exercise06.Business;

public interface IProductManager
{
    List<Product> ListProducts();
    Product SearchProductByCode(int informedCode);
    void AddProduct(int code, string name, double price, int quantityInStock);
    void RemoveProduct(int informedCode);
}
