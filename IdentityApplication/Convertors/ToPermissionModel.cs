using IdentityApplication.CQRS.Authentication.Commands.Permission;
using IdentityDomain.Models;
using InfrastructureService;

namespace IdentityApplication.Convertors;

public static class ToPermissionModel
{
    public static Permission ToModel(this AddPermissionCommand command)
    {
        return new Permission(command.Name, command.Description, Enum.Parse<ServiceType>(command.ServiceType), command.Sender);
    }

    public static Permission ToModel(this UpdatePermissionCommand command)
    {
        return new Permission(command.Name, command.Description, Enum.Parse<ServiceType>(command.ServiceType), command.Sender);
    }

}
