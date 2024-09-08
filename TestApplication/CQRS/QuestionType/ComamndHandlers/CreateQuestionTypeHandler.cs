using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.QuestionType.Commands;
namespace TestApplication.CQRS.QuestionType.ComamndHandlers;

public class CreateQuestionTypeHandler : IRequestHandler<CreateQuestionTypeCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IQuestionTypeReadRepository _QuestionTypeRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.QuestionType> _QuestionTypeRepositoryWrite;
    private readonly IMapper _mapper;
    public CreateQuestionTypeHandler(IUnitOfWork unitOfWork, IQuestionTypeReadRepository QuestionTypeRepositoryRead, IWriteOnlyRepository<TestDomain.Models.QuestionType> QuestionTypeRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _QuestionTypeRepositoryRead = QuestionTypeRepositoryRead;
        _QuestionTypeRepositoryWrite = QuestionTypeRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreateQuestionTypeCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var QuestionType = request.ToModel();
            QuestionType.UserUpdate = "-";
            QuestionType.UserCreate = "--";
            await _QuestionTypeRepositoryWrite.AddAsync(QuestionType);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = QuestionType };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
