using TestApplication.CQRS.Skill.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class SkillModelConvertor
{
    public static Skill ToModel(this CreateSkillCommand command)
    {
        return new Skill(command.Title,command.SkillType);
    }

}

