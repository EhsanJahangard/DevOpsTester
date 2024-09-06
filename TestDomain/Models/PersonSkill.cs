namespace TestDomain.Models;

//PersonSkill
public class PersonSkill : Common.BaseEntity<Guid>
{
    public Guid PersonId { get; set; }
    public virtual Person People { get; set; }
    public Guid SkillId { get; set; }
    public virtual Skill Skills { get; set; }
    public Guid? LevelId { get; set; }
    public virtual Level Levels { get; set; }

}
