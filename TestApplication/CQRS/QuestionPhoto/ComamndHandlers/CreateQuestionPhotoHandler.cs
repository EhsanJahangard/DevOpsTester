using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.QuestionPhoto.Commands;
namespace TestApplication.CQRS.QuestionPhoto.ComamndHandlers;

public class CreateQuestionPhotoHandler : IRequestHandler<CreateQuestionPhotoCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IQuestionPhotoReadRepository _QuestionPhotoRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.QuestionPhoto> _QuestionPhotoRepositoryWrite;
    private readonly IMapper _mapper;
    public CreateQuestionPhotoHandler(IUnitOfWork unitOfWork, IQuestionPhotoReadRepository QuestionPhotoRepositoryRead, IWriteOnlyRepository<TestDomain.Models.QuestionPhoto> QuestionPhotoRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _QuestionPhotoRepositoryRead = QuestionPhotoRepositoryRead;
        _QuestionPhotoRepositoryWrite = QuestionPhotoRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreateQuestionPhotoCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var QuestionPhoto = request.ToModel();
            QuestionPhoto.UserUpdate = "-";
            QuestionPhoto.UserCreate = "--";
            await _QuestionPhotoRepositoryWrite.AddAsync(QuestionPhoto);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = QuestionPhoto };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
