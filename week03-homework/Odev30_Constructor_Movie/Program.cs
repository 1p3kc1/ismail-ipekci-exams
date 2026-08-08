using Odev30_Constructor_Movie.Models;

Movie movie1 = new Movie("Esaretin Bedeli", "Frank Darabont");
movie1.Rating = 9.3;

Movie movie2 = new Movie("Başlangıç", "Christopher Nolan", 148);
movie2.Rating = 8.8;

Console.WriteLine("1. Film");
Console.WriteLine($"Adı: {movie1.Title}");
Console.WriteLine($"Yönetmen: {movie1.Director}");
Console.WriteLine($"Süre: {movie1.DurationMinutes} dakika");

Console.WriteLine();

Console.WriteLine("2. Film");
Console.WriteLine($"Adı: {movie2.Title}");
Console.WriteLine($"Yönetmen: {movie2.Director}");
Console.WriteLine($"Süre: {movie2.DurationMinutes} dakika");