namespace MiniBankApp.Accounts;

public class SavingsAccount : Account
{
    public int TermMonths { get; }
    public DateTime MaturityDate { get; }
    public decimal AnnualInterestRate { get; }

    public SavingsAccount(
        int accountId,
        string ownerName,
        int termMonths,
        decimal annualInterestRate)
        : base(accountId, ownerName)
    {
        TermMonths = termMonths;
        AnnualInterestRate = annualInterestRate;
        MaturityDate = DateTime.Now.AddMonths(termMonths);
    }

    public override bool CanWithdraw(decimal amount)
    {
        return DateTime.Now >= MaturityDate && amount <= Balance;
    }

    public override decimal CalculateInterest()
    {
        decimal years = TermMonths / 12m;

        return Balance * AnnualInterestRate * years;
    }

    public override string GetAccountType()
    {
        return "Vadeli";
    }
}