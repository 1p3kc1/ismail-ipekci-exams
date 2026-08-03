using System;

namespace Odev05_GradeBook.Models;

public class GradeBook
{
    private string studentName;
    private int examCount;
    private int totalScore;

    public string StudentName
    {
        get { return studentName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Öğrenci adı boş olamaz.");

            studentName = value;
        }
    }

    public int ExamCount
    {
        get { return examCount; }
        private set { examCount = value; }
    }

    public int TotalScore
    {
        get { return totalScore; }
        private set { totalScore = value; }
    }

    public void AddExamScore(int score)
    {
        if (score < 0 || score > 100)
            throw new ArgumentException("Not 0 ile 100 arasında olmalıdır.");

        TotalScore += score;
        ExamCount++;
    }

    public double GetAverage()
    {
        if (ExamCount == 0)
            return 0;

        return (double)TotalScore / ExamCount;
    }
}

