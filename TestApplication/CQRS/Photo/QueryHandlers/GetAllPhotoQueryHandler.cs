using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.Photo.Queries;

namespace TestApplication.CQRS.Photo.QueryHandlers;

public class GetAllPhotoQueryHandler : IRequestHandler<GetAllPhotoQuery, ResponseMessage>//,
    //IRequestHandler<GetPhotoByIdQuery, ResponseMessage>
{
    private IPhotoReadRepository _PhotoReadRepository;

    public GetAllPhotoQueryHandler(IPhotoReadRepository PhotoReadRepository)
    {
        _PhotoReadRepository = PhotoReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllPhotoQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _PhotoReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("سوالی یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetPhotoByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _PhotoReadRepository.GetByIdAsync(request.Id);

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