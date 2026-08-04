using System;
using Odev25_Constructor_Student.Models;

Student student1 = new Student("İsmail", "Yılmaz");
student1.StudentNumber = "1001";
student1.Department = "Bilgisayar Mühendisliği";

Student student2 = new Student("Ayşe", "Demir");
student2.StudentNumber = "1002";
student2.Department = "Yazılım Mühendisliği";

Console.WriteLine("1. Öğrenci");
Console.WriteLine($"Ad Soyad: {student1.FirstName} {student1.LastName}");
Console.WriteLine($"Numara: {student1.StudentNumber}");
Console.WriteLine($"Bölüm: {student1.Department}");

Console.WriteLine();

Console.WriteLine("2. Öğrenci");
Console.WriteLine($"Ad Soyad: {student2.FirstName} {student2.LastName}");
Console.WriteLine($"Numara: {student2.StudentNumber}");
Console.WriteLine($"Bölüm: {student2.Department}");
