using System;
using Odev24_Constructor_Book.Models;

Book book1 = new Book();

Book book2 = new Book("Suç ve Ceza");

Book book3 = new Book("Sefiller", "Victor Hugo");

Book book4 = new Book("1984", "George Orwell", "Roman");

Book book5 = new Book("Nutuk", "Mustafa Kemal Atatürk", "Tarih", 543);

Console.WriteLine($"Ad: {book1.Name} - Yazar: {book1.AuthorName} - Sayfa: {book1.PageCount}");
Console.WriteLine($"Ad: {book2.Name} - Yazar: {book2.AuthorName} - Sayfa: {book2.PageCount}");
Console.WriteLine($"Ad: {book3.Name} - Yazar: {book3.AuthorName} - Sayfa: {book3.PageCount}");
Console.WriteLine($"Ad: {book4.Name} - Yazar: {book4.AuthorName} - Sayfa: {book4.PageCount}");
Console.WriteLine($"Ad: {book5.Name} - Yazar: {book5.AuthorName} - Sayfa: {book5.PageCount}");
