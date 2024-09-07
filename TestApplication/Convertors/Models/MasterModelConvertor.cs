using TestApplication.CQRS.Master.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class MasterModelConvertor
{
    public static Master ToModel(this CreateMasterCommand command)
    {
        return new Master(command.Name, command.Family, command.Mobile, "", command.DateBirth, "", "", "", "", 0);
    }

}

