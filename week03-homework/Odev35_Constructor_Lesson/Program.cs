using Odev35_Constructor_Lesson.Models;

Lesson lesson1 = new Lesson("C101", "C# Programlama", "Ahmet Yılmaz");

Lesson lesson2 = new Lesson("M201", "Matematik", "Ayşe Demir", 4, true);

Console.WriteLine("1. Ders");
Console.WriteLine($"Ders: {lesson1.LessonName}");
Console.WriteLine($"Kredi: {lesson1.Credit}");

Console.WriteLine();

Console.WriteLine("2. Ders");
Console.WriteLine($"Ders: {lesson2.LessonName}");
Console.WriteLine($"Kredi: {lesson2.Credit}");

Console.WriteLine();

int toplamKredi = lesson1.Credit + lesson2.Credit;

Console.WriteLine($"Toplam Kredi: {toplamKredi}");