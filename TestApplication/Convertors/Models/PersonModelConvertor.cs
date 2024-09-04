using TestApplication.CQRS.Level.Commands;
using TestDomain.Models;

namespace TestApplication.Convertors.Models;

public static class PersonModelConvertor
{
    public static Person ToModel(this CreatePersonCommand command)
    {
        return new Person(command.Name,command.Family,command.Age,command.Mobile);
    }

}

