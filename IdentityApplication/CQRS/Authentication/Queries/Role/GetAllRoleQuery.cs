using InfrastructureService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApplication.CQRS.Authentication.Queries.Role;

public class GetAllRoleQuery : IRequest<ResponseMessage>
{
}
