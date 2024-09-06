namespace TestDomain.Models;

public class QuestionOption : Common.BaseEntityTitle<Guid>
{
    public Guid QuestionId { get; set; }
    public Question Question { get; set; }
    public string TitleQuestionOption { get; set; }

    public QuestionOption(string title)
    {
        Title = title;
    }
}
