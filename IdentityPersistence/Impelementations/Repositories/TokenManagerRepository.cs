using IdentityDomain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using IdentityApplication.Contracts.UnitOfWork;
using IdentityApplication.Contracts.Repositories;
using System.Text.Json;
namespace IdentityPersistence.Impelementations.Repositories;

public class TokenManagerRepository : ITokenManagerRepository
{
    private readonly IConfiguration _configuration;
    private readonly IRefreshTokenRepository _refreshToken;
    private readonly IUnitOfWork _unitOfWork;

    public TokenManagerRepository(IConfiguration configuration, IRefreshTokenRepository refreshToken, IUnitOfWork unitOfWork)
    {
        _configuration = configuration;
        _refreshToken = refreshToken;
        _unitOfWork = unitOfWork;
    }

    public string GenerateToken(string userId, string username, IList<string> userRoles, IList<string> userPermissions)
    {
        var claims = new[]
        {
            new Claim("UserId",userId),
            new Claim("UserRoles",JsonSerializer.Serialize(userRoles)),
            new Claim("UserPermissions",JsonSerializer.Serialize(userPermissions)),
            new Claim(ClaimTypes.Name,username),
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateJwtSecurityToken(new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Issuer = _configuration["Jwt:Issuer"],
            Audience = _configuration["Jwt:Audience"],
            IssuedAt = DateTime.UtcNow,
            Expires = DateTime.UtcNow.AddMinutes(Convert.ToInt16(_configuration["Jwt:TokenTime"])),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SignKey"])), SecurityAlgorithms.HmacSha512),
            EncryptingCredentials = new EncryptingCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:EncryptKey"])), SecurityAlgorithms.Aes256KW, SecurityAlgorithms.Aes256CbcHmacSha512),
        });

        string result = tokenHandler.WriteToken(token);

        return "Bearer " + result;
    }

    public async Task<string> GenerateRefreshTokenAsync(string userId)
    {
        RefreshToken refreshToken = await _refreshToken.GetByUserIdAsync(Guid.Parse(userId));

        RefreshToken newRefreshToken = new RefreshToken(Guid.Parse(userId), DateTime.Now.AddMinutes(Convert.ToInt16(_configuration["Jwt:RefreshTokenTime"])));

        if (refreshToken != null)
            refreshToken.Update(newRefreshToken);
        else
            await _refreshToken.AddAsync(newRefreshToken);

        await _unitOfWork.Save();

        return newRefreshToken.RefreshTokenId.ToString();
    }

    public ClaimsPrincipal DecodeToken(string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var validationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = false,
                RequireAudience = true,
                RequireExpirationTime = true,
                ValidAudience = _configuration["Jwt:Audience"],
                ValidIssuer = _configuration["Jwt:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SignKey"])),
                TokenDecryptionKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:EncryptKey"])),
            };

            return tokenHandler.ValidateToken(token.Replace("Bearer", string.Empty).Trim(), validationParameters, out SecurityToken validatedToken);
        }
        catch
        {
            return null;
        }
    }

    public async Task<bool> IsValidRefreshTokenAsync(string inputRefreshToken, string userId)
    {
        RefreshToken refreshToken = await _refreshToken.GetByUserIdAsync(Guid.Parse(userId));

        if (refreshToken.RefreshTokenId == Guid.Parse(inputRefreshToken) && refreshToken.ExpireTime > DateTime.Now)
            return true;

        return false;
    }
}
