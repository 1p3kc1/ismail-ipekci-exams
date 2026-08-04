using Odev14_Event.Models;

namespace Odev14_Event;

class Program
{
    static void Main(string[] args)
    {
       

Event event1 = new Event();

event1.Title = "Yazılım Semineri";
event1.Location = "İstanbul";
event1.EventDate = new DateTime(2026, 9, 15);
event1.Capacity = 300;

Event event2 = new Event();

event2.Title = "Yapay Zeka Semineri";
event2.Location = "Kocaeli";
event2.EventDate = new DateTime(2026, 10, 10);
event2.Capacity = 150;

Console.WriteLine($"{event1.Title} - Tarih: {event1.EventDate.ToShortDateString()} - Kapasite: {event1.Capacity}");

Console.WriteLine($"{event2.Title} - Tarih: {event2.EventDate.ToShortDateString()} - Kapasite: {event2.Capacity}");

if (event1.Capacity > event2.Capacity)
{
    Console.WriteLine($"{event1.Title} etkinliğinin kapasitesi daha fazladır.");
}
else
{
    Console.WriteLine($"{event2.Title} etkinliğinin kapasitesi daha fazladır.");
}
    }
}
