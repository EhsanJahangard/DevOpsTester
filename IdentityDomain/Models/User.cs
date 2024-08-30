using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

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
        CreateDate = DateTime.Now;
        Editor = sender;
        UpdateDate = DateTime.Now;
    }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Mobile { get; private set; }
    public int? City { get; private set; } = 0;
    public int? Country { get; private set; } = 0;
    public string? PostalCode { get; private set; } = "0000000000";
    public string Creator { get; private set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime CreateDate { get; private set; }
    public string Editor { get; set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime UpdateDate { get; set; }
  
   

    public void Update(User user)
    {
        FirstName = user.FirstName;
        LastName = user.LastName;
        Email = user.Email;
        Mobile = user.Mobile;
        Editor = user.Editor;
        UpdateDate = DateTime.Now;
    }

    private User() { }

}
