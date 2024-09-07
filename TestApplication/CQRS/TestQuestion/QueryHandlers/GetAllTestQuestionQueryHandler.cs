using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.TestQuestion.Queries;

namespace TestApplication.CQRS.TestQuestion.QueryHandlers;

public class GetAllTestQuestionQueryHandler : IRequestHandler<GetAllTestQuestionQuery, ResponseMessage>//,
    //IRequestHandler<GetTestQuestionByIdQuery, ResponseMessage>
{
    private ITestQuestionReadRepository _TestQuestionReadRepository;

    public GetAllTestQuestionQueryHandler(ITestQuestionReadRepository TestQuestionReadRepository)
    {
        _TestQuestionReadRepository = TestQuestionReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllTestQuestionQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _TestQuestionReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("سوالی یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetTestQuestionByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _TestQuestionReadRepository.GetByIdAsync(request.Id);

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