using IdentityDomain.Models;
using IdentityApplication.DTOs.Login;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using IdentityApplication.Contracts.Repositories;
namespace IdentityPersistence.Impelementations.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly UserManager<User> _userManager;
    private readonly JwtSettings _jwtSettings;

    public AccountRepository(UserManager<User> userManager, IOptions<JwtSettings> jwtSettings)
    {
        _userManager = userManager;
        _jwtSettings = jwtSettings.Value;
    }

    public async Task<GenerateTokenDto> GenerateToken(User user, List<Claim> claims)
    {

        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        var tokenexp = DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes);

        var encryptingCredentials = new EncryptingCredentials(symmetricSecurityKey, SecurityAlgorithms.Aes256KW, SecurityAlgorithms.Aes256CbcHmacSha512);

        var handler = new JwtSecurityTokenHandler();


        var jwtSecurityToken = handler.CreateJwtSecurityToken(
_jwtSettings.Issuer,
_jwtSettings.Audience,
new ClaimsIdentity(claims), notBefore: DateTime.Now,
tokenexp, DateTime.UtcNow, signingCredentials, encryptingCredentials
);


        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

        return new GenerateTokenDto
        {
            Token = token
        };
    }
}