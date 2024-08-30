using Microsoft.AspNetCore.Identity;

namespace IdentityDomain.Models;

public class User : IdentityUser
{
    public User(string firstName, string lastName, string email, string username, string mobile, string sender) : base(username)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Mobile = mobile;
        Creator = sender;
        CreateDate = DateTime.UtcNow;
        Editor = sender;
        EditDate = DateTime.UtcNow;
    }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Mobile { get; private set; }
    public int? City { get; private set; } = 0;
    public int? Country { get; private set; } = 0;
    public string? PostalCode { get; private set; } = "0000000000";
    public string Creator { get; private set; }
    public DateTime CreateDate { get; private set; }
    public string Editor { get; set; }
    public DateTime EditDate { get; set; }

    public void Update(User user)
    {
        FirstName = user.FirstName;
        LastName = user.LastName;
        Email = user.Email;
        Mobile = user.Mobile;
        Editor = user.Editor;
        EditDate = DateTime.UtcNow;
    }

    private User() { }

}
