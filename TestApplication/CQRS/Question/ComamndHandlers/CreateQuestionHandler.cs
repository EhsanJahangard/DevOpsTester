using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.Question.Commands;
namespace TestApplication.CQRS.Level.ComamndHandlers
{
    public class CreateQuestionHandler : IRequestHandler<CreateQuestionCommand, DTOs.Common.BaseResponseDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IQuestionReadRepository _QuestionRepositoryRead;
        private readonly IWriteOnlyRepository<TestDomain.Models.Question> _QuestionRepositoryWrite;
        private readonly IMapper _mapper;
        public CreateQuestionHandler(IUnitOfWork unitOfWork, IQuestionReadRepository QuestionRepositoryRead, IWriteOnlyRepository<TestDomain.Models.Question> QuestionRepositoryWrite ,  IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _QuestionRepositoryRead = QuestionRepositoryRead;
            _QuestionRepositoryWrite = QuestionRepositoryWrite;
            _mapper = mapper;
        }
        public async Task<DTOs.Common.BaseResponseDto> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var Question = request.ToModel();
                Question.UserUpdate = "-";
                Question.UserCreate = "--";
                await _QuestionRepositoryWrite.AddAsync(Question);
                await _unitOfWork.Save(cancellationToken);
                return new DTOs.Common.BaseResponseDto { Data = Question };
            }
            catch (Exception ex)
            {
                return new DTOs.Common.BaseResponseDto(ex);
            }
        }
    }
}
