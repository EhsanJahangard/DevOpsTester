using EventBus.Messages;
using IdentityApplication.Contracts.Repositories;
using IdentityApplication.Contracts.UnitOfWork;
using IdentityApplication.CQRS.Authentication.Commands.Login;
using IdentityApplication.DTOs.Login;
using IdentityApplication.Utilities;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SixLabors.ImageSharp;

namespace IdentityApplication.CQRS.Authentication.CommandHandlers;

public class LoginCommandHandler : IRequestHandler<SendVerificationCodeCommand, ResponseMessage>,
    IRequestHandler<CheckVerificationCodeCommand, ResponseMessage>
{
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly ITokenManagerRepository _tokenManagerRepository;
    private readonly IVerificationCodeRepository _verificationCodeRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IConfiguration _configuration;
    private readonly IAccountRepository _accountRepository;


    public LoginCommandHandler(IAccountRepository accountRepository,IConfiguration configuration, UserManager<User> userManager, RoleManager<Role> roleManager, ITokenManagerRepository tokenManagerRepository, IVerificationCodeRepository verificationCodeRepository, IUnitOfWork unitOfWork)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _tokenManagerRepository = tokenManagerRepository;
        _verificationCodeRepository = verificationCodeRepository;
        _unitOfWork = unitOfWork;
        _configuration = configuration;
        _accountRepository = accountRepository;
    }
    //public async Task<BaseResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
    //{
    //    var response = new BaseResponseDto();

    //    request.UserName = request.UserName.DecryptData(configuration);
    //    request.Password = request.Password.DecryptData(configuration);
    //    request.CaptchaCode = request.CaptchaCode.DecryptData(configuration);

    //    if (Captcha.ValidateCaptcha(request.CaptchaCode, request.CaptchaCodeEncode) == false)
    //    {
    //        response.IsSuccess = false;
    //        response.Message = "کدامنیتی وارد شده معتبر نمی باشد";
    //        return response;
    //    }

    //    var user = await _userManager.FindByNameAsync(request.UserName);

    //    if (user == null)
    //    {
    //        response.IsSuccess = false;
    //        response.Message = "کاربر یافت نشد";
    //        return response;
    //    }

    //    var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);

    //    if (!result.Succeeded)
    //    {
    //        response.IsSuccess = false;
    //        response.Message = "ایمیل یا کلمه عبور وارد شده صحیح نمی باشد";
    //        return response;
    //    }

    //    var userPermissions = await _permissionRoleReadRepository.GetUserPermissions(user.Id);

    //    var roleId = await _userReadRepository.GetUserRoleId(user.Id);

    //    //var allPermissionRoutes = await _permissionRepository.GetAll();

    //    //List<string> permissionRoutes = new List<string>();
    //    //List<Guid> permissionIds = new List<Guid>();


    //    var claims = new List<Claim>
    //            {
    //                new Claim ("UserId", user.Id.ToString()),
    //                new Claim ("UserName",  user.UserName),
    //                //new Claim ("PermissionRoutes",  JsonConvert.SerializeObject(permissionRoutes)),
    //                //new Claim ("AllPermissionRoutes",  JsonConvert.SerializeObject(allPermissionRoutes))
    //            };

    //    bool isSourceStoreCompanyUser = false;

    //    if (roleId != null)
    //    {
    //        if (roleId == Guid.Parse("A114CBE3-A5C6-41C1-BF5F-08DC457FAB6B"))
    //        {
    //            var cargoOwnerId = await _cargoOwnerRepository.GetUserCargoOwenerId(user.Id);
    //            if (cargoOwnerId != null)
    //            {
    //                claims.Add(new Claim("CargoOwnerId", cargoOwnerId.ToString()));
    //            }
    //            else
    //            {
    //                response.IsSuccess = false;
    //                response.Message = "مجاز به ورود نمی باشید";

    //                return response;
    //            }
    //        }
    //        else if (roleId == Guid.Parse("17A4D114-433B-49E7-907F-41837AA49A38"))
    //        {
    //            var companyInternalTransferId = await _companyInternalTransferRepository.GetUserComapanyInternalTransferId(user.Id);

    //            if (companyInternalTransferId != null)
    //            {
    //                claims.Add(new Claim("CompanyInternalTransferId", companyInternalTransferId.ToString()));
    //            }
    //            else
    //            {
    //                response.IsSuccess = false;
    //                response.Message = "مجاز به ورود نمی باشید";

    //                return response;
    //            }
    //        }
    //        else if (roleId == Guid.Parse("C3E6EF47-1E2F-4C0C-8819-F92A83037DA7"))
    //        {
    //            var truckIds = await _truckReadRepository.GetUserTruckIds(user.Id);

    //            if (truckIds.Count() > 0)
    //            {
    //                claims.Add(new Claim("TruckIds", JsonConvert.SerializeObject(truckIds)));
    //            }
    //            else
    //            {
    //                response.IsSuccess = false;
    //                response.Message = "مجاز به ورود نمی باشید";

    //                return response;
    //            }
    //        }
    //        else if (roleId == Guid.Parse("48B4A641-EE12-489E-AD9C-66FC187EB253") || roleId == Guid.Parse("A44C2330-EFCF-4976-94B1-7C434DD200C3"))
    //        {

    //            var destinationStoreId = await _destinationStoreRepository.GetUserDestinationStoreId(user.Id);

    //            if (destinationStoreId != null)
    //            {
    //                claims.Add(new Claim("DestinationStoreId", destinationStoreId.ToString()));
    //            }
    //            else
    //            {
    //                response.IsSuccess = false;
    //                response.Message = "مجاز به ورود نمی باشید";

    //                return response;
    //            }
    //        }
    //        else if (roleId == Guid.Parse("CD10402B-0C73-4141-B8C1-BACD42FC2E16"))
    //        {

    //            var sourceStoreCompanyId = await _sourceStoreCompanyRepository.GetUserSourceStoreCompanyId(user.Id);
    //            var as_StoreId = await _userStoreRepository.GetUserStoreId(user.Id);

    //            if (sourceStoreCompanyId != null)
    //            {
    //                isSourceStoreCompanyUser = true;
    //                claims.Add(new Claim("SourceStoreCompanyId", sourceStoreCompanyId.ToString()));
    //            }
    //            else if (as_StoreId != null)
    //            {
    //                claims.Add(new Claim("AS_StoreId", as_StoreId.ToString()));
    //            }
    //            else
    //            {
    //                response.IsSuccess = false;
    //                response.Message = "مجاز به ورود نمی باشید";

    //                return response;
    //            }
    //        }
    //    }

    //    else
    //    {
    //        response.IsSuccess = false;
    //        response.Message = "مجاز به ورود نمی باشید";

    //        return response;
    //    }


    //    var tokenGenerateResult = await _accountService.GenerateToken(user, claims);


    //    response.IsSuccess = true;
    //    response.Message = "ورود با موفقیت انجام شد";

    //    response.Data = new LoginResponseDto
    //    {
    //        Token = tokenGenerateResult.Token,
    //        RoleId = roleId,
    //        IsSourceStoreCompanyUser = isSourceStoreCompanyUser,
    //        Permissions = userPermissions.ToModel()
    //    };

    //    return response;
    //}
    public async Task<ResponseMessage> Handle(SendVerificationCodeCommand request, CancellationToken cancellationToken)
    {
        var response = new ResponseMessage();
        try
        {
            request.Username = request.Username.DecryptData(_configuration);
            request.Password = request.Password.DecryptData(_configuration);
            request.CaptchaCode = request.CaptchaCode.DecryptData(_configuration);

            if (Captcha.ValidateCaptcha(request.CaptchaCode, request.CaptchaCodeEncode) == false)
            {

                response.IsSuccess = false;
                response.Message = "کدامنیتی وارد شده معتبر نمی باشد";
                return response;
            }

            var user = await _userManager.FindByNameAsync(request.Username);
            if (user == null) { return new ResponseMessage(false, "نام کاربری یا رمز عبور صحیح نمی باشد"); }

            bool checkPassword = await _userManager.CheckPasswordAsync(user, request.Password);

            if (checkPassword != true)
                return new ResponseMessage(false, "نام کاربری یا رمز عبور صحیح نمی باشد");

            Random random = new Random();

            string code = random.Next(111111, 999999).ToString();

            VerificationCode verificationCode = await _verificationCodeRepository.GetByUsernameAsync(request.Username);

            if (verificationCode is null)
                await _verificationCodeRepository.AddAsync(new VerificationCode(request.Username, code, DateTime.Now.AddMinutes(3)));
            else
                verificationCode.Update(code, DateTime.Now.AddMinutes(3));

            await _unitOfWork.Save();

            InfrastructureService.Sms sms = new InfrastructureService.Sms() { MobileNumber = "09356735245", Message = $"کد تایید اوستا {code}" };

            //ارسال از طربق سرویس پیغام رسان
            MessageBrokerHelper.Publish(JsonConvert.SerializeObject(sms), "sms");



            


            response.IsSuccess = true;
            response.Message = "ورود با موفقیت انجام شد";

            response.Content = new LoginResponseDto
            {
               // AccessToken = tokenGenerateResult.Token,
                Roles = new List<string>() { "asd" },
                RefreshToken  = "",
                //Permissions = userPermissions.ToModel()
            };

            return new ResponseMessage(true, "کد تایید ارسال شد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }

    }

    public async Task<ResponseMessage> Handle(CheckVerificationCodeCommand request, CancellationToken cancellationToken)
    {
        VerificationCode verificationCode = await _verificationCodeRepository.GetByUsernameAsync(request.Username);

        if (verificationCode != null && request.VerificationCode == verificationCode.Code && verificationCode.ExpireTime > DateTime.Now)
        {
            User user = await _userManager.FindByNameAsync(request.Username);

            IList<string> roles = await _userManager.GetRolesAsync(user);

            IList<string> permissions = await _roleManager.Roles.Where(x => roles.Contains(x.Name)).Include(x => x.Permissions).SelectMany(x => x.Permissions).Select(x => x.Name).ToListAsync();

            LoginResponseDto dto = new LoginResponseDto()
            {
                IsAuthenticated = true,
                AccessToken = _tokenManagerRepository.GenerateToken(user.Id, user.UserName, roles, permissions),
                RefreshToken = await _tokenManagerRepository.GenerateRefreshTokenAsync(user.Id),
                Roles = roles,
                Permissions = permissions
            };

            return new ResponseMessage(dto);
        }
        else
            return new ResponseMessage("کد وارد شده صحیح نمی باشد");
    }
}

