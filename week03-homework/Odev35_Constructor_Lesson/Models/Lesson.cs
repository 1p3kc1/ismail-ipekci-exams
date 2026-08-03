using System;

namespace Odev35_Constructor_Lesson.Models;

public class Lesson
{
    public string LessonCode { get; set; } = "";

    public string LessonName { get; set; } = "";

    public string Instructor { get; set; } = "";

    public int Credit { get; set; }

    public bool IsMandatory { get; set; }

    public Lesson(string lessonCode, string lessonName, string instructor)
    {
        LessonCode = lessonCode;
        LessonName = lessonName;
        Instructor = instructor;
        Credit = 3;
    }

    public Lesson(string lessonCode, string lessonName, string instructor, int credit, bool isMandatory)
    {
        LessonCode = lessonCode;
        LessonName = lessonName;
        Instructor = instructor;
        Credit = credit;
        IsMandatory = isMandatory;
    }
}