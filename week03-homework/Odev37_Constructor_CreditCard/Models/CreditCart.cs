using System;

namespace Odev37_Constructor_CreditCard.Models;

public class CreditCard
{
    public string CardHolder { get; set; } 

    public string CardNumber { get; set; } 

    public DateTime ExpiryDate { get; set; }

    public decimal Limit { get; set; }

    public CreditCard(string cardHolder, string cardNumber, DateTime expiryDate)
    {
        CardHolder = cardHolder;
        CardNumber = cardNumber;
        ExpiryDate = expiryDate;
        Limit = 10000;
    }

    public CreditCard(string cardHolder, string cardNumber, DateTime expiryDate, decimal limit)
    {
        CardHolder = cardHolder;
        CardNumber = cardNumber;
        ExpiryDate = expiryDate;
        Limit = limit;
    }
}