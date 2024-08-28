using IdentityApplication.CQRS.Authentication.Queries.User;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace IdentityApplication.CQRS.Authentication.QueryHandlers;

public class UserQueryHandler :
        IRequestHandler<GetAllUserQuery, ResponseMessage>,
        IRequestHandler<GetUserByIdQuery, ResponseMessage>

{
    private readonly UserManager<User> _userManager;
    public UserQueryHandler(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<ResponseMessage> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
    {
        return new ResponseMessage(_userManager.Users);
    }

    public async Task<ResponseMessage> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        User user = await _userManager.FindByIdAsync(request.Id);

        if (user != null)
            return new ResponseMessage(user);

        return new ResponseMessage("کاربر مورد نظر وجود ندارد");
    }
}