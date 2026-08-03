using System;

namespace Odev07_StepCounter.Models;

public class StepCounter
{

    private int dailyGoal;
    private int steps;

    public int DailyGoal
    {
        get { return dailyGoal; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Günlük hedef 0'dan büyük olmalıdır.");

            dailyGoal = value;
        }
    }

    public int Steps
    {
        get { return steps; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Adım sayısı negatif olamaz.");

            steps = value;
        }
    }

    public void AddSteps(int count)
    {
        if (count < 0)
            throw new ArgumentException("Negatif adım eklenemez.");

        Steps += count;
    }

    public bool IsGoalReached()
    {
        return Steps >= DailyGoal;
    }
}

