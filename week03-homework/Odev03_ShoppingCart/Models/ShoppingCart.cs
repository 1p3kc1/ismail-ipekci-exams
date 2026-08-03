using System;

namespace Odev03_ShoppingCart.Models;

public class ShoppingCart
{
    private int itemCount;
    private decimal totalPrice;

    public int ItemCount
    {
        get { return itemCount; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Ürün sayısı negatif olamaz.");

            itemCount = value;
        }
    }

    public decimal TotalPrice
    {
        get { return totalPrice; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Toplam tutar negatif olamaz.");

            totalPrice = value;
        }
    }

    public void AddItem(decimal price)
    {
        if (price < 0)
            throw new ArgumentException("Ürün fiyatı negatif olamaz.");

        ItemCount++;
        TotalPrice += price;
    }

    public void ClearCart()
    {
        ItemCount = 0;
        TotalPrice = 0;
    }
}