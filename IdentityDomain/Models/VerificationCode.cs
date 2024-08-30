using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityDomain.Models;


public class VerificationCode
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Code { get; set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime ExpireTime { get; set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime CreateDate { get; set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime UpdateDate { get; set; }
    private VerificationCode() { }

    public VerificationCode(string username, string code, DateTime expireTime)
    {
        Username = username;
        Code = code;
        ExpireTime = expireTime.ToUniversalTime();
        CreateDate = DateTime.Now;
        UpdateDate = DateTime.Now;
    }

    public void Update(string code, DateTime expireTime)
    {
        Code = code;
        ExpireTime = expireTime.ToUniversalTime();
        UpdateDate = DateTime.Now;
    }
}

