using OOP.Lists.Exercise06.Models;

namespace OOP.Lists.Exercise06.Business;

public class ProductManager : IProductManager
{
    private List<Product> productList = new List<Product>();

    public ProductManager()
    {
        productList = new List<Product>();
    }

    public List<Product> ListProducts()
    {
        return productList;
    }

    public Product SearchProductByCode(int informedCode)
    {
        return productList.Find(p => p.Code == informedCode);
    }

    public void AddProduct(int code, string name, double price, int quantityInStock)
    {
        Product newProduct = new Product(code, name, price, quantityInStock);
        productList.Add(newProduct);
    }

    public void RemoveProduct(int informedCode)
    {
        Product productToRemove = productList.Find(p => p.Code == informedCode);

        if (productToRemove != null)
        {
            productList.Remove(productToRemove);
        }
    }
}
