using MiniBankApp.Interfaces;

namespace MiniBankApp.Infrastructure;

public class ConsoleTransactionLogger : ITransactionLogger
{
    private readonly Dictionary<int, List<string>> _history = new();

    public void Log(
        int accountId,
        string operation,
        decimal amount,
        decimal balanceAfter)
    {
        if (!_history.ContainsKey(accountId))
        {
            _history[accountId] = new List<string>();
        }

        string record =
            $"{DateTime.Now:dd.MM.yyyy HH:mm} | " +
            $"{operation} | " +
            $"Tutar: {amount:C} | " +
            $"Bakiye: {balanceAfter:C}";

        _history[accountId].Add(record);

        Console.WriteLine($"LOG: {record}");
    }

    public List<string> GetHistory(int accountId)
    {
        if (_history.ContainsKey(accountId))
        {
            return _history[accountId];
        }

        return new List<string>();
    }
}