using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.QuestionPhoto.Queries;

namespace TestApplication.CQRS.QuestionPhoto.QueryHandlers;

public class GetAllQuestionPhotoQueryHandler : IRequestHandler<GetAllQuestionPhotoQuery, ResponseMessage>//,
    //IRequestHandler<GetQuestionByIdQuery, ResponseMessage>
{
    private IQuestionPhotoReadRepository _QuestionPhotoReadRepository;

    public GetAllQuestionPhotoQueryHandler(IQuestionPhotoReadRepository QuestionPhotoReadRepository)
    {
        _QuestionPhotoReadRepository = QuestionPhotoReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllQuestionPhotoQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _QuestionPhotoReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("موردی یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetQuestionByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _QuestionReadRepository.GetByIdAsync(request.Id);

    //        if (result != null)
    //            return new ResponseMessage(result);

    //        return new ResponseMessage("موردی وجود ندارد");
    //    }
    //    catch (Exception ex)
    //    {
    //        return new ResponseMessage(ex.Message);
    //    }
    //}
}