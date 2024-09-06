namespace TestDomain.Models;

public class QuestionType : Common.BaseEntityTitle<Guid>
{
    public virtual ICollection<Question> Questions { get; set; }

    public QuestionType(string title)
    {
        Title = title;
    }
    public QuestionType(string id, string title)
    {
        Title = title;
        Id = Guid.Parse(id);
    }
}
