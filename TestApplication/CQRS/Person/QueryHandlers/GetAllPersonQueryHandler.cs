using InfrastructureService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.Level.Queries;

namespace TestApplication.CQRS.Level.QueryHandlers;

public class GetAllPersonQueryHandler : IRequestHandler<GetAllPersonQuery, ResponseMessage>//,
    //IRequestHandler<GetCargoCategoryByIdQuery, ResponseMessage>
{
    private ILevelReadRepository _levelReadRepository;

    public GetAllPersonQueryHandler(ILevelReadRepository levelReadRepository)
    {
        _levelReadRepository = levelReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllPersonQuery request, CancellationToken cancellationToken)
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

    //public async Task<ResponseMessage> Handle(GetCargoCategoryByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _CargoCategoryReadOnlyRepository.GetByIdAsync(request.Id);

    //        if (result != null)
    //            return new ResponseMessage(result);

    //        return new ResponseMessage("طبقه بندی کالای مورد نظر وجود ندارد");
    //    }
    //    catch (Exception ex)
    //    {
    //        return new ResponseMessage(ex.Message);
    //    }
    //}
}