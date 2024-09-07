namespace TestDomain.Models;

public class QuestionPhoto : Common.BaseEntityTitle<Guid>
{
    public Guid QuestionId { get; set; }
    public virtual Question Question { get; set; }
    public Guid PhotoId { get; set; }
    public virtual Photo Photo { get; set; }
    public QuestionPhoto(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
    }

}
