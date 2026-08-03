using System;

namespace Odev08_InventoryItem.Models;

public class InventoryItem
{
    private string productName;
    private int quantity;

    public string ProductName
    {
        get { return productName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Ürün adı boş olamaz.");

            productName = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Stok negatif olamaz.");

            quantity = value;
        }
    }

    public void IncreaseStock(int amount)
    {
        Quantity += amount;
    }

    public bool DecreaseStock(int amount)
    {
        if (amount > Quantity)
        {
            return false;
        }

        Quantity -= amount;
        return true;
    }
}

