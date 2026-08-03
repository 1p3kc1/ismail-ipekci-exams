using System;

namespace Odev21_Constructor_BankAccount.Models;

public class BankAccount

{
    public string OwnerName { get; set; }

    public decimal Balance { get; set; }

    public BankAccount(string ownerName)
    {
        OwnerName = ownerName;
        Balance = 0;
    }
}

