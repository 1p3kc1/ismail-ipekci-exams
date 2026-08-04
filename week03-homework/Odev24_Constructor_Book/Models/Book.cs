using System;

namespace Odev24_Constructor_Book.Models;
public class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string AuthorName { get; set; } = "";

    public string CategoryName { get; set; } = "";

    public int PageCount { get; set; }

    public decimal Price { get; set; }

    public Book()
    {
        PageCount = 100;
    }

    public Book(string name)
    {
        Name = name;
        PageCount = 100;
    }

    public Book(string name, string authorName)
    {
        Name = name;
        AuthorName = authorName;
        PageCount = 100;
    }

    public Book(string name, string authorName, string categoryName)
    {
        Name = name;
        AuthorName = authorName;
        CategoryName = categoryName;
        PageCount = 100;
    }

    public Book(string name, string authorName, string categoryName, int pageCount)
    {
        Name = name;
        AuthorName = authorName;
        CategoryName = categoryName;
        PageCount = pageCount;
    }
}

