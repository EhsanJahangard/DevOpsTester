using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Contracts.Repositories;
using TestApplication.Dtos.Common;
using TestApplication.Dtos.Level;
using TestDomain.Models;

namespace TestApplication.Contracts.Repositories.ReadWrite;

public interface ILevelRepository : IBaseRepository<Level, Guid>
{
    Task<GetLevelListDto> GetByTitle(string title, CancellationToken cancellationToken);
}
