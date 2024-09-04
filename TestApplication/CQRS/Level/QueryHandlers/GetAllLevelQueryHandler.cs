using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.Level.Queries;

namespace TestApplication.CQRS.Level.QueryHandlers;

public class GetAllLevelQueryHandler : IRequestHandler<GetAllLevelQuery, ResponseMessage>//,
    //IRequestHandler<GetPersonByIdQuery, ResponseMessage>
{
    private ILevelReadRepository _levelReadRepository;

    public GetAllLevelQueryHandler(ILevelReadRepository levelReadRepository)
    {
        _levelReadRepository = levelReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllLevelQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _levelReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("سطحی یافت نشد");
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
    //        var result = await _levelReadRepository.GetByIdAsync(request.Id);

    //        if (result != null)
    //            return new ResponseMessage(result);

    //        return new ResponseMessage("سطحی مورد نظر وجود ندارد");
    //    }
    //    catch (Exception ex)
    //    {
    //        return new ResponseMessage(ex.Message);
    //    }
    //}
}