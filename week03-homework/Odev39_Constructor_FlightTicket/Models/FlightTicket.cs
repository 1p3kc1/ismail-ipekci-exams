using System;

namespace Odev39_Constructor_FlightTicket.Models;

public class FlightTicket
{
    public string PassengerName { get; set; } = "";

    public string FlightCode { get; set; } = "";

    public string SeatClass { get; set; } = "";

    public decimal Price { get; set; }

    public FlightTicket(string passengerName, string flightCode, decimal price)
    {
        PassengerName = passengerName;
        FlightCode = flightCode;
        Price = price;
        SeatClass = "Economy";
    }

    public FlightTicket(string passengerName, string flightCode, decimal price, string seatClass)
    {
        PassengerName = passengerName;
        FlightCode = flightCode;
        Price = price;
        SeatClass = seatClass;
    }
}