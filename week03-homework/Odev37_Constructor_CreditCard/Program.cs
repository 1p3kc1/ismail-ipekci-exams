using System;
using Odev37_Constructor_CreditCard.Models;

CreditCard card1 = new CreditCard(
    "Ali Yılmaz",
    "1234 5678 9012 3456",
    new DateTime(2028, 12, 31)
);

CreditCard card2 = new CreditCard(
    "Ayşe Demir",
    "9876 5432 1098 7654",
    new DateTime(2029, 6, 30),
    20000
);

Console.WriteLine("1. Kart");
Console.WriteLine($"Kart Sahibi: {card1.CardHolder}");
Console.WriteLine($"Limit: {card1.Limit} TL");

Console.WriteLine();

Console.WriteLine("2. Kart");
Console.WriteLine($"Kart Sahibi: {card2.CardHolder}");
Console.WriteLine($"Limit: {card2.Limit} TL");

Console.WriteLine();

if (card1.Limit > card2.Limit)
{
    Console.WriteLine("1. kartın limiti daha yüksektir.");
}
else if (card2.Limit > card1.Limit)
{
    Console.WriteLine("2. kartın limiti daha yüksektir.");
}
else
{
    Console.WriteLine("İki kartın limiti eşittir.");
}