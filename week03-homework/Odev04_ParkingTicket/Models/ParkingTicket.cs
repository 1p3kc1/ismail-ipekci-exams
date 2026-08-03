using System;

namespace Odev04_ParkingTicket.Models;

public class ParkingTicket
{
    private string plateNumber;
    private DateTime entryTime;
    private bool isPaid;
    private decimal fee;

    public string PlateNumber
    {
        get { return plateNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Plaka boş olamaz.");

            plateNumber = value;
        }
    }

    public DateTime EntryTime
    {
        get { return entryTime; }
        set { entryTime = value; }
    }

    public bool IsPaid
    {
        get { return isPaid; }
        private set { isPaid = value; }
    }

    public decimal CalculateFee(int hours, decimal hourlyRate)
    {
        fee = hours * hourlyRate;
        return fee;
    }

    public void Pay(decimal amount)
    {
        if (amount >= fee)
        {
            IsPaid = true;
            Console.WriteLine("Ödeme başarılı.");
        }
        else
        {
            IsPaid = false;
            Console.WriteLine("Yetersiz ödeme.");
        }
    }
}