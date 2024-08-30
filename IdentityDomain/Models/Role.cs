using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityDomain.Models;

public class Role : IdentityRole
{
    public Role(string name, string description, string sender) : base(name)
    {
        Description = description;
        ConcurrencyStamp = Guid.NewGuid().ToString();
        Creator = sender;
        CreateDate = DateTime.Now;
        Editor = sender;
        EditDate = DateTime.Now;
        Permissions = [];

    }

    public string Description { get; private set; }
    public string Creator { get; private set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime CreateDate { get; private set; }
    public string Editor { get; private set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime EditDate { get; private set; }

    public List<Permission> Permissions { get; private set; }

    public void Update(Role role)
    {
        Name = role.Name;
        Description = role.Description;
        Editor = role.Editor;
        EditDate = DateTime.Now;
    }

    public void AddPermissions(List<Permission> permissions)
    {
        Permissions = [.. permissions];
    }

    private Role() { }
}
