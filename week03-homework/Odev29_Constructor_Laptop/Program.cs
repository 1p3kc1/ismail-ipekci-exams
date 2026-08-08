using Odev29_Constructor_Laptop.Models;

Laptop laptop1 = new Laptop("HP", "Victus");
laptop1.Price = 45000;

Laptop laptop2 = new Laptop("Lenovo", "Legion 5", 16, 512);
laptop2.Price = 55000;

Console.WriteLine("1. Laptop");
Console.WriteLine($"Marka: {laptop1.Brand}");
Console.WriteLine($"Model: {laptop1.Model}");
Console.WriteLine($"RAM: {laptop1.RamGb} GB");
Console.WriteLine($"Depolama: {laptop1.StorageGb} GB");

Console.WriteLine();

Console.WriteLine("2. Laptop");
Console.WriteLine($"Marka: {laptop2.Brand}");
Console.WriteLine($"Model: {laptop2.Model}");
Console.WriteLine($"RAM: {laptop2.RamGb} GB");
Console.WriteLine($"Depolama: {laptop2.StorageGb} GB");