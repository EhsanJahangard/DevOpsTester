using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Level;
using TestDomain.Models;

namespace TestPersistence.Impelementations.Repositories.Read
{
    public class LevelReadRepository : ReadOnlyRepository, ILevelReadRepository
    {
        public LevelReadRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public void Dispose()
        {

        }

        public async Task<Level> Get(Guid id, CancellationToken cancellationToken)
        {
            return null;
        }

        public async Task<List<Level>> GetAll(CancellationToken cancellationToken)
        {
            return null;
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

        public Task<GetLevelListDto> GetByTitle(string title, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
