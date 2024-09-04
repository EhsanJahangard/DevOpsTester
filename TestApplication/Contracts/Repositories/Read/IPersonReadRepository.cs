using TestApplication.DTOs.Person;

namespace TestApplication.Contracts.Repositories.Read;

public interface IPersonReadRepository
{
    Task<GetPersonListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<GetPersonListDto> GetByFamily(string Family, CancellationToken cancellationToken);
    Task<List<GetPersonListDto>> GetAll(CancellationToken cancellationToken);
}
