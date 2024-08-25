using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Dtos.Common;
using TestApplication.Dtos.Level;
using TestDomain.Models;

namespace TestApplication.Contracts.Repositories.Read;

public interface ILevelReadRepository : IBaseRepository<Level, Guid>
{
    Task<GetLevelListDto> GetByTitle(string title, CancellationToken cancellationToken);
}
