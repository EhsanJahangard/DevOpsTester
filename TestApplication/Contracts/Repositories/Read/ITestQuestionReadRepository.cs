using TestApplication.DTOs.TestQuestion;

namespace TestApplication.Contracts.Repositories.Read;

public interface ITestQuestionReadRepository
{
    Task<GetTestQuestionListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<GetTestQuestionListDto> GetByQuestionId(string Id, CancellationToken cancellationToken);
    Task<GetTestQuestionListDto> GetByTestId(string Id, CancellationToken cancellationToken);
    Task<List<GetTestQuestionListDto>> GetAll(CancellationToken cancellationToken);
}

