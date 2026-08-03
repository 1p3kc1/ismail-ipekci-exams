using Odev11_Student.Models;

namespace Odev11_Student;

class Program
{
    static void Main(string[] args)
    {

Student student1 = new Student();

student1.FirstName = "İsmail";
student1.LastName = "İpekçi";
student1.StudentNumber = "2301001";
student1.Department = "Bilgisayar Mühendisliği";

Student student2 = new Student();

student2.FirstName = "Semih";
student2.LastName = "Yılmaz";
student2.StudentNumber = "2301002";
student2.Department = "Yazılım Mühendisliği";

Console.WriteLine("1. Öğrenci");
Console.WriteLine($"Ad: {student1.FirstName}");
Console.WriteLine($"Soyad: {student1.LastName}");
Console.WriteLine($"Numara: {student1.StudentNumber}");
Console.WriteLine($"Bölüm: {student1.Department}");

Console.WriteLine("...............");

Console.WriteLine("2. Öğrenci");
Console.WriteLine($"Ad: {student2.FirstName}");
Console.WriteLine($"Soyad: {student2.LastName}");
Console.WriteLine($"Numara: {student2.StudentNumber}");
Console.WriteLine($"Bölüm: {student2.Department}");
    }

}
