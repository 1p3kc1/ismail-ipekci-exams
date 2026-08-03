using System;

namespace Odev10_BankAccount.Models;

public class BankAccount
{
    private string ownerName;
    private decimal balance;

    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Bakiye negatif olamaz.");

            balance = value;
        }
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public bool WithDraw(decimal amount)
    {
        if (amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }
}

