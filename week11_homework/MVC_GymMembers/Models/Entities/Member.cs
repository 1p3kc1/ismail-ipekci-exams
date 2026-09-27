namespace MVC_GymMembers.Models.Entities;

public class Member
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string MembershipType { get; set; } =null!;

    public int Age { get; set; }
}