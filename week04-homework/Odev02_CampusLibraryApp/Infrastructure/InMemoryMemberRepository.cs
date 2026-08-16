using CampusLibraryApp.Interfaces;
using CampusLibraryApp.Members;

namespace CampusLibraryApp.Infrastructure;

public class InMemoryMemberRepository : IRepository<Member>
{
    private readonly List<Member> members = new();

    public void Add(Member member)
    {
        if (GetById(member.MemberId) != null)
            throw new InvalidOperationException(
                "Bu ID ile kayıtlı bir üye zaten var.");

        members.Add(member);
    }

    public Member? GetById(string id)
    {
        return members.FirstOrDefault(m => m.MemberId == id);
    }

    public List<Member> GetAll()
    {
        return members.ToList();
    }

    public void Delete(string id)
    {
        Member? member = GetById(id);

        if (member == null)
            throw new InvalidOperationException(
                "Silinecek üye bulunamadı.");

        members.Remove(member);
    }
}