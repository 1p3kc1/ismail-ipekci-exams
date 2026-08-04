using Odev16_MenuItem.Models;

namespace Odev16_MenuItem;

class Program
{
    static void Main(string[] args)
    {

MenuItem item1 = new MenuItem();
item1.Name = "Mercimek Çorbası";
item1.Description = "Günün çorbası";
item1.Price = 90;
item1.IsVegetarian = true;

MenuItem item2 = new MenuItem();
item2.Name = "Adana Kebap";
item2.Description = "Acılı kebap";
item2.Price = 350;
item2.IsVegetarian = false;

MenuItem item3 = new MenuItem();
item3.Name = "Makarna";
item3.Description = "Domates soslu";
item3.Price = 180;
item3.IsVegetarian = true;

MenuItem item4 = new MenuItem();
item4.Name = "Tavuk Izgara";
item4.Description = "Izgara tavuk";
item4.Price = 260;
item4.IsVegetarian = false;

MenuItem item5 = new MenuItem();
item5.Name = "Mevsim Salata";
item5.Description = "Karışık salata";
item5.Price = 120;
item5.IsVegetarian = true;

Console.WriteLine("Vejetaryen Yemekler");
Console.WriteLine();

if (item1.IsVegetarian)
{
    Console.WriteLine($"{item1.Name} - {item1.Price} TL");
}

if (item2.IsVegetarian)
{
    Console.WriteLine($"{item2.Name} - {item2.Price} TL");
}

if (item3.IsVegetarian)
{
    Console.WriteLine($"{item3.Name} - {item3.Price} TL");
}

if (item4.IsVegetarian)
{
    Console.WriteLine($"{item4.Name} - {item4.Price} TL");
}

if (item5.IsVegetarian)
{
    Console.WriteLine($"{item5.Name} - {item5.Price} TL");
}
    }
}
