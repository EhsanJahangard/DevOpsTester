using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Dtos.Level;

namespace TestApplication.Contracts.Repositories.Read
{
    public interface ILevelReadRepository : IReadOnlyRepository
    {
        Task<IEnumerable<GetLevelListDto>> GetAllAsync(Guid LevelId);
    }
}
