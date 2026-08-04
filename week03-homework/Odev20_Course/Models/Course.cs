using System;

namespace Odev20_Course.Models;

public class Course

{
    public string CourseCode { get; set; } 

    public string CourseName { get; set; }
    public string Instructor { get; set; } 

    public int Credit { get; set; }

    public bool IsOnline { get; set; }
}
