using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Dtos.Level;

namespace TestPersistence.Impelementations.Repositories.Read
{
    public class LevelReadRepository : ReadOnlyRepository, ILevelReadRepository
    {
        public LevelReadRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<GetLevelListDto>> GetAllAsync(Guid LevelId)
        {
            string query = @"
                            SELECT * from Levels
                              where Id=@Id
                            ";

            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@Id", LevelId);

            var result = await Connection.QueryAsync<GetLevelListDto>(query, dynamicParameters);

            return result.ToList();
        }
    }
}
