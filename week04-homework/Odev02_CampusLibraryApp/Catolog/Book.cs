namespace CampusLibraryApp.Catalog;

public class Book
{
    public string BookId { get; }
    public string Title { get; }
    public string Author { get; }

    public int TotalCopies { get; }

    public int AvailableCopies { get; private set; }

    public Book(
        string bookId,
        string title,
        string author,
        int totalCopies)
    {
        if (string.IsNullOrWhiteSpace(bookId))
            throw new ArgumentException("Kitap ID boş olamaz.");

        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Kitap adı boş olamaz.");

        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Yazar adı boş olamaz.");

        if (totalCopies <= 0)
            throw new ArgumentException("Kopya sayısı 0'dan büyük olmalıdır.");

        BookId = bookId;
        Title = title;
        Author = author;
        TotalCopies = totalCopies;
        AvailableCopies = totalCopies;
    }

    public void Borrow()
    {
        if (AvailableCopies <= 0)
            throw new InvalidOperationException("Kitap stokta yok.");

        AvailableCopies--;
    }

    public void Return()
    {
        if (AvailableCopies >= TotalCopies)
            throw new InvalidOperationException("Kitabın tamamı zaten stokta.");

        AvailableCopies++;
    }
}