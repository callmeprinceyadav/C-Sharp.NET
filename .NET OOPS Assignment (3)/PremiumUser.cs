public class PremiumUser : User
{
    public string MembershipLevel { get; set; }

    
    public PremiumUser(int userID, string name, string membershipLevel)
        : base(userID, name)
    {
        MembershipLevel = membershipLevel;
    }

    
    public override void DisplayUserDetails()
    {
        base.DisplayUserDetails();
        Console.WriteLine($"Membership Level: {MembershipLevel}");
    }
}
