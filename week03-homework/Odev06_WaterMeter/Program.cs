using Odev06_WaterMeter.Models;

namespace Odev06_WaterMeter;

class Program
{
    static void Main(string[] args)
    {

WaterMeter meter = new WaterMeter("Sayac17", 1000);

meter.RecordReading(1250);

int consumption = meter.CalculateConsumption(1000);

Console.WriteLine($"Sayaç No: {meter.MeterNumber}");
Console.WriteLine($"Güncel Okuma: {meter.CurrentReading}");
Console.WriteLine($"Bu Ayki Tüketim: {consumption}");
    }
}
