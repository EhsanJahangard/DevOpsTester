using IdentityApplication.CQRS.Authentication.Queries.UserRole;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace IdentityApplication.CQRS.Authentication.QueryHandlers;

public class UserRoleQueryHandler : IRequestHandler<GetRolesByUserIdQuery, ResponseMessage>
{
    private readonly UserManager<User> _userManager;

    public UserRoleQueryHandler(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<ResponseMessage> Handle(GetRolesByUserIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            User user = await _userManager.FindByIdAsync(request.UserId);

            if (user == null)
                return new ResponseMessage("کاربر وجود ندارد");

            IList<string> roles = await _userManager.GetRolesAsync(user);

            return new ResponseMessage(roles);
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }
}