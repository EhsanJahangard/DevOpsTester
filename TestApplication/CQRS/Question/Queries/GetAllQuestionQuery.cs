using InfrastructureService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.CQRS.Question.Queries;

public class GetAllQuestionQuery : IRequest<ResponseMessage>
{
}