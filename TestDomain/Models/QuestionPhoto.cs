namespace TestDomain.Models;

public class QuestionPhoto : Common.BaseEntityTitle<Guid>
{
    public Guid QuestionId { get; set; }
    public ICollection<Question> Questions { get; set; }
    public QuestionPhoto(string title)
    {
        Title = title;
    }

}
