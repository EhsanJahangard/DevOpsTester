using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.Skill.Commands;
namespace TestApplication.CQRS.Skill.ComamndHandlers;

public class CreateSkillHandler : IRequestHandler<CreateSkillCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISkillReadRepository _SkillRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.Skill> _SkillRepositoryWrite;
    private readonly IMapper _mapper;
    public CreateSkillHandler(IUnitOfWork unitOfWork, ISkillReadRepository SkillRepositoryRead, IWriteOnlyRepository<TestDomain.Models.Skill> SkillRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _SkillRepositoryRead = SkillRepositoryRead;
        _SkillRepositoryWrite = SkillRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var Skill = request.ToModel();
            Skill.UserUpdate = "-";
            Skill.UserCreate = "--";
            await _SkillRepositoryWrite.AddAsync(Skill);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = Skill };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
