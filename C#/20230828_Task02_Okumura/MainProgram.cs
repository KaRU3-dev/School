using System;

namespace _20230828_Task02_Okumura
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            // BookManager
            BookManager bookManager = new();

            // Loop
            while (true)
            {
                var choice = ShowMenu();

                // Switch for selection
                switch (choice)
                {
                    case 1:
                        // Display all books
                        DisplayAllBooks(bookManager);
                        break;
                    case 2:
                        // Add new book
                        AddNewBook(bookManager);
                        break;
                    case 3:
                        // Search book by title
                        SearchBookByTitle(bookManager);
                        break;
                    case 4:
                        // Delete book by title
                        DeleteBookByTitle(bookManager);
                        break;
                    case 5:
                        // Exit
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        // Invalid input
                        Console.WriteLine("Invalid input!");
                        break;
                }
                Console.WriteLine();
            }

            // Menu
            static int ShowMenu()
            {
                Console.WriteLine("Book Manager");
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. Add new book");
                Console.WriteLine("3. Search book by title");
                Console.WriteLine("4. Delete book by title");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                // Input check with tryParse
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("Enter your choice: ");
                }

                return choice;
            }

            // Display all books
            static void DisplayAllBooks(BookManager bookManager)
            {
                Console.WriteLine("Displaying all books...");
                bookManager.ShowAllBooks();
            }

            // Add new book
            static void AddNewBook(BookManager bookManager)
            {
                Console.WriteLine("Adding new book...");
                Console.Write("Enter title: ");
                var title = Console.ReadLine();
                Console.Write("Enter author: ");
                var author = Console.ReadLine();
                Console.Write("Enter publication year: ");
                var publicationYear = int.Parse(Console.ReadLine());

                bookManager.AddBook(new Book(title, author, publicationYear));
            }

            // Search book by title
            static void SearchBookByTitle(BookManager bookManager)
            {
                Console.WriteLine("Searching book by title...");
                Console.Write("Enter title: ");
                var title = Console.ReadLine();

                bookManager.SearchBookByTitle(title);
            }

            // Delete book by title
            static void DeleteBookByTitle(BookManager bookManager)
            {
                Console.WriteLine("Deleting book by title...");
                Console.Write("Enter title: ");
                var title = Console.ReadLine();

                bookManager.DeleteBookByTitle(title);
            }

            // Check publication year
            static int CheckPublicationYear(int publicationYear)
            {
                if (publicationYear >= 1900 && publicationYear <= 2021)
                {
                    return publicationYear;
                }
                else
                {
                    Console.WriteLine("Invalid publication year!");
                    Console.Write("Enter publication year: ");
                    return 0;
                }
            }
        }
    }
}
