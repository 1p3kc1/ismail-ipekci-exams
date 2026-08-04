using System;

namespace Odev25_Constructor_Student.Models;

public class Student
{
    public string StudentNumber { get; set; } 

    public string FirstName { get; set; } 

    public string LastName { get; set; } 

    public string Department { get; set; } 

    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}