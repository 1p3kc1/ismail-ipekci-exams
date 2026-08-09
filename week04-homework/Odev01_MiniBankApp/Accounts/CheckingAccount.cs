namespace MiniBankApp.Accounts;

public class CheckingAccount : Account
{
    public decimal DailyWithdrawLimit { get; }

    public CheckingAccount(
        int accountId,
        string ownerName,
        decimal dailyWithdrawLimit)
        : base(accountId, ownerName)
    {
        DailyWithdrawLimit = dailyWithdrawLimit;
    }

    public override bool CanWithdraw(decimal amount)
    {
        return amount <= DailyWithdrawLimit && amount <= Balance;
    }

    public override decimal CalculateInterest()
    {
        return Balance * 0.02m;
    }

    public override string GetAccountType()
    {
        return "Vadesiz";
    }
}