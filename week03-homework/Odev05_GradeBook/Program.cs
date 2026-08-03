using Odev05_GradeBook.Models;

namespace Odev05_GradeBook;

class Program
{
    static void Main(string[] args)
    {
        GradeBook gradeBook = new GradeBook();

gradeBook.StudentName = "İsmail";

gradeBook.AddExamScore(85);
gradeBook.AddExamScore(70);
gradeBook.AddExamScore(95);
gradeBook.AddExamScore(80);

Console.WriteLine($"Öğrenci: {gradeBook.StudentName}");
Console.WriteLine($"Sınav Sayısı: {gradeBook.ExamCount}");
Console.WriteLine($"Toplam Puan: {gradeBook.TotalScore}");
Console.WriteLine($"Ortalama: {gradeBook.GetAverage()}");

try
{
    gradeBook.AddExamScore(120);
}
catch (ArgumentException hata)
{
    Console.WriteLine(hata.Message);
}
    }
}
