using Odev02_Temperature.Models;

namespace Odev02_Temperature;

class Program
{
    static void Main(string[] args)
    {
        Temperature temperature = new Temperature();

temperature.Celsius = 0;
Console.WriteLine($"Celsius: {temperature.Celsius}");
Console.WriteLine($"Fahrenheit: {temperature.ToFahrenheit()}");
Console.WriteLine($"Kelvin: {temperature.ToKelvin()}");
Console.WriteLine("........");

temperature.Celsius = 25;
Console.WriteLine($"Celsius: {temperature.Celsius}");
Console.WriteLine($"Fahrenheit: {temperature.ToFahrenheit()}");
Console.WriteLine($"Kelvin: {temperature.ToKelvin()}");
Console.WriteLine(".......");

temperature.Celsius = -40;
Console.WriteLine($"Celsius: {temperature.Celsius}");
Console.WriteLine($"Fahrenheit: {temperature.ToFahrenheit()}");
Console.WriteLine($"Kelvin: {temperature.ToKelvin()}");
    }
}
