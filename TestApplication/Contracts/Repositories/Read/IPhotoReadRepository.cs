using TestApplication.DTOs.Photo;

namespace TestApplication.Contracts.Repositories.Read;

public interface IPhotoReadRepository
{
    Task<GetPhotoListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<List<GetPhotoListDto>> GetAll(CancellationToken cancellationToken);
}
