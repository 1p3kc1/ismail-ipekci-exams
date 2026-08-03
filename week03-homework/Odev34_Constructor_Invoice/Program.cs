using System;
using Odev34_Constructor_Invoice.Models;

Invoice invoice1 = new Invoice("F001", "Ali Yılmaz", 1000);
invoice1.TotalAmount = invoice1.Amount + (invoice1.Amount * invoice1.TaxRate);

Invoice invoice2 = new Invoice("F002", "Ayşe Demir", 2000, 0.10m);
invoice2.TotalAmount = invoice2.Amount + (invoice2.Amount * invoice2.TaxRate);

Console.WriteLine("1. Fatura");
Console.WriteLine($"Fatura No: {invoice1.InvoiceNo}");
Console.WriteLine($"Müşteri: {invoice1.CustomerName}");
Console.WriteLine($"Toplam Tutar: {invoice1.TotalAmount} TL");

Console.WriteLine();

Console.WriteLine("2. Fatura");
Console.WriteLine($"Fatura No: {invoice2.InvoiceNo}");
Console.WriteLine($"Müşteri: {invoice2.CustomerName}");
Console.WriteLine($"Toplam Tutar: {invoice2.TotalAmount} TL");