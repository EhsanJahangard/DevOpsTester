using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.DTOs.Common;
using TestApplication.DTOs.Level;
using TestDomain.Models;

namespace TestApplication.Contracts.Repositories.Read;

public interface ILevelReadRepository 
{
    Task<GetLevelListDto> GetByTitle(string title, CancellationToken cancellationToken);
}
