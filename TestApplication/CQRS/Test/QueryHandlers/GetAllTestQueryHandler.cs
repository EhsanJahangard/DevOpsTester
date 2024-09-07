using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.Test.Queries;

namespace TestApplication.CQRS.Test.QueryHandlers;

public class GetAllTestQueryHandler : IRequestHandler<GetAllTestQuery, ResponseMessage>//,
    //IRequestHandler<GetTestByIdQuery, ResponseMessage>
{
    private ITestReadRepository _TestReadRepository;

    public GetAllTestQueryHandler(ITestReadRepository TestReadRepository)
    {
        _TestReadRepository = TestReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllTestQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _TestReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("آزمونی یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetTestByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _TestReadRepository.GetByIdAsync(request.Id);

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