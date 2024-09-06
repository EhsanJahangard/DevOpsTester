namespace TestDomain.Models;

public class QuestionPhoto : Common.BaseEntityTitle<Guid>
{
    public Guid QuestionId { get; set; }
    public virtual Question Question { get; set; }
    public QuestionPhoto(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
    }

}
