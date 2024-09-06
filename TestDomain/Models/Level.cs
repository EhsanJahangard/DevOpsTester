namespace TestDomain.Models;

public class Level : Common.BaseEntityTitle<Guid>
{
    public virtual ICollection<PersonSkill>? PersonSkills { get; set; }      
    public virtual ICollection<Question>? Questions { get; set; }      
    public Level(string title)
    {
        Title = title;
    }
    public Level(string id, string title)
    {
        Title = title;
        Id = Guid.Parse(id);
    }
}
