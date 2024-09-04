using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.Question.Queries;

namespace TestApplication.CQRS.Question.QueryHandlers;

public class GetAllQuestionQueryHandler : IRequestHandler<GetAllQuestionQuery, ResponseMessage>//,
    //IRequestHandler<GetQuestionByIdQuery, ResponseMessage>
{
    private IQuestionReadRepository _QuestionReadRepository;

    public GetAllQuestionQueryHandler(IQuestionReadRepository QuestionReadRepository)
    {
        _QuestionReadRepository = QuestionReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllQuestionQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _QuestionReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("سوالی یافت نشد");
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

    //        return new ResponseMessage("شخص مورد نظر وجود ندارد");
    //    }
    //    catch (Exception ex)
    //    {
    //        return new ResponseMessage(ex.Message);
    //    }
    //}
}