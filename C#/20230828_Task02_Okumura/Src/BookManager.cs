// using space
using System;

namespace _20230828_Task02_Okumura
{
    public class BookManager
    {
        // Book database list
        private List<Book> _books = new List<Book>();

        // Add new book method
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        // Show all books method
        public void ShowAllBooks()
        {
            foreach (var book in _books)
            {
                book.Show();
            }
        }

        // Search book by title method
        public void SearchBookByTitle(string title)
        {
            foreach (var book in _books)
            {
                if (book.Title == title)
                {
                    book.Show();
                }
            }
        }

        // Delete book by title method
        public void DeleteBookByTitle(string title)
        {
            foreach (var book in _books)
            {
                if (book.Title == title)
                {
                    _books.Remove(book);
                }
            }
        }
    }
}