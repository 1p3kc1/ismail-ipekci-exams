using Odev08_InventoryItem.Models;

namespace Odev08_InventoryItem;

class Program
{
    static void Main(string[] args)
    {

InventoryItem item = new InventoryItem();

item.ProductName = "Kalem";

item.IncreaseStock(50);
Console.WriteLine($"Başlangıç Stok: {item.Quantity}");

item.IncreaseStock(20);
Console.WriteLine($"20 ürün eklendi. Stok: {item.Quantity}");

bool sonuc = item.DecreaseStock(30);

if (sonuc)
{
    Console.WriteLine($"30 ürün satıldı. Stok: {item.Quantity}");
}
else
{
    Console.WriteLine("Yeterli stok yok.");
}

sonuc = item.DecreaseStock(60);

if (sonuc)
{
    Console.WriteLine($"60 ürün satıldı. Stok: {item.Quantity}");
}
else
{
    Console.WriteLine("Yeterli stok yok.");
}
    }
}
