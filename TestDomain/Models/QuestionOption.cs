namespace TestDomain.Models;

public class QuestionOption : Common.BaseEntityTitle<Guid>
{
    public Guid QuestionId { get; set; }
    public virtual Question Question { get; set; }

    public QuestionOption(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
    }
}
