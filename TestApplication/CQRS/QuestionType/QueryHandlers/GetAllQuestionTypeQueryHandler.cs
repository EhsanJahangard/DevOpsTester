using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.QuestionType.Queries;

namespace TestApplication.CQRS.QuestionType.QueryHandlers;

public class GetAllQuestionTypeQueryHandler : IRequestHandler<GetAllQuestionTypeQuery, ResponseMessage>//,
    //IRequestHandler<GetQuestionTypeByIdQuery, ResponseMessage>
{
    private IQuestionTypeReadRepository _QuestionTypeReadRepository;

    public GetAllQuestionTypeQueryHandler(IQuestionTypeReadRepository QuestionTypeReadRepository)
    {
        _QuestionTypeReadRepository = QuestionTypeReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllQuestionTypeQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _QuestionTypeReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetQuestionTypeByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _QuestionTypeReadRepository.GetByIdAsync(request.Id);

    //        if (result != null)
    //            return new ResponseMessage(result);

    //        return new ResponseMessage("شخص مورد نظر وجود ندارد");
    //    }
    //    catch (Exception ex)
    //    {
    //        return new ResponseMessage(ex.Message);
    //    }
    //}
}