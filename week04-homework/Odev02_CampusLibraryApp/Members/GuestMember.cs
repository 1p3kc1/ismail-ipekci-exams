namespace CampusLibraryApp.Members;

public class GuestMember : Member
{
    public override int MaxBooks => 1;

    public override int LoanPeriodDays => 7;

    public GuestMember(
        string memberId,
        string fullName)
        : base(memberId, fullName)
    {
    }

    public override decimal CalculateLateFee(int daysLate)
    {
        if (daysLate <= 0)
            return 0;

        return daysLate * 10m;
    }

    public override string GetMemberType()
    {
        return "Misafir";
    }
}