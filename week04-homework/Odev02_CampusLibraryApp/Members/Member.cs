namespace CampusLibraryApp.Members;

public abstract class Member
{
    private readonly List<string> activeLoans = new();

    private readonly Dictionary<string, DateTime> dueDates = new();

    private readonly HashSet<string> renewedBooks = new();

    public string MemberId { get; }

    public string FullName { get; }

    public bool IsActive { get; private set; }

    public DateTime CreatedAt { get; }

    public IReadOnlyList<string> ActiveLoans
        => activeLoans.AsReadOnly();

    public int ActiveLoanCount
        => activeLoans.Count;

    public abstract int MaxBooks { get; }

    public abstract int LoanPeriodDays { get; }

    public abstract decimal CalculateLateFee(int daysLate);

    public abstract string GetMemberType();

    protected Member(
        string memberId,
        string fullName)
    {
        if (string.IsNullOrWhiteSpace(memberId))
            throw new ArgumentException(
                "Üye ID boş olamaz.");

        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException(
                "Üye adı boş olamaz.");

        MemberId = memberId;
        FullName = fullName;
        IsActive = true;
        CreatedAt = DateTime.Now;
    }

    // ========================================
    // ÜYELİĞİ KAPAT
    // ========================================

    public void CloseMembership()
    {
        IsActive = false;
    }

    // ========================================
    // KİTAP EKLE
    // ========================================

    public void AddLoan(
        string bookId,
        DateTime dueDate)
    {
        if (string.IsNullOrWhiteSpace(bookId))
            throw new ArgumentException(
                "Kitap ID boş olamaz.");

        if (activeLoans.Contains(bookId))
            throw new InvalidOperationException(
                "Bu kitap zaten üyenin üzerinde.");

        if (ActiveLoanCount >= MaxBooks)
            throw new InvalidOperationException(
                "Üyenin kitap alma limiti dolu.");

        activeLoans.Add(bookId);

        dueDates[bookId] = dueDate;
    }

    // ========================================
    // KİTABI GETİR
    // ========================================

    public bool HasBook(string bookId)
    {
        return activeLoans.Contains(bookId);
    }

    // ========================================
    // SON TESLİM TARİHİNİ GETİR
    // ========================================

    public DateTime GetDueDate(string bookId)
    {
        if (!dueDates.ContainsKey(bookId))
            throw new InvalidOperationException(
                "Bu kitap üyenin üzerinde değil.");

        return dueDates[bookId];
    }

    // ========================================
    // KİTABI İADE ET
    // ========================================

    public void RemoveLoan(string bookId)
    {
        if (!activeLoans.Contains(bookId))
            throw new InvalidOperationException(
                "Bu kitap üyenin üzerinde değil.");

        activeLoans.Remove(bookId);

        dueDates.Remove(bookId);

        renewedBooks.Remove(bookId);
    }

    // ========================================
    // KİTAP UZATILMIŞ MI?
    // ========================================

    public bool HasRenewed(string bookId)
    {
        return renewedBooks.Contains(bookId);
    }

    // ========================================
    // KİTAP SÜRESİNİ UZAT
    // ========================================

    public void RenewBook(string bookId)
    {
        if (!activeLoans.Contains(bookId))
            throw new InvalidOperationException(
                "Bu kitap üyenin üzerinde değil.");

        if (renewedBooks.Contains(bookId))
            throw new InvalidOperationException(
                "Bu kitap daha önce uzatılmış.");

        DateTime currentDueDate =
            dueDates[bookId];

        dueDates[bookId] =
            currentDueDate.AddDays(LoanPeriodDays);

        renewedBooks.Add(bookId);
    }
}