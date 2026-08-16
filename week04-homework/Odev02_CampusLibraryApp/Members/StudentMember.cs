namespace CampusLibraryApp.Members;

public class StudentMember : Member
{
    public override int MaxBooks => 3;

    public override int LoanPeriodDays => 14;

    public StudentMember(
        string memberId,
        string fullName)
        : base(memberId, fullName)
    {
    }

    public override decimal CalculateLateFee(int daysLate)
    {
        if (daysLate <= 0)
            return 0;

        return daysLate * 5m;
    }

    public override string GetMemberType()
    {
        return "Öğrenci";
    }
}