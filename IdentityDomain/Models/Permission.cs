using InfrastructureService;

namespace IdentityDomain.Models;


public class Permission
{
    public Permission(string name, string description, ServiceType serviceType, string sender)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        ServiceType = serviceType;
        Creator = sender;
        CreatorDate = DateTime.UtcNow;
        Editor = sender;
        EditorDate = DateTime.UtcNow;
    }
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ServiceType ServiceType { get; private set; }
    public string Creator { get; private set; }
    public DateTime CreatorDate { get; private set; }
    public string Editor { get; private set; }
    public DateTime EditorDate { get; private set; }

    public void Update(Permission permission)
    {
        Name = permission.Name;
        Description = permission.Description;
        ServiceType = permission.ServiceType;
        Editor = permission.Editor;
        EditorDate = DateTime.Now;
    }

    private Permission() { }
}

