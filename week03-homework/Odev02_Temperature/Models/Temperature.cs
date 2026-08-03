using System;

namespace Odev02_Temperature.Models;

public class Temperature
{
private double celsius;

    public double Celsius
    {
        get { return celsius; }
        set { celsius = value; }
    }

    public double ToFahrenheit()
    {
        return (Celsius * 9 / 5) + 32;
    }

    public double ToKelvin()
    {
        return Celsius + 273.15;
    }
}
