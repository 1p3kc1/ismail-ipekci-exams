using Odev13_Product.Models;

namespace Odev13_Product;

class Program
{
    static void Main(string[] args)
    {

List<Product> products = new List<Product>()
{
    new Product
    {
        ProductCode = "P1",
        Name = "Laptop",
        Category = "Elektronik",
        UnitPrice = 35000
    },

    new Product
    {
        ProductCode = "P2",
        Name = "Telefon",
        Category = "Elektronik",
        UnitPrice = 25000
    },

    new Product
    {
        ProductCode = "P3",
        Name = "Masa",
        Category = "Mobilya",
        UnitPrice = 5000
    },

    new Product
    {
        ProductCode = "P4",
        Name = "Klavye",
        Category = "Elektronik",
        UnitPrice = 1200
    }
};

foreach (Product product in products)
{
    if (product.Category == "Elektronik")
    {
        Console.WriteLine($"Kod: {product.ProductCode}");
        Console.WriteLine($"Ad: {product.Name}");
        Console.WriteLine($"Kategori: {product.Category}");
        Console.WriteLine($"Fiyat: {product.UnitPrice} TL");
        Console.WriteLine();
    }
}
    }
}
