using System.ComponentModel.DataAnnotations;

namespace TestDomain.Models;

public class Skill : Common.BaseEntityTitle<Guid>
{
    [AllowedValues("Soft", "Hard")]
    public string SkillType { get; set; }
    public virtual ICollection<PersonSkill> PersonSkills { get; set; }
    public Skill(string title, string skillType)
    {
        Id = Guid.NewGuid();    
        Title = title;
        SkillType = skillType;
    }
    public Skill(string id, string title, string skillType)
    {
        Id = Guid.Parse(id);
        Title = title;
        SkillType = skillType;
    }
}
