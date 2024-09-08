using TestApplication.DTOs.QuestionType;

namespace TestApplication.Contracts.Repositories.Read;

public interface IQuestionTypeReadRepository
{



    Task<GetQuestionTypeListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<List<GetQuestionTypeListDto>> GetAll(CancellationToken cancellationToken);
}
