using TestApplication.CQRS.Test.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class TestModelConvertor
{
    public static Test ToModel(this CreateTestCommand command)
    {
        return new Test(command.Title, command.DateTest, command.Description, command.TypeTest, command.ExpirtionTest, command.LengthMinuteTest, command.MasterId);
    }

}
