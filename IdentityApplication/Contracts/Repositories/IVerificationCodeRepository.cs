using IdentityDomain.Models;

namespace IdentityApplication.Contracts.Repositories;

public interface IVerificationCodeRepository
{
    Task AddAsync(VerificationCode verificationCode);
    Task<VerificationCode> GetByUsernameAsync(string username);
}
