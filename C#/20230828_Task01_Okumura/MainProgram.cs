using System;
using System.Runtime.CompilerServices;

namespace _20230828_Task01_Okumura
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            // Import Sys class
            Sys sys = new();

            // Show request start message
            sys.RequestInfo();

            // Request book's info and set variables
            string title = sys.RequestTitle();
            string author = sys.RequestAuthor();
            int publicationYear = sys.RequestPublicationYear();

            // Create new Book class and set variables
            Book book = new(title, author, publicationYear);

            // Show book info
            book.DisplayInfo();
        }
    }
}
