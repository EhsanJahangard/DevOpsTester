using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace AuthenticationService.Attributes
{
    public class PermissionAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private string _accessToken;

        public PermissionAttribute(string permission)
        {
            Permission = permission;
        }

        public string Permission { get; set; }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _accessToken = context.HttpContext.Request.Headers["Authorization"].ToString();

            ClaimsPrincipal claimsPrincipal = DecodeToken(_accessToken);

            if (claimsPrincipal != null)
            {
                var userPermissions = claimsPrincipal.Claims.Where(x => x.Type == "UserPermissions").Select(x => x.Value).FirstOrDefault();

                var permissions = JsonSerializer.Deserialize<IList<string>>(userPermissions);

                if(!permissions.Contains(Permission))
                    context.Result = new UnauthorizedResult();               
            }
            else
                context.Result = new UnauthorizedResult();
        }

        private ClaimsPrincipal DecodeToken(string token)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            var tokenHandler = new JwtSecurityTokenHandler();

            var validationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                RequireAudience = true,
                RequireExpirationTime = true,
                ValidAudience = configuration.GetSection("Jwt:Audience").Value,
                ValidIssuer = configuration.GetSection("Jwt:Issuer").Value,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("Jwt:SignKey").Value)),
                TokenDecryptionKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("Jwt:EncryptKey").Value)),
            };

            return tokenHandler.ValidateToken(token.Replace("Bearer", string.Empty).Trim(), validationParameters, out SecurityToken validatedToken);
        }
    }
}
