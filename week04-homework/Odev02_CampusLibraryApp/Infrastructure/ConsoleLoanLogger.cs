using CampusLibraryApp.Interfaces;

namespace CampusLibraryApp.Infrastructure;

public class ConsoleLoanLogger : ILoanLogger
{
    private readonly List<string> logs = new();

    public void Log(
        string memberId,
        string bookId,
        string operation,
        string details)
    {
        string log = 
            $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} | " +
            $"Üye: {memberId} | " +
            $"Kitap: {bookId} | " +
            $"{operation} | " +
            $"{details}";

        logs.Add(log);

        Console.WriteLine($"LOG: {log}");
    }

    public List<string> GetHistory(string memberId)
    {
        return logs
            .Where(log => log.Contains($"Üye: {memberId}"))
            .ToList();
    }
}