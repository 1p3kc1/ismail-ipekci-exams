
using CampusLibraryApp.Catalog;
using CampusLibraryApp.Infrastructure;
using CampusLibraryApp.Interfaces;
using CampusLibraryApp.Members;
using CampusLibraryApp.Services;


// ========================================
// BAĞIMLILIKLAR
// ========================================

IRepository<Member> memberRepository =
    new InMemoryMemberRepository();

IRepository<Book> bookRepository =
    new InMemoryBookRepository();

ILoanLogger loanLogger =
    new ConsoleLoanLogger();

LibraryService library =
    new LibraryService(
        memberRepository,
        bookRepository,
        loanLogger);


// ========================================
// ÜYELER
// ========================================

Member student1 =
    new StudentMember(
        "O1",
        "Ahmet Yılmaz");

Member student2 =
    new StudentMember(
        "O2",
        "Mehmet Kaya");

Member academic1 =
    new AcademicMember(
        "A1",
        "Ayşe Demir");

Member guest1 =
    new GuestMember(
        "G1",
        "Ali Misafir");


library.RegisterMember(student1);
library.RegisterMember(student2);
library.RegisterMember(academic1);
library.RegisterMember(guest1);


// ========================================
// KİTAPLAR
// ========================================

Book book1 =
    new Book(
        "K1",
        "Clean Code",
        "Robert C. Martin",
        2);

Book book2 =
    new Book(
        "K2",
        "C# Programlama",
        "John Smith",
        1);

Book book3 =
    new Book(
        "K3",
        "Design Patterns",
        "Erich Gamma",
        1);

Book book4 =
    new Book(
        "K4",
        "The Pragmatic Programmer",
        "David Thomas",
        1);


library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);
library.AddBook(book4);


// ========================================
// BAŞARILI ÖDÜNÇLER
// ========================================

Console.WriteLine("\n=== BAŞARILI ÖDÜNÇLER ===");

library.Borrow("O1", "K1");
library.Borrow("O1", "K2");
library.Borrow("O1", "K3");


// ========================================
// ÖĞRENCİ LİMİT TESTİ
// ========================================

Console.WriteLine("\n=== LİMİT TESTİ ===");

try
{
    library.Borrow("O1", "K4");
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}


// ========================================
// STOK TESTİ
// ========================================

Console.WriteLine("\n=== STOK TESTİ ===");

try
{
    library.Borrow("O2", "K2");
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}


// ========================================
// AKADEMİSYEN ÖDÜNCÜ
// ========================================

Console.WriteLine("\n=== AKADEMİSYEN ÖDÜNÇ ===");

library.Borrow("A1", "K4");


// ========================================
// RENEW TESTİ
// ========================================

Console.WriteLine("\n=== RENEW TESTİ ===");

library.Renew("O1", "K2");

try
{
    library.Renew("O1", "K2");
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}


// ========================================
// GECİKMELİ İADE
// ========================================

Console.WriteLine("\n=== GECİKMELİ İADE ===");

DateTime lateReturnDate =
    DateTime.Today.AddDays(20);

library.Return(
    "O1",
    "K1",
    lateReturnDate);


// ========================================
// MİSAFİR ÜYE TESTİ
// ========================================

Console.WriteLine("\n=== MİSAFİR ÜYE TESTİ ===");

library.Borrow("G1", "K1");

DateTime guestLateReturn =
    DateTime.Today.AddDays(10);

library.Return(
    "G1",
    "K1",
    guestLateReturn);


// ========================================
// LİSTELER
// ========================================

library.PrintMembers();

library.PrintBooks();


// ========================================
// İŞLEM GEÇMİŞİ
// ========================================

library.PrintMemberHistory("O1");


// ========================================
// PASİF ÜYE TESTİ
// ========================================

Console.WriteLine("\n=== PASİF ÜYE TESTİ ===");

student2.CloseMembership();

try
{
    library.Borrow("O2", "K4");
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}


// ========================================
// OLMAYAN ÜYE TESTİ
// ========================================

Console.WriteLine("\n=== OLMAYAN ÜYE TESTİ ===");

try
{
    library.Borrow("XXX", "K1");
}
catch (Exception ex)
{
    Console.WriteLine($"HATA: {ex.Message}");
}

