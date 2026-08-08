using Odev33_Constructor_Athlete.Models;

Athlete athlete1 = new Athlete("Ali Yılmaz", "Futbol");

Athlete athlete2 = new Athlete("Ayşe Demir", "Voleybol", "Eczacıbaşı", 8);

Console.WriteLine("1. Sporcu");
Console.WriteLine($"Adı: {athlete1.FullName}");
Console.WriteLine($"Takımı: {athlete1.TeamName}");

Console.WriteLine();

Console.WriteLine("2. Sporcu");
Console.WriteLine($"Adı: {athlete2.FullName}");
Console.WriteLine($"Takımı: {athlete2.TeamName}");

Console.WriteLine();

if (athlete1.TeamName == athlete2.TeamName)
{
    Console.WriteLine("İki sporcu aynı takımda.");
}
else
{
    Console.WriteLine("Sporcular farklı takımlarda.");
}