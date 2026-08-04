using System;
using Odev21_Constructor_BankAccount.Models;

BankAccount account1 = new BankAccount("Ali Yılmaz");

BankAccount account2 = new BankAccount("Ayşe Demir");

Console.WriteLine("1. Hesap");
Console.WriteLine($"Sahibi: {account1.OwnerName}");
Console.WriteLine($"Bakiye: {account1.Balance}");

Console.WriteLine();

Console.WriteLine("2. Hesap");
Console.WriteLine($"Sahibi: {account2.OwnerName}");
Console.WriteLine($"Bakiye: {account2.Balance}");