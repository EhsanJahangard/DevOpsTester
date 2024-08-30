using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityDomain.Models;


public class RefreshToken
{
    public RefreshToken(Guid userId, DateTime expireTime)
    {
        UserId = userId;
        RefreshTokenId = Guid.NewGuid();
        ExpireTime = expireTime;
    }

    public Guid UserId { get; private set; }
    public Guid RefreshTokenId { get; private set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime ExpireTime { get; private set; }

    public void Update(RefreshToken refreshToken)
    {
        RefreshTokenId = refreshToken.RefreshTokenId;
        ExpireTime = refreshToken.ExpireTime;
    }
}

