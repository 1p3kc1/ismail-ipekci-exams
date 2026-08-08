using System;
using Odev40_Constructor_LibraryMember.Models;

LibraryMember member1 = new LibraryMember(
    1001,
    "Ali Yılmaz",
    new DateTime(2026, 8, 1)
);

LibraryMember member2 = new LibraryMember(
    1002,
    "Ayşe Demir",
    new DateTime(2026, 8, 2),
    "Premium"
);

Console.WriteLine("1. Üye");
Console.WriteLine($"Ad Soyad: {member1.FullName}");
Console.WriteLine($"Üyelik Tipi: {member1.MembershipType}");
Console.WriteLine($"Kayıt Tarihi: {member1.RegistrationDate.ToShortDateString()}");

Console.WriteLine();

Console.WriteLine("2. Üye");
Console.WriteLine($"Ad Soyad: {member2.FullName}");
Console.WriteLine($"Üyelik Tipi: {member2.MembershipType}");
Console.WriteLine($"Kayıt Tarihi: {member2.RegistrationDate.ToShortDateString()}");