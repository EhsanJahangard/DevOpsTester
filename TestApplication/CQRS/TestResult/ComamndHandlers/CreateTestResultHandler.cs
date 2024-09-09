using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.TestResult.Commands;
namespace TestApplication.CQRS.TestResult.ComamndHandlers;

public class CreateTestResultHandler : IRequestHandler<CreateTestResultCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITestResultReadRepository _TestResultRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.TestResult> _TestResultRepositoryWrite;
    private readonly IMapper _mapper;
    public CreateTestResultHandler(IUnitOfWork unitOfWork, ITestResultReadRepository TestResultRepositoryRead, IWriteOnlyRepository<TestDomain.Models.TestResult> TestResultRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _TestResultRepositoryRead = TestResultRepositoryRead;
        _TestResultRepositoryWrite = TestResultRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreateTestResultCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var TestResult = request.ToModel();
            TestResult.UserUpdate = "-";
            TestResult.UserCreate = "--";
            await _TestResultRepositoryWrite.AddAsync(TestResult);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = TestResult };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
