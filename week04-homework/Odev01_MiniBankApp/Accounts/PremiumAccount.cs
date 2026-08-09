namespace MiniBankApp.Accounts;

public class PremiumAccount : CheckingAccount
{
    public PremiumAccount(
        int accountId,
        string ownerName)
        : base(accountId, ownerName, 10000)
    {
    }

    public override decimal CalculateInterest()
    {
        return Balance * 0.05m;
    }

    public override string GetAccountType()
    {
        return "Premium";
    }
}