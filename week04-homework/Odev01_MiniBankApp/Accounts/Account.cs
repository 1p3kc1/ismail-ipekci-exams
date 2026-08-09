namespace MiniBankApp.Accounts;

public abstract class Account
{
    public int AccountId { get; }
    public string OwnerName { get; }
    public decimal Balance { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; }

    protected Account(int accountId, string ownerName)
    {
        AccountId = accountId;
        OwnerName = ownerName;
        Balance = 0;
        IsActive = true;
        CreatedAt = DateTime.Now;
    }

    public void Deposit(decimal amount)
    {
        if (!IsActive)
            throw new InvalidOperationException("Hesap kapalı.");

        if (amount <= 0)
            throw new ArgumentException("Yatırılacak tutar 0'dan büyük olmalı.");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (!IsActive)
            throw new InvalidOperationException("Hesap kapalı.");

        if (amount <= 0)
            throw new ArgumentException("Çekilecek tutar 0'dan büyük olmalı.");

        if (!CanWithdraw(amount))
            throw new InvalidOperationException("Bu hesaptan bu tutar çekilemez.");

        Balance -= amount;
    }

    public void Close()
    {
        IsActive = false;
    }

    public abstract bool CanWithdraw(decimal amount);

    public abstract decimal CalculateInterest();

    public abstract string GetAccountType();
}