using Odev10_BankAccount.Models;

namespace Odev10_BankAccount;

class Program
{
    static void Main(string[] args)
    {

BankAccount account = new BankAccount();

account.OwnerName = "İsmail";

account.Deposit(2500);
account.Deposit(7000);

Console.WriteLine($"Bakiye: {account.Balance}");

bool sonuc = account.WithDraw(3000);

if (sonuc)
{
    Console.WriteLine($"3000 TL çekildi. Yeni bakiye: {account.Balance}");
}
else
{
    Console.WriteLine("Yetersiz bakiye.");
}

sonuc = account.WithDraw(20000);

if (sonuc)
{
    Console.WriteLine($"20000 TL çekildi. Yeni bakiye: {account.Balance}");
}
else
{
    Console.WriteLine("Yetersiz bakiye.");
};
    }
}
