using Odev07_StepCounter.Models;

namespace Odev07_StepCounter;

class Program
{
    static void Main(string[] args)
    {
        StepCounter counter = new StepCounter();

    counter.DailyGoal = 8000;

    counter.AddSteps(5000);
    Console.WriteLine($"Adım Sayısı: {counter.Steps}");
    Console.WriteLine($"Hedefe Ulaşıldı mı? {counter.IsGoalReached()}");

    counter.AddSteps(4000);
    Console.WriteLine($"Adım Sayısı: {counter.Steps}");
    Console.WriteLine($"Hedefe Ulaşıldı mı? {counter.IsGoalReached()}");


}
}