namespace TestDomain.Models;

public class TestQuestion : Common.BaseEntity<Guid>
{
    public TestQuestion() { }
    public Guid TestId { get; set; }
    public virtual Test Test { get; set; }
    public Guid QuestionId { get; set; }
    public virtual Question Question { get; set; }
    
   
}


