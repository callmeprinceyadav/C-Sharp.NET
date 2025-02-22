
public class Library
{
    public List<Book> Books { get; private set; }
    public List<User> Users { get; private set; }

    
    public Library()
    {
        Books = new List<Book>();
        Users = new List<User>();
    }

    
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book Added: [ID: {book.BookID}, Title: \"{book.Title}\", Author: \"{book.Author}\"]");
    }

    
    public void AddUser(User user)
    {
        Users.Add(user);
        Console.WriteLine($"User Added: [ID: {user.UserID}, Name: \"{user.Name}\"]");
    }

    
    public void BorrowBook(int userID, int bookID)
    {
        
        User user = Users.Find(u => u.UserID == userID);
        Book book = Books.Find(b => b.BookID == bookID);

        if (user == null)
        {
            Console.WriteLine($"User with ID {userID} not found.");
            return;
        }

        if (book == null)
        {
            Console.WriteLine($"Book with ID {bookID} not found.");
            return;
        }

        if (!book.IsAvailable)
        {
            Console.WriteLine($"Book \"{book.Title}\" is not available.");
            return;
        }

        
        user.BorrowedBookID = bookID;
        book.IsAvailable = false;

        Console.WriteLine($"{user.Name} borrowed \"{book.Title}\".");
        Console.WriteLine($"Book Status: Not Available");
    }

    
    public void ReturnBook(int userID)
    {
        
        User user = Users.Find(u => u.UserID == userID);

        if (user == null)
        {
            Console.WriteLine($"User with ID {userID} not found.");
            return;
        }

        
        Book book = Books.Find(b => b.BookID == user.BorrowedBookID);

        if (book == null)
        {
            Console.WriteLine($"No book borrowed by {user.Name}.");
            return;
        }

        
        book.IsAvailable = true;
        user.BorrowedBookID = -1;

        Console.WriteLine($"{user.Name} returned \"{book.Title}\".");
        Console.WriteLine($"Book Status: Available");
    }
}
