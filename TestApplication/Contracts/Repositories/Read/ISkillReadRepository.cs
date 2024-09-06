using TestApplication.DTOs.Skill;

namespace TestApplication.Contracts.Repositories.Read;

public interface ISkillReadRepository
{
    Task<GetSkillListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<GetSkillListDto> GetByLetter(string Letter, CancellationToken cancellationToken);
    Task<List<GetSkillListDto>> GetAll(CancellationToken cancellationToken);
}
