using Odev28_Constructor_Apartment.Models;

Apartment apartment1 = new Apartment(5, 2);
apartment1.RentPrice = 18000;

Apartment apartment2 = new Apartment(10, 4, 3);
apartment2.RentPrice = 25000;

Console.WriteLine("1. Daire");
Console.WriteLine($"Daire No: {apartment1.ApartmentNo}");
Console.WriteLine($"Kat: {apartment1.Floor}");
Console.WriteLine($"Oda Sayısı: {apartment1.RoomCount}");

Console.WriteLine();

Console.WriteLine("2. Daire");
Console.WriteLine($"Daire No: {apartment2.ApartmentNo}");
Console.WriteLine($"Kat: {apartment2.Floor}");
Console.WriteLine($"Oda Sayısı: {apartment2.RoomCount}");
