using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.Master.Commands;
namespace TestApplication.CQRS.Master.ComamndHandlers;

public class CreateMasterHandler : IRequestHandler<CreateMasterCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMasterReadRepository _MasterRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.Master> _MasterRepositoryWrite;
    private readonly IMapper _mapper;
    public CreateMasterHandler(IUnitOfWork unitOfWork, IMasterReadRepository MasterRepositoryRead, IWriteOnlyRepository<TestDomain.Models.Master> MasterRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _MasterRepositoryRead = MasterRepositoryRead;
        _MasterRepositoryWrite = MasterRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreateMasterCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var Master = request.ToModel();
            Master.UserUpdate = "-";
            Master.UserCreate = "--";
            await _MasterRepositoryWrite.AddAsync(Master);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = Master };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
