namespace TestDomain.Models;

public class QuestionOption : Common.BaseEntityTitle<Guid>
{
    public Guid QuestionId { get; set; }
    public virtual Question Question { get; set; }

    public QuestionOption(string title,Guid questionId)
    {
        Id = Guid.NewGuid();
        Title = title;
        QuestionId = questionId;
    }
}
