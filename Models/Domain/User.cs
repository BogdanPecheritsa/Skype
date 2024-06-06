namespace CALLОМОЙСЬКИЙ.Models.Domain;

public class User
{
    public Guid Id { get; set; }
    public string PhoneNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public List<Call> Calls { get; set; }
    public List<Message> Messages { get; set; }
    public List<Contact> Contacts { get; set; }
}