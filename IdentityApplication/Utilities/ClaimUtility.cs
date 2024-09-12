

using System.Security.Claims;

namespace IdentityApplication.Utilities;

public static class ClaimUtility
{
    public static string GetUserCliam(this ClaimsPrincipal User, string claimName)
    {
        var claimsIdentity = User.Identity as ClaimsIdentity;
        return claimsIdentity.FindFirst(claimName).Value;
    }

    public static bool IsAuthenticated(ClaimsPrincipal User)
    {
        return User.Identity.IsAuthenticated;
    }
}
