using Odev32_Constructor_HotelReservation.Models;

HotelReservation reservation1 = new HotelReservation(
    "Ali Yılmaz",
    101,
    new DateTime(2026, 8, 10)
);

reservation1.TotalPrice = 2500;

HotelReservation reservation2 = new HotelReservation(
    "Ayşe Demir",
    205,
    new DateTime(2026, 8, 15),
    3
);

reservation2.TotalPrice = 7500;

Console.WriteLine("1. Rezervasyon");
Console.WriteLine($"Misafir: {reservation1.GuestName}");
Console.WriteLine($"Gece Sayısı: {reservation1.NightCount}");

Console.WriteLine();

Console.WriteLine("2. Rezervasyon");
Console.WriteLine($"Misafir: {reservation2.GuestName}");
Console.WriteLine($"Gece Sayısı: {reservation2.NightCount}");