namespace TestDomain.Models;

public class Skill : Common.BaseEntityTitle<Guid>
{
    public virtual ICollection<PersonSkill> PersonSkills { get; set; }
    public Skill(string title)
    {
        Title = title;
    }
}
