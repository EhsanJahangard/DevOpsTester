namespace TestDomain.Models;

public class Question : Common.BaseEntity<Guid>
{
    public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
    public virtual ICollection<QuestionPhoto> QuestionPhotos { get; set; }


    public Guid QuestionTypeId { get; set; }
    public QuestionType QuestionType { get; set; }
    public Guid LevelId { get; set; }
    public Level Level { get; set; }

    public string Letter { get; set; }
    public string Answer { get; set; }
    public Question(string letter, string answer)
    {
        Letter = letter;
        Answer = answer;
    }
}
