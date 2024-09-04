using TestApplication.CQRS.Level.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class LevelModelConvertor
{
    public static Level ToModel(this CreateLevelCommand command)
    {
        return new Level(command.Title);
    }

}
