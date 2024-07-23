using AuthenticationDomain;

namespace AuthenticationRepository.Repositories.Interfaces
{
    public interface IVerificationCodeRepository
    {
        Task AddAsync(VerificationCode verificationCode);
        Task<VerificationCode> GetByUsernameAsync(string username);
    }
}
