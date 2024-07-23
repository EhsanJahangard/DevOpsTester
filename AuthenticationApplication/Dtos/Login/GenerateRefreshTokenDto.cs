namespace AuthenticationApplication.Dtos.Login
{
    public class GenerateRefreshTokenDto
    {
        public string AccessToken { get; set; } 
        public string RefreshToken { get; set; }
    }
}
