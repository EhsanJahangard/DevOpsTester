using AuthenticationApplication.Queries.Role;
using AuthenticationDomain;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationApplication.QueryHandlers
{
    public class RoleQueryHandler :
        IRequestHandler<GetAllRoleQuery, ResponseMessage>,
        IRequestHandler<GetRoleByIdQuery, ResponseMessage>
    {
        private readonly RoleManager<Role> _roleManager;
        public RoleQueryHandler(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<ResponseMessage> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return new ResponseMessage(_roleManager.Roles);
            }
            catch (Exception ex)
            {
                return new ResponseMessage(ex.Message);
            }
            
        }

        public async Task<ResponseMessage> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                Role role = await _roleManager.FindByIdAsync(request.Id);

                if(role != null)
                    return new ResponseMessage(role);

                return new ResponseMessage("نقش مورد نظر وجود ندارد");
            }
            catch (Exception ex)
            {
                return new ResponseMessage(ex.Message);
            }
        }
    }
}
