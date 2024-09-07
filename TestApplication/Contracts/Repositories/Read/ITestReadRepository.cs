using TestApplication.DTOs.Test;

namespace TestApplication.Contracts.Repositories.Read;

public interface ITestReadRepository
{
    Task<GetTestListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<List<GetTestListDto>> GetAll(CancellationToken cancellationToken);
}

