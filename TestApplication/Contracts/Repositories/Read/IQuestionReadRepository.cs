using TestApplication.DTOs.Question;

namespace TestApplication.Contracts.Repositories.Read;

public interface IQuestionReadRepository
{
    Task<GetQuestionListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<GetQuestionListDto> GetByLetter(string Letter, CancellationToken cancellationToken);
    Task<List<GetQuestionListDto>> GetAll(CancellationToken cancellationToken);
}
