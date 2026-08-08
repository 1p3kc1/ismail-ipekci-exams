using System;
using Odev39_Constructor_FlightTicket.Models;

FlightTicket ticket1 = new FlightTicket(
    "Aykut Şenses",
    "TK101",
    3500
);

FlightTicket ticket2 = new FlightTicket(
    "İsmail İpekçi",
    "TK205",
    6500,
    "Business"
);

Console.WriteLine("1. Bilet");
Console.WriteLine($"Yolcu: {ticket1.PassengerName}");
Console.WriteLine($"Sınıf: {ticket1.SeatClass}");

Console.WriteLine();

Console.WriteLine("2. Bilet");
Console.WriteLine($"Yolcu: {ticket2.PassengerName}");
Console.WriteLine($"Sınıf: {ticket2.SeatClass}");
