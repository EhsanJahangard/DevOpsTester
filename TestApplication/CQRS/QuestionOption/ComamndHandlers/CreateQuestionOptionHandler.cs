using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.QuestionOption.Commands;
namespace TestApplication.CQRS.QuestionOption.ComamndHandlers;

public class CreateQuestionOptionHandler : IRequestHandler<CreateQuestionOptionCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IQuestionOptionReadRepository _QuestionOptionRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.QuestionOption> _QuestionOptionRepositoryWrite;
    private readonly IMapper _mapper;
    public CreateQuestionOptionHandler(IUnitOfWork unitOfWork, IQuestionOptionReadRepository QuestionOptionRepositoryRead, IWriteOnlyRepository<TestDomain.Models.QuestionOption> QuestionOptionRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _QuestionOptionRepositoryRead = QuestionOptionRepositoryRead;
        _QuestionOptionRepositoryWrite = QuestionOptionRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreateQuestionOptionCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var QuestionOption = request.ToModel();
            QuestionOption.UserUpdate = "-";
            QuestionOption.UserCreate = "--";
            await _QuestionOptionRepositoryWrite.AddAsync(QuestionOption);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = QuestionOption };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
