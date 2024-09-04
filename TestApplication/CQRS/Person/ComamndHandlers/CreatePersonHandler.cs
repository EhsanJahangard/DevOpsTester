using AutoMapper;
using MediatR;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.Level.Commands;
namespace TestApplication.CQRS.Level.ComamndHandlers
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, DTOs.Common.BaseResponseDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPersonReadRepository _personRepositoryRead;
        private readonly IWriteOnlyRepository<TestDomain.Models.Person> _personRepositoryWrite;
        private readonly IMapper _mapper;
        public CreatePersonHandler(IUnitOfWork unitOfWork, IPersonReadRepository personRepositoryRead, IWriteOnlyRepository<TestDomain.Models.Person> personRepositoryWrite ,  IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _personRepositoryRead = personRepositoryRead;
            _personRepositoryWrite = personRepositoryWrite;
            _mapper = mapper;
        }
        public async Task<DTOs.Common.BaseResponseDto> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var person = request.ToModel();
                person.UserUpdate = "-";
                person.UserCreate = "--";
                await _personRepositoryWrite.AddAsync(person);
                await _unitOfWork.Save(cancellationToken);
                return new DTOs.Common.BaseResponseDto { Data = person };
            }
            catch (Exception ex)
            {
                return new DTOs.Common.BaseResponseDto(ex);
            }
        }
    }
}
