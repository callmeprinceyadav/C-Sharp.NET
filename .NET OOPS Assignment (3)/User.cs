public class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public int BorrowedBookID { get; set; }

    
    public User(int userID, string name)
    {
        UserID = userID;
        Name = name;
        BorrowedBookID = -1;

    
    public virtual void DisplayUserDetails()
    {
        Console.WriteLine($"User ID: {UserID}, Name: {Name}");
    }
}
