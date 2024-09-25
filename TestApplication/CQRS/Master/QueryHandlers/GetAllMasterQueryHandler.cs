using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.Master.Queries;

namespace TestApplication.CQRS.Master.QueryHandlers;

public class GetAllMasterQueryHandler : IRequestHandler<GetAllMasterQuery, ResponseMessage>//,
    //IRequestHandler<GetMasterByIdQuery, ResponseMessage>
{
    private IMasterReadRepository _MasterReadRepository;

    public GetAllMasterQueryHandler(IMasterReadRepository MasterReadRepository)
    {
        _MasterReadRepository = MasterReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllMasterQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _MasterReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("استاد یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetMasterByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _MasterReadRepository.GetByIdAsync(request.Id);

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