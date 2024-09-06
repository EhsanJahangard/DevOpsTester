namespace TestDomain.Models;

//PersonSkill
public class PersonSkill : Common.BaseEntity<Guid>
{
    public PersonSkill(){
       
    }
    public PersonSkill(Guid personId, Guid skillId, Guid levelId)
    {
        Id = Guid.NewGuid();
        PersonId = personId;
     
        SkillId = skillId;
     
        LevelId = levelId;
  
    }
    public PersonSkill(string personId, string skillId, string levelId)
    {
        Id = Guid.NewGuid();
        PersonId = Guid.Parse(personId);

        SkillId = Guid.Parse(skillId);

        LevelId = Guid.Parse(levelId);

    }
    public Guid PersonId { get; set; }
    public virtual Person People { get; set; }
    public Guid SkillId { get; set; }
    public virtual Skill Skills { get; set; }
    public Guid? LevelId { get; set; }
    public virtual Level Levels { get; set; }
    

}
