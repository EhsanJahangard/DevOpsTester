using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.TestQuestion.Commands;
namespace TestApplication.CQRS.TestQuestion.ComamndHandlers;

public class CreateTestQuestionHandler : IRequestHandler<CreateTestQuestionCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITestQuestionReadRepository _TestQuestionRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.TestQuestion> _TestQuestionRepositoryWrite;
    private readonly IMapper _mapper;
    public CreateTestQuestionHandler(IUnitOfWork unitOfWork, ITestQuestionReadRepository TestQuestionRepositoryRead, IWriteOnlyRepository<TestDomain.Models.TestQuestion> TestQuestionRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _TestQuestionRepositoryRead = TestQuestionRepositoryRead;
        _TestQuestionRepositoryWrite = TestQuestionRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreateTestQuestionCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var TestQuestion = request.ToModel();
            TestQuestion.UserUpdate = "-";
            TestQuestion.UserCreate = "--";
            await _TestQuestionRepositoryWrite.AddAsync(TestQuestion);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = TestQuestion };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
