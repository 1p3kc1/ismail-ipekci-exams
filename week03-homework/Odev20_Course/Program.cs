using System;
using Odev20_Course.Models;

Course course1 = new Course();

course1.CourseCode = "C101";
course1.CourseName = "C# Programlama";
course1.Instructor = "Ahmet Yılmaz";
course1.Credit = 4;
course1.IsOnline = true;

Course course2 = new Course();

course2.CourseCode = "C102";
course2.CourseName = "Veritabanı";
course2.Instructor = "Ayşe Demir";
course2.Credit = 3;
course2.IsOnline = false;

Course course3 = new Course();

course3.CourseCode = "C103";
course3.CourseName = "Web Programlama";
course3.Instructor = "Mehmet Kaya";
course3.Credit = 4;
course3.IsOnline = true;

Course course4 = new Course();

course4.CourseCode = "C104";
course4.CourseName = "Algoritma";
course4.Instructor = "Zeynep Çelik";
course4.Credit = 3;
course4.IsOnline = false;

Console.WriteLine("Online Dersler");

if (course1.IsOnline)
{
    Console.WriteLine(course1.CourseName);
}

if (course2.IsOnline)
{
    Console.WriteLine(course2.CourseName);
}

if (course3.IsOnline)
{
    Console.WriteLine(course3.CourseName);
}

if (course4.IsOnline)
{
    Console.WriteLine(course4.CourseName);
}

Console.WriteLine();

Console.WriteLine("Yüz Yüze Dersler");

if (!course1.IsOnline)
{
    Console.WriteLine(course1.CourseName);
}

if (!course2.IsOnline)
{
    Console.WriteLine(course2.CourseName);
}

if (!course3.IsOnline)
{
    Console.WriteLine(course3.CourseName);
}

if (!course4.IsOnline)
{
    Console.WriteLine(course4.CourseName);
}
