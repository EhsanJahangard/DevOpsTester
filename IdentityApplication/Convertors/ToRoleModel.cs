using IdentityApplication.CQRS.Authentication.Commands.Role;
using IdentityDomain.Models;

namespace IdentityApplication.Convertors;

public static class ToRoleModel
{
    public static Role ToModel(this AddRoleCommand role)
    {
        return new Role(role.Name, role.Description, role.Sender);
    }

    public static Role ToModel(this UpdateRoleCommand role)
    {
        return new Role(role.Name, role.Description, role.Sender);
    }
}
