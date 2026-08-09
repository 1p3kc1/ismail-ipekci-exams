namespace MiniBankApp.Interfaces;

public interface ITransactionLogger
{
    void Log(int accountId, string operation, decimal amount, decimal balanceAfter);

    List<string> GetHistory(int accountId);
}