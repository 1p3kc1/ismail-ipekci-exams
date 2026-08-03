using System;

namespace Odev22_Constructor_Product.Models;

public class Product

{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public Product(string name)
    {
        Name = name;
    }
}

