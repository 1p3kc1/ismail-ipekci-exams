namespace CampusLibraryApp.Members;

public class AcademicMember : Member
{
    public override int MaxBooks => 10;

    public override int LoanPeriodDays => 30;

    public AcademicMember(
        string memberId,
        string fullName)
        : base(memberId, fullName)
    {
    }

    public override decimal CalculateLateFee(int daysLate)
    {
        if (daysLate <= 0)
            return 0;

        return daysLate * 2m;
    }

    public override string GetMemberType()
    {
        return "Akademisyen";
    }
}