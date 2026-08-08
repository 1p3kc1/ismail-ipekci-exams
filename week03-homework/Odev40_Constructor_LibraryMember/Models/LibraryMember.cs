namespace Odev40_Constructor_LibraryMember.Models;

public class LibraryMember
{
    public int MemberId { get; set; }

    public string FullName { get; set; } 

    public string MembershipType { get; set; } 

    public DateTime RegistrationDate { get; set; }

    public int BorrowedBookCount { get; set; }

    public LibraryMember(int memberId, string fullName, DateTime registrationDate)
    {
        MemberId = memberId;
        FullName = fullName;
        RegistrationDate = registrationDate;
        MembershipType = "Standard";
    }

    public LibraryMember(int memberId, string fullName, DateTime registrationDate, string membershipType)
    {
        MemberId = memberId;
        FullName = fullName;
        RegistrationDate = registrationDate;
        MembershipType = membershipType;
    }
}