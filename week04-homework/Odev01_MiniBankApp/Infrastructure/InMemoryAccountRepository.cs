using MiniBankApp.Accounts;
using MiniBankApp.Interfaces;

namespace MiniBankApp.Infrastructure;

public class InMemoryAccountRepository : IRepository<Account>
{
    private readonly List<Account> _accounts = new();

    public void Add(Account item)
    {
        _accounts.Add(item);
    }

    public Account? GetById(int id)
    {
        return _accounts.FirstOrDefault(a => a.AccountId == id);
    }

    public List<Account> GetAll()
    {
        return _accounts;
    }

    public void Delete(int id)
    {
        Account? account = GetById(id);

        if (account != null)
        {
            _accounts.Remove(account);
        }
    }
}