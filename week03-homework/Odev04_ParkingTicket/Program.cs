using Odev04_ParkingTicket.Models;

namespace Odev04_ParkingTicket;

class Program
{
    static void Main(string[] args)
    {
        ParkingTicket ticket = new ParkingTicket();

ticket.PlateNumber = "34ABC123";
ticket.EntryTime = DateTime.Now;

decimal fee = ticket.CalculateFee(3, 50);

Console.WriteLine($"Plaka: {ticket.PlateNumber}");
Console.WriteLine($"Giriş Saati: {ticket.EntryTime}");
Console.WriteLine($"Toplam Ücret: {fee} TL");

ticket.Pay(100);

ticket.Pay(150);

    }
}
