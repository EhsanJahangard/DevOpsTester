using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.Convertors.Models;
using TestApplication.CQRS.Level.Commands;
using TestDomain.Models;
namespace TestApplication.CQRS.Level.ComamndHandlers
{
    public class CreateLevelHandler : IRequestHandler<CreateLevelCommand, DTOs.Common.BaseResponseDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILevelReadRepository _levelRepositoryRead;
        private readonly IWriteOnlyRepository<TestDomain.Models.Level> _levelRepositoryWrite;
        private readonly IMapper _mapper;
        public CreateLevelHandler(IUnitOfWork unitOfWork, ILevelReadRepository levelRepositoryRead, IWriteOnlyRepository<TestDomain.Models.Level> levelRepositoryWrite ,  IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _levelRepositoryRead = levelRepositoryRead;
            _levelRepositoryWrite = levelRepositoryWrite;
            _mapper = mapper;
        }
        public async Task<DTOs.Common.BaseResponseDto> Handle(CreateLevelCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var level = request.ToModel();
                level.UserUpdate = "-";
                level.UserCreate = "--";
                await _levelRepositoryWrite.AddAsync(level);
                await _unitOfWork.Save(cancellationToken);
                return new DTOs.Common.BaseResponseDto { Data = level };
            }
            catch (Exception ex)
            {
                return new DTOs.Common.BaseResponseDto(ex);
            }
        }
    }
}
