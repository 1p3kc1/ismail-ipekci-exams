using CampusLibraryApp.Catalog;
using CampusLibraryApp.Interfaces;
using CampusLibraryApp.Members;

namespace CampusLibraryApp.Services;

public class LibraryService
{
    private readonly IRepository<Member> memberRepository;
    private readonly IRepository<Book> bookRepository;
    private readonly ILoanLogger loanLogger;

    public LibraryService(
        IRepository<Member> memberRepository,
        IRepository<Book> bookRepository,
        ILoanLogger loanLogger)
    {
        this.memberRepository = memberRepository;
        this.bookRepository = bookRepository;
        this.loanLogger = loanLogger;
    }

    // ========================================
    // ÜYE KAYDET
    // ========================================

    public void RegisterMember(Member member)
    {
        if (member == null)
            throw new ArgumentNullException(nameof(member));

        memberRepository.Add(member);

        Console.WriteLine(
            $"Üye kaydedildi: {member.MemberId} - " +
            $"{member.FullName} - " +
            $"{member.GetMemberType()}");
    }

    // ========================================
    // KİTAP EKLE
    // ========================================

    public void AddBook(Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));

        bookRepository.Add(book);

        Console.WriteLine(
            $"Kitap eklendi: {book.BookId} - " +
            $"{book.Title} - " +
            $"Stok: {book.TotalCopies}");
    }

    // ========================================
    // ÖDÜNÇ AL
    // ========================================

    public void Borrow(
        string memberId,
        string bookId)
    {
        Member? member =
            memberRepository.GetById(memberId);

        if (member == null)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Üye bulunamadı.");

            throw new InvalidOperationException(
                "Üye bulunamadı.");
        }

        if (!member.IsActive)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Üyenin üyeliği aktif değil.");

            throw new InvalidOperationException(
                "Pasif üyeye kitap verilemez.");
        }

        Book? book =
            bookRepository.GetById(bookId);

        if (book == null)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Kitap bulunamadı.");

            throw new InvalidOperationException(
                "Kitap bulunamadı.");
        }

        if (book.AvailableCopies <= 0)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Kitap stokta yok.");

            throw new InvalidOperationException(
                "Kitap stokta yok.");
        }

        if (member.ActiveLoanCount >= member.MaxBooks)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Üyenin kitap limiti dolu.");

            throw new InvalidOperationException(
                "Üyenin kitap limiti dolu.");
        }

        if (member.HasBook(bookId))
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Bu kitap zaten üyenin üzerinde.");

            throw new InvalidOperationException(
                "Bu kitap zaten üyenin üzerinde.");
        }

        DateTime dueDate =
            DateTime.Today.AddDays(
                member.LoanPeriodDays);

        book.Borrow();

        member.AddLoan(
            bookId,
            dueDate);

        loanLogger.Log(
            memberId,
            bookId,
            "ÖDÜNÇ",
            $"Kitap başarıyla ödünç verildi. " +
            $"Son teslim süresi: {dueDate:dd.MM.yyyy}");

        Console.WriteLine(
            $"ÖDÜNÇ BAŞARILI: " +
            $"{member.FullName} → {book.Title}");
    }

    // ========================================
    // İADE
    // ========================================

    public void Return(
        string memberId,
        string bookId,
        DateTime? returnDate = null)
    {
        Member? member =
            memberRepository.GetById(memberId);

        if (member == null)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Üye bulunamadı.");

            throw new InvalidOperationException(
                "Üye bulunamadı.");
        }

        Book? book =
            bookRepository.GetById(bookId);

        if (book == null)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Kitap bulunamadı.");

            throw new InvalidOperationException(
                "Kitap bulunamadı.");
        }

        if (!member.HasBook(bookId))
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Bu kitap üyenin üzerinde değil.");

            throw new InvalidOperationException(
                "Bu kitap üyenin üzerinde değil.");
        }

        DateTime actualReturnDate =
            returnDate ?? DateTime.Today;

        DateTime dueDate =
            member.GetDueDate(bookId);

        int daysLate =
            Math.Max(
                0,
                (actualReturnDate.Date -
                 dueDate.Date).Days);

        decimal lateFee =
            member.CalculateLateFee(daysLate);

        book.Return();

        member.RemoveLoan(bookId);

        loanLogger.Log(
            memberId,
            bookId,
            "İADE",
            $"Gecikme: {daysLate} gün | " +
            $"Ceza: {lateFee:C}");

        Console.WriteLine(
            $"İADE BAŞARILI: " +
            $"{member.FullName} → {book.Title}");

        Console.WriteLine(
            $"Gecikme: {daysLate} gün | " +
            $"Ceza: {lateFee:C}");
    }

    // ========================================
    // RENEW
    // ========================================

    public void Renew(
        string memberId,
        string bookId)
    {
        Member? member =
            memberRepository.GetById(memberId);

        if (member == null)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Üye bulunamadı.");

            throw new InvalidOperationException(
                "Üye bulunamadı.");
        }

        if (!member.HasBook(bookId))
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                "Bu kitap üyenin üzerinde değil.");

            throw new InvalidOperationException(
                "Bu kitap üyenin üzerinde değil.");
        }

        try
        {
            member.RenewBook(bookId);

            DateTime newDueDate =
                member.GetDueDate(bookId);

            loanLogger.Log(
                memberId,
                bookId,
                "UZATMA",
                $"Yeni son teslim tarihi: " +
                $"{newDueDate:dd.MM.yyyy}");

            Console.WriteLine(
                $"UZATMA BAŞARILI: " +
                $"{member.FullName} → {bookId}");

            Console.WriteLine(
                $"Yeni son teslim: " +
                $"{newDueDate:dd.MM.yyyy}");
        }
        catch (Exception ex)
        {
            loanLogger.Log(
                memberId,
                bookId,
                "RED",
                ex.Message);

            throw;
        }
    }

    // ========================================
    // ÜYELERİ LİSTELE
    // ========================================

    public void PrintMembers()
    {
        Console.WriteLine("\n=== ÜYELER ===");

        foreach (Member member in
                 memberRepository.GetAll())
        {
            Console.WriteLine(
                $"{member.MemberId} | " +
                $"{member.FullName} | " +
                $"{member.GetMemberType()} | " +
                $"Aktif: {member.IsActive} | " +
                $"Kitap: " +
                $"{member.ActiveLoanCount}/" +
                $"{member.MaxBooks}");
        }
    }

    // ========================================
    // KİTAPLARI LİSTELE
    // ========================================

    public void PrintBooks()
    {
        Console.WriteLine("\n=== KİTAPLAR ===");

        foreach (Book book in
                 bookRepository.GetAll())
        {
            Console.WriteLine(
                $"{book.BookId} | " +
                $"{book.Title} | " +
                $"{book.Author} | " +
                $"Stok: " +
                $"{book.AvailableCopies}/" +
                $"{book.TotalCopies}");
        }
    }

    // ========================================
    // ÜYE İŞLEM GEÇMİŞİ
    // ========================================

    public void PrintMemberHistory(
        string memberId)
    {
        Console.WriteLine(
            $"\n=== {memberId} İŞLEM GEÇMİŞİ ===");

        foreach (string log in
                 loanLogger.GetHistory(memberId))
        {
            Console.WriteLine(log);
        }
    }
}
