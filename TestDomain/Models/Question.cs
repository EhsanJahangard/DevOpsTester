namespace TestDomain.Models;

public class Question : Common.BaseEntity<Guid>
{
    public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
    public virtual ICollection<QuestionPhoto> QuestionPhotos { get; set; }

    public Guid QuestionTypeId { get; set; }
    public virtual QuestionType QuestionType { get; set; }
    public Guid LevelId { get; set; }
    public virtual Level Level { get; set; }

    public string Letter { get; set; }
    public string Answer { get; set; }
    public Question(string letter, string answer, Guid levelId, Guid questionTypeId)
    {
        Id=Guid.NewGuid();
        Letter = letter;
        Answer = answer;
        QuestionTypeId = questionTypeId;
        LevelId = levelId;
    }


}
