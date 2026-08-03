using Odev03_ShoppingCart.Models;

namespace Odev03_ShoppingCart;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

cart.AddItem(150);
cart.AddItem(79.90m);
cart.AddItem(25.50m);

Console.WriteLine("Sepet Özeti");
Console.WriteLine($"Ürün Sayısı : {cart.ItemCount}");
Console.WriteLine($"Toplam Tutar: {cart.TotalPrice} TL");

cart.ClearCart();

Console.WriteLine();
Console.WriteLine("Sepet Temizlendikten Sonra");
Console.WriteLine($"Ürün Sayısı : {cart.ItemCount}");
Console.WriteLine($"Toplam Tutar: {cart.TotalPrice} TL");
    }
}
