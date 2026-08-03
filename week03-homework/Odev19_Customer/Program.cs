using Odev19_Customer.Models;

Customer customer1 = new Customer();

customer1.Name = "Ali Yılmaz";
customer1.Address = "İstanbul";
customer1.BirthDate = new DateTime(1998, 5, 10);

Customer customer2 = new Customer();

customer2.Name = "Ayşe Demir";
customer2.Address = "Ankara";
customer2.BirthDate = new DateTime(2001, 11, 25);

Console.WriteLine("1. Müşteri");
Console.WriteLine($"Ad: {customer1.Name}");
Console.WriteLine($"Adres: {customer1.Address}");
Console.WriteLine($"Doğum Yılı: {customer1.BirthDate.Year}");

Console.WriteLine();

Console.WriteLine("2. Müşteri");
Console.WriteLine($"Ad: {customer2.Name}");
Console.WriteLine($"Adres: {customer2.Address}");
Console.WriteLine($"Doğum Yılı: {customer2.BirthDate.Year}");
