using CampusLibraryApp.Catalog;
using CampusLibraryApp.Interfaces;

namespace CampusLibraryApp.Infrastructure;

public class InMemoryBookRepository : IRepository<Book>
{
    private readonly List<Book> books = new();

    public void Add(Book book)
    {
        if (GetById(book.BookId) != null)
            throw new InvalidOperationException(
                "Bu ID ile kayıtlı bir kitap zaten var.");

        books.Add(book);
    }

    public Book? GetById(string id)
    {
        return books.FirstOrDefault(b => b.BookId == id);
    }

    public List<Book> GetAll()
    {
        return books.ToList();
    }

    public void Delete(string id)
    {
        Book? book = GetById(id);

        if (book == null)
            throw new InvalidOperationException(
                "Silinecek kitap bulunamadı.");

        books.Remove(book);
    }
}