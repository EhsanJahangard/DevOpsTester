using TestApplication.DTOs.QuestionOption;

namespace TestApplication.Contracts.Repositories.Read;

public interface IQuestionOptionReadRepository
{
    Task<GetQuestionOptionListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<List<GetQuestionOptionListDto>> GetAll(CancellationToken cancellationToken);
}