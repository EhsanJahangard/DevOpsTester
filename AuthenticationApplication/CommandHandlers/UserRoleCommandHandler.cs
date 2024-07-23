using AuthenticationApplication.Commands.UserRole;
using AuthenticationDomain;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationApplication.CommandHandlers
{
    public class UserRoleCommandHandler : 
        IRequestHandler<AddUserRolesCommand, ResponseMessage>,
        IRequestHandler<UpdateUserRolesCommand, ResponseMessage>,
        IRequestHandler<DeleteUserRolesCommand, ResponseMessage>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserRoleCommandHandler(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<ResponseMessage> Handle(AddUserRolesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                User user = await _userManager.FindByIdAsync(request.UserId);

                if (user == null)
                    return new ResponseMessage("کاربر وجود ندارد");

                IList<string> roles = await _userManager.GetRolesAsync(user);

                if (roles.Any())
                    return new ResponseMessage("کاربر نقش دارد");

                foreach (string roleId in request.RoleIds)
                {
                    Role role = await _roleManager.FindByIdAsync(roleId);

                    if (role == null)
                        return new ResponseMessage($"نقش با شناسه {roleId} وجود ندارد");

                    roles.Add(role.Name);
                }

                IdentityResult identityResult = await _userManager.AddToRolesAsync(user, roles);

                if (identityResult.Errors.Any())
                    return new ResponseMessage("مشکلی در ثبت نقش برای کابر وجود دارد", identityResult.Errors);

                return new ResponseMessage();
            }
            catch (Exception ex)
            {
                return new ResponseMessage(ex.Message);
            }
        }

        public async Task<ResponseMessage> Handle(UpdateUserRolesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                User user = await _userManager.FindByIdAsync(request.UserId);

                if (user == null)
                    return new ResponseMessage("کاربر وجود ندارد");

                IList<string> roles = await _userManager.GetRolesAsync(user);

                if (!roles.Any())
                    return new ResponseMessage("کاربر نقش برای ویرایش ندارد");

                IList<string> newRoles = new List<string>();

                foreach (string roleId in request.RoleIds)
                {
                    Role role = await _roleManager.FindByIdAsync(roleId);

                    if (role == null)
                        return new ResponseMessage($"نقش با شناسه {roleId} وجود ندارد");

                    newRoles.Add(role.Name);
                }

                IdentityResult identityResult = await _userManager.RemoveFromRolesAsync(user, roles);

                if (identityResult.Succeeded)
                {
                    identityResult = await _userManager.AddToRolesAsync(user, newRoles);

                    if(identityResult.Errors.Any())
                        return new ResponseMessage(identityResult.Errors);

                    return new ResponseMessage();   
                }

                return new ResponseMessage("مشکلی در ویرایش نقش کاربر وجود دارد",identityResult.Errors);
            }
            catch(Exception ex)
            {
                return new ResponseMessage(ex.Message);    
            }
        }

        public async Task<ResponseMessage> Handle(DeleteUserRolesCommand request, CancellationToken cancellationToken)
        {
            try
            {
                User user = await _userManager.FindByIdAsync(request.UserId);

                if (user == null)
                    return new ResponseMessage("کاربر وجود ندارد");

                IList<string> roles = await _userManager.GetRolesAsync(user);

                if (!roles.Any())
                    return new ResponseMessage("کاربر نقش ندارد");

                IdentityResult identityResult = await _userManager.RemoveFromRolesAsync(user, roles);

                if (identityResult.Errors.Any())
                    return new ResponseMessage("مشکلی در حذف نقش کاربر وجود دارد", identityResult.Errors);

                return new ResponseMessage();
            }
            catch (Exception ex) 
            {
                return new ResponseMessage(ex.Message);
            }
        }
    }
}
