using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.PersonSkill.Commands;
namespace TestApplication.CQRS.PersonSkill.ComamndHandlers;

public class CreatePersonSkillHandler : IRequestHandler<CreatePersonSkillCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPersonSkillReadRepository _PersonSkillRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.PersonSkill> _PersonSkillRepositoryWrite;
    private readonly IMapper _mapper;
    public CreatePersonSkillHandler(IUnitOfWork unitOfWork, IPersonSkillReadRepository PersonSkillRepositoryRead, IWriteOnlyRepository<TestDomain.Models.PersonSkill> PersonSkillRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _PersonSkillRepositoryRead = PersonSkillRepositoryRead;
        _PersonSkillRepositoryWrite = PersonSkillRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreatePersonSkillCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var PersonSkill = request.ToModel();
            PersonSkill.UserUpdate = "-";
            PersonSkill.UserCreate = "--";
            await _PersonSkillRepositoryWrite.AddAsync(PersonSkill);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = PersonSkill };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
