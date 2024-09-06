using InfrastructureService;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.CQRS.Skill.Queries;

namespace TestApplication.CQRS.Skill.QueryHandlers;

public class GetAllSkillQueryHandler : IRequestHandler<GetAllSkillQuery, ResponseMessage>//,
    //IRequestHandler<GetSkillByIdQuery, ResponseMessage>
{
    private ISkillReadRepository _SkillReadRepository;

    public GetAllSkillQueryHandler(ISkillReadRepository SkillReadRepository)
    {
        _SkillReadRepository = SkillReadRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllSkillQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _SkillReadRepository.GetAll(cancellationToken);

            if (result != null)
                return new ResponseMessage(result);

            return new ResponseMessage("سوالی یافت نشد");
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    //public async Task<ResponseMessage> Handle(GetSkillByIdQuery request, CancellationToken cancellationToken)
    //{
    //    try
    //    {
    //        var result = await _SkillReadRepository.GetByIdAsync(request.Id);

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