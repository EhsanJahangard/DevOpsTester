using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.Photo.Commands;
namespace TestApplication.CQRS.Photo.ComamndHandlers;

public class CreatePhotoHandler : IRequestHandler<CreatePhotoCommand, DTOs.Common.BaseResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPhotoReadRepository _PhotoRepositoryRead;
    private readonly IWriteOnlyRepository<TestDomain.Models.Photo> _PhotoRepositoryWrite;
    private readonly IMapper _mapper;
    public CreatePhotoHandler(IUnitOfWork unitOfWork, IPhotoReadRepository PhotoRepositoryRead, IWriteOnlyRepository<TestDomain.Models.Photo> PhotoRepositoryWrite ,  IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _PhotoRepositoryRead = PhotoRepositoryRead;
        _PhotoRepositoryWrite = PhotoRepositoryWrite;
        _mapper = mapper;
    }
    public async Task<DTOs.Common.BaseResponseDto> Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
    {
        try
        {

            var Photo = request.ToModel();
            Photo.UserUpdate = "-";
            Photo.UserCreate = "--";
            await _PhotoRepositoryWrite.AddAsync(Photo);
            await _unitOfWork.Save(cancellationToken);
            return new DTOs.Common.BaseResponseDto { Data = Photo };
        }
        catch (Exception ex)
        {
            return new DTOs.Common.BaseResponseDto(ex);
        }
    }
}
