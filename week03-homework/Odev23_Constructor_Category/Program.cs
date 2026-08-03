using Odev23_Constructor_Category.Models;

Category category1 = new Category("Elektronik");

Category category2 = new Category("Kitap", "Roman ve hikaye kitapları");

Console.WriteLine("1. Kategori");
Console.WriteLine($"Adı: {category1.Name}");
Console.WriteLine($"Açıklama: {category1.Description}");

Console.WriteLine();

Console.WriteLine("2. Kategori");
Console.WriteLine($"Adı: {category2.Name}");
Console.WriteLine($"Açıklama: {category2.Description}");
