using System;
using Odev26_Constructor_StudentNumber.Models;

Student student1 = new Student("Ali", "Yılmaz");
student1.Gpa = 3.20;

Student student2 = new Student(1001, "Ayşe", "Demir");
student2.Gpa = 3.85;

Console.WriteLine("1. Öğrenci");
Console.WriteLine($"Numara: {student1.StudentNumber}");
Console.WriteLine($"Ad Soyad: {student1.FirstName} {student1.LastName}");
Console.WriteLine($"Not Ortalaması: {student1.Gpa}");

Console.WriteLine();

Console.WriteLine("2. Öğrenci");
Console.WriteLine($"Numara: {student2.StudentNumber}");
Console.WriteLine($"Ad Soyad: {student2.FirstName} {student2.LastName}");
Console.WriteLine($"Not Ortalaması: {student2.Gpa}");