using System;
using System.Reflection;

namespace _20230828_Task01_Okumura
{
    public class Book
    {
        public string Title;
        public string Author;
        public int PublicationYear;

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        /// <summary>
        /// Show book info
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nPublicationYear: {PublicationYear}");
        }
    }
}
