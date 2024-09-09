using TestApplication.DTOs.TestResult;

namespace TestApplication.Contracts.Repositories.Read;

public interface ITestResultReadRepository
{
    Task<GetTestResultListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<List<GetTestResultListDto>> GetAll(CancellationToken cancellationToken);
}

