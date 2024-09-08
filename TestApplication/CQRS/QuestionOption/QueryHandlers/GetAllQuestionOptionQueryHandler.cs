using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.QuestionOption.Queries;

namespace TestApplication.CQRS.QuestionOption.QueryHandlers;

public class GetAllQuestionOptionQueryHandler : IRequestHandler<GetAllQuestionOptionQuery, ResponseMessage>//,
    //IRequestHandler<GetQuestionByIdQuery, ResponseMessage>
{
    private IQuestionOptionReadRepository _questionOptionReadRepository;

    public GetAllQuestionOptionQueryHandler(IQuestionOptionReadRepository questionOptionReadRepository)
    {
        _questionOptionReadRepository = questionOptionReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllQuestionOptionQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _questionOptionReadRepository.GetAll(cancellationToken);

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