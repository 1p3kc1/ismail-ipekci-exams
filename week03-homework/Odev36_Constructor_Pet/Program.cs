using Odev36_Constructor_Pet.Models;

Pet pet1 = new Pet("Coco", "İlayda Artık");

Pet pet2 = new Pet("Rex", "Kaan Artık", "Köpek", 3);

Console.WriteLine("1. Evcil Hayvan");
Console.WriteLine($"Adı: {pet1.Name}");
Console.WriteLine($"Türü: {pet1.Type}");
Console.WriteLine($"Yaşı: {pet1.Age}");

Console.WriteLine();

Console.WriteLine("2. Evcil Hayvan");
Console.WriteLine($"Adı: {pet2.Name}");
Console.WriteLine($"Türü: {pet2.Type}");
Console.WriteLine($"Yaşı: {pet2.Age}");