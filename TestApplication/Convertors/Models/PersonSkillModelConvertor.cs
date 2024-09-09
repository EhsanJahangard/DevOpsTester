using TestApplication.CQRS.PersonSkill.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class PersonSkillModelConvertor
{
    public static PersonSkill ToModel(this CreatePersonSkillCommand command)
    {
        return new PersonSkill(command.SkillId, command.PersonId,command.LevelId);
    }

}

