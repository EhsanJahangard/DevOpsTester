using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.Level.Commands
{
    public class CreateLevelCommand : IRequest<BaseResponseDto>
    {
        public string Title { get; set; }
    }
}
