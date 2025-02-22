class Program
{
    static void Main(string[] args)
    {
        
        Library library = new Library();

        
        Book book1 = new Book(101, "C# Basics", "Prince Yadav");
        Book book2 = new Book(102, "Java Programming", "Rahul Kumar");
        library.AddBook(book1);
        library.AddBook(book2);

        
        User user1 = new User(1, "Prince");
        PremiumUser user2 = new PremiumUser(2, "Bob", "Gold");
        library.AddUser(user1);
        library.AddUser(user2);

        
        library.BorrowBook(1, 101);
        library.ReturnBook(1);

        
        Console.WriteLine("\nBook Details after operations:");
        foreach (Book book in library.Books)
        {
            book.DisplayBookDetails(true);
        }

        Console.WriteLine("\nUser Details after operations:");
        foreach (User user in library.Users)
        {
            user.DisplayUserDetails();
        }
    }
}
