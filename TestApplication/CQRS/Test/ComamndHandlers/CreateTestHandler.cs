using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.Test.Commands;
namespace TestApplication.CQRS.Test.ComamndHandlers;

public class CreateTestHandler : IRequestHandler<CreateTestCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITestReadRepository _TestRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.Test> _TestRepositoryWrite;
    private readonly IMapper _mapper;
    public CreateTestHandler(IUnitOfWork unitOfWork, ITestReadRepository TestRepositoryRead, IWriteOnlyRepository<TestDomain.Models.Test> TestRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _TestRepositoryRead = TestRepositoryRead;
        _TestRepositoryWrite = TestRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreateTestCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var Test = request.ToModel();
            Test.UserUpdate = "-";
            Test.UserCreate = "--";
            await _TestRepositoryWrite.AddAsync(Test);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = Test };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
