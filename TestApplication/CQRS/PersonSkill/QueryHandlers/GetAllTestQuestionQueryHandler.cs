using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.PersonSkill.Queries;

namespace TestApplication.CQRS.PersonSkill.QueryHandlers;

public class GetAllPersonSkillQueryHandler : IRequestHandler<GetAllPersonSkillQuery, ResponseMessage>//,
    //IRequestHandler<GetPersonSkillByIdQuery, ResponseMessage>
{
    private IPersonSkillReadRepository _PersonSkillReadRepository;

    public GetAllPersonSkillQueryHandler(IPersonSkillReadRepository PersonSkillReadRepository)
    {
        _PersonSkillReadRepository = PersonSkillReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllPersonSkillQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _PersonSkillReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("سوالی یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetPersonSkillByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _PersonSkillReadRepository.GetByIdAsync(request.Id);

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