using TestApplication.DTOs.QuestionPhoto;

namespace TestApplication.Contracts.Repositories.Read;

public interface IQuestionPhotoReadRepository
{



    Task<GetQuestionPhotoListDto> GetById(string Id, CancellationToken cancellationToken);
    Task<List<GetQuestionPhotoListDto>> GetAll(CancellationToken cancellationToken);
}
