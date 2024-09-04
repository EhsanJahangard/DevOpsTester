using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.Level.Queries;

namespace TestApplication.CQRS.Level.QueryHandlers;

public class GetAllPersonQueryHandler : IRequestHandler<GetAllPersonQuery, ResponseMessage>//,
    //IRequestHandler<GetPersonByIdQuery, ResponseMessage>
{
    private IPersonReadRepository _personReadRepository;

    public GetAllPersonQueryHandler(IPersonReadRepository personReadRepository)
    {
        _personReadRepository = personReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllPersonQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _personReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("شخص یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _personReadRepository.GetByIdAsync(request.Id);

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