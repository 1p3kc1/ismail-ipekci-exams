using System;

namespace Odev06_WaterMeter.Models;

public class WaterMeter
{

    private string meterNumber;
    private int currentReading;

    public string MeterNumber
    {
        get { return meterNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Sayaç numarası boş olamaz.");

            meterNumber = value;
        }
    }

    public int CurrentReading
    {
        get { return currentReading; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Sayaç değeri negatif olamaz.");

            currentReading = value;
        }
    }

    public WaterMeter(string meterNumber, int currentReading)
    {
        MeterNumber = meterNumber;
        CurrentReading = currentReading;
    }

    public void RecordReading(int newReading)
    {
        if (newReading < CurrentReading)
            throw new ArgumentException("Yeni sayaç değeri eskisinden küçük olamaz.");

        CurrentReading = newReading;
    }

    public int CalculateConsumption(int previousReading)
    {
        if (previousReading > CurrentReading)
            throw new ArgumentException("Geçen ayın okuması mevcut okumadan büyük olamaz.");

        return CurrentReading - previousReading;
    }
}

