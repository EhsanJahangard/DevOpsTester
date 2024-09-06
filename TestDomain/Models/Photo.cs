namespace TestDomain.Models;

public class Photo : Common.BaseEntityTitle<Guid>
{
    public Photo(string title)
    {
        Title = title;
    }
}
