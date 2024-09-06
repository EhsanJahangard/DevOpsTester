namespace TestDomain.Models;

public class Skill : Common.BaseEntityTitle<Guid>
{
    public Skill(string title)
    {
        Title = title;
    }
}
