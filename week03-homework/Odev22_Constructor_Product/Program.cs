using Odev22_Constructor_Product.Models;

Product product1 = new Product("Laptop");
product1.Id = 1;
product1.Price = 35000;

Product product2 = new Product("Telefon");
product2.Id = 2;
product2.Price = 25000;

Product product3 = new Product("Klavye");
product3.Id = 3;
product3.Price = 1200;

Console.WriteLine($"Ürün: {product1.Name}");
Console.WriteLine($"Fiyat: {product1.Price}");

Console.WriteLine();

Console.WriteLine($"Ürün: {product2.Name}");
Console.WriteLine($"Fiyat: {product2.Price}");

Console.WriteLine();

Console.WriteLine($"Ürün: {product3.Name}");
Console.WriteLine($"Fiyat: {product3.Price}");