namespace Offertory_model;

public class Member
{
    public int Id { get; set; }
    public Name Name { get; set; }
    public int SubscriptionId { get; set; }
    
}

public  class Name
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName{ get; set; }

    public string GetName()
    {
        return FirstName + " " + MiddleName + " " + LastName;
    }
}