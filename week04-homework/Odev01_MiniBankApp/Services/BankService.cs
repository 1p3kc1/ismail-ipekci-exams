using MiniBankApp.Accounts;
using MiniBankApp.Interfaces;

namespace MiniBankApp.Services;

public class BankService
{
    private readonly IRepository<Account> _repository;
    private readonly ITransactionLogger _logger;

    public BankService(
        IRepository<Account> repository,
        ITransactionLogger logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public void OpenAccount(Account account)
    {
        _repository.Add(account);

        Console.WriteLine(
            $"Hesap açıldı: {account.AccountId} - " +
            $"{account.OwnerName} - " +
            $"{account.GetAccountType()}");
    }

    public void Deposit(int accountId, decimal amount)
    {
        Account account = GetAccount(accountId);

        account.Deposit(amount);

        _logger.Log(
            account.AccountId,
            "Para yatırma",
            amount,
            account.Balance);
    }

    public void Withdraw(int accountId, decimal amount)
    {
        Account account = GetAccount(accountId);

        account.Withdraw(amount);

        _logger.Log(
            account.AccountId,
            "Para çekme",
            amount,
            account.Balance);
    }

    public void PrintAccounts()
    {
        List<Account> accounts = _repository.GetAll();

        Console.WriteLine("\n--- HESAP LİSTESİ ---");

        foreach (Account account in accounts)
        {
            Console.WriteLine(
                $"ID: {account.AccountId} | " +
                $"Sahip: {account.OwnerName} | " +
                $"Tür: {account.GetAccountType()} | " +
                $"Bakiye: {account.Balance:C} | " +
                $"Aktif: {account.IsActive}");
        }
    }

    public void PrintTransactionHistory(int accountId)
    {
        GetAccount(accountId);

        List<string> history = _logger.GetHistory(accountId);

        Console.WriteLine(
            $"\n--- HESAP {accountId} İŞLEM GEÇMİŞİ ---");

        foreach (string record in history)
        {
            Console.WriteLine(record);
        }
    }

    public void PrintInterestReport()
    {
        Console.WriteLine("\n--- FAİZ RAPORU ---");

        foreach (Account account in _repository.GetAll())
        {
            decimal interest = account.CalculateInterest();

            Console.WriteLine(
                $"ID: {account.AccountId} | " +
                $"Sahip: {account.OwnerName} | " +
                $"Tür: {account.GetAccountType()} | " +
                $"Faiz: {interest:C}");
        }
    }

    private Account GetAccount(int accountId)
    {
        Account? account = _repository.GetById(accountId);

        if (account == null)
        {
            throw new KeyNotFoundException(
                $"Hesap bulunamadı: {accountId}");
        }

        return account;
    }

    public void TransferFunds(int fromId, int toId, decimal amount)
{
    Account fromAccount = GetAccount(fromId);
    Account toAccount = GetAccount(toId);

    fromAccount.Withdraw(amount);

    try
    {
        toAccount.Deposit(amount);
    }
    catch
    {
        fromAccount.Deposit(amount);
        throw;
    }

    _logger.Log(
        fromAccount.AccountId,
        "Transfer gönderildi",
        amount,
        fromAccount.Balance);

    _logger.Log(
        toAccount.AccountId,
        "Transfer alındı",
        amount,
        toAccount.Balance);
}
}