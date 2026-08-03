using System;

namespace Odev01_LibraryBook.Models;

public class LibraryBook
{

    
        private string title;
        private string author;
        private bool isAvailable;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kitap adı boş olamaz.");

                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Yazar adı boş olamaz.");

                author = value;
            }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            private set { isAvailable = value; }
        }

        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"{Title} kitabı ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{Title} kitabı şu anda müsait değil.");
            }
        }

        public void ReturnBook()
        {
            IsAvailable = true;
            Console.WriteLine($"{Title} kitabı iade edildi.");
        }
}


