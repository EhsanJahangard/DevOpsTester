using IdentityApplication.Contracts.Repositories;
using IdentityApplication.Contracts.UnitOfWork;
using IdentityApplication.CQRS.Authentication.Commands.Login;
using IdentityApplication.DTOs.Login;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApplication.CQRS.Authentication.CommandHandlers;

public class LoginCommandHandler : IRequestHandler<SendVerificationCodeCommand, ResponseMessage>,
    IRequestHandler<CheckVerificationCodeCommand, ResponseMessage>
{
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly ITokenManagerRepository _tokenManagerRepository;
    private readonly IVerificationCodeRepository _verificationCodeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public LoginCommandHandler(UserManager<User> userManager, RoleManager<Role> roleManager, ITokenManagerRepository tokenManagerRepository, IVerificationCodeRepository verificationCodeRepository, IUnitOfWork unitOfWork)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _tokenManagerRepository = tokenManagerRepository;
        _verificationCodeRepository = verificationCodeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ResponseMessage> Handle(SendVerificationCodeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            User user = await _userManager.FindByNameAsync(request.Username);

            bool checkPassword = await _userManager.CheckPasswordAsync(user, request.Password);

            if (checkPassword != true)
                return new ResponseMessage("نام کاربری یا رمز عبور صحیح نمی باشد");

            Random random = new Random();

            string code = random.Next(111111, 999999).ToString();

            VerificationCode verificationCode = await _verificationCodeRepository.GetByUsernameAsync(request.Username);

            if (verificationCode is null)
                await _verificationCodeRepository.AddAsync(new VerificationCode(request.Username, code, DateTime.Now.AddMinutes(3)));
            else
                verificationCode.Update(code, DateTime.Now.AddMinutes(3));

            await _unitOfWork.Save();

            Sms sms = new Sms() { MobileNumber = "09356735245", Message = $"کد تایید اوستا {code}" };

            //MessageBrokerHelper.Publish(JsonConvert.SerializeObject(sms), "sms");

            return new ResponseMessage("کد تایید ارسال شد");
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

            LoginDto dto = new LoginDto()
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

