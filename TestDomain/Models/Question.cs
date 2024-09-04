namespace TestDomain.Models;

public class Question : Common.BaseEntity<Guid>
{
    public string Letter { get; set; }
    public string Answer { get; set; }
    public Question(string letter, string answer)
    {
        Letter = letter;
        Answer = answer;
    }
}
