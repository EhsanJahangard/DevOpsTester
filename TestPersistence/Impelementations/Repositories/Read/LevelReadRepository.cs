using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Contracts.Repositories.ReadWrite;
using TestApplication.Dtos.Level;
using TestDomain.Models;

namespace TestPersistence.Impelementations.Repositories.Read
{
    public class LevelReadRepository : ReadOnlyRepository, ILevelRepository
    {
        public LevelReadRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Create(Level entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Level entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Level> Get(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Level>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
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

        public void Update(Level entity)
        {
            throw new NotImplementedException();
        }
    }
}
