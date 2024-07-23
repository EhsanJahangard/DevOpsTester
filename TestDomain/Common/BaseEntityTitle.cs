namespace TestDomain.Common;

public class BaseEntityTitle<T> : BaseEntity<T>
{
    public BaseEntityTitle()
    {

    }
    public string Title { get; set; }
}
