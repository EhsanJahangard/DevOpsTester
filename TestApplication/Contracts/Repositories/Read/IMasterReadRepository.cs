using TestApplication.DTOs.Master;

namespace TestApplication.Contracts.Repositories.Read;

public interface IMasterReadRepository
{
    Task<GetMasterListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<List<GetMasterListDto>> GetAll(CancellationToken cancellationToken);
}



