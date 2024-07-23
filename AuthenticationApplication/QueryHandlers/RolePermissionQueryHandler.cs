using AuthenticationApplication.Queries.RolePermission;
using AuthenticationDomain;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationApplication.QueryHandlers
{
    public class RolePermissionQueryHandler : IRequestHandler<GetPermissionByRoleIdQuery, ResponseMessage>
    {
        private readonly RoleManager<Role> _roleManager;

        public RolePermissionQueryHandler(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<ResponseMessage> Handle(GetPermissionByRoleIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                IQueryable<Role> roleQueryable = _roleManager.Roles.Where(x => x.Id == request.RoleId);

                Role role = await roleQueryable.SingleOrDefaultAsync();

                if (role is null)
                    return new ResponseMessage("نقش وجود ندارد");

                List<Permission> permissions =  await roleQueryable.Include(x => x.Permissions).Select(x => x.Permissions).FirstOrDefaultAsync();
                
                return new ResponseMessage(permissions);
            }
            catch (Exception ex) 
            {
                return new ResponseMessage(ex.Message);
            }
        }
    }
}
