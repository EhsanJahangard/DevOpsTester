using TestApplication.DTOs.PersonSkill;

namespace TestApplication.Contracts.Repositories.Read;

public interface IPersonSkillReadRepository
{
    Task<GetPersonSkillListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<GetPersonSkillListDto> GetByQuestionId(string Id, CancellationToken cancellationToken);
    Task<GetPersonSkillListDto> GetByTestId(string Id, CancellationToken cancellationToken);
    Task<List<GetPersonSkillListDto>> GetAll(CancellationToken cancellationToken);
}

