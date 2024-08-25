namespace TestDomain.Models;

public class Level : Common.BaseEntityTitle<Guid>
{
    public Level(string title)
    {
        Title = title;
    }
}
