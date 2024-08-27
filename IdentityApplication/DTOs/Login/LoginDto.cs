namespace IdentityApplication.DTOs.Login;

public class LoginDto
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public IList<string> Roles { get; set; }
    public IList<string> Permissions { get; set; }
    public bool IsAuthenticated { get; set; }
}
