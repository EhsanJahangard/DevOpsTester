using TestApplication.DTOs.Level;

namespace TestApplication.Contracts.Repositories.Read;

public interface ILevelReadRepository 
{
    Task<GetLevelListDto> GetByTitle(string title, CancellationToken cancellationToken);
}
