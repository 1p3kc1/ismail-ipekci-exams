using Odev01_LibraryBook.Models;

namespace Odev01_LibraryBook;

class Program
{
    static void Main(string[] args)
    {
        LibraryBook book = new LibraryBook ("Sol Ayagim","Christy Brown");

        book.Borrow();
        book.Borrow();
        book.ReturnBook();
        book.Borrow();
    }
}
