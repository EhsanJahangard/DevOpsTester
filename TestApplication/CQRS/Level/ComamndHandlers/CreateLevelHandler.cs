using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.UnitOfWork;
using TestApplication.CQRS.Level.Commands;
using TestDomain.Models;
namespace TestApplication.CQRS.Level.ComamndHandlers
{
    public  class CreateLevelHandler : IRequestHandler<CreateLevelCommand, Dtos.Common.BaseResponseDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILevelReadRepository _levelRepository;
        private readonly IMapper _mapper;
        public CreateLevelHandler(IUnitOfWork unitOfWork, ILevelReadRepository levelRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _levelRepository = levelRepository;
            _mapper = mapper;
        }
        public async Task<Dtos.Common.BaseResponseDto> Handle(CreateLevelCommand request, CancellationToken cancellationToken)
        {
            var level = _mapper.Map<TestDomain.Models.Level>(request);
            _levelRepository.Create(level);
            await _unitOfWork.Save(cancellationToken);
            return _mapper.Map<Dtos.Common.BaseResponseDto>(level);
        }
    }
}
