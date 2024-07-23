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
                            SELECT 
                              cargo_base.Id,cargo_base.Title,cargo_base.InsertTime,cdeclare_status.Title as Status
                              FROM CargoDeclarationBases cargo_base
                              inner join CargoDeclarationBaseStatuses cdeclare_status on cdeclare_status.Id = cargo_base.CargoDeclarationBaseStatusId
                              where cargo_base.CargoOwnerId=@CargoOwnerId
                            ";

            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@CargoOwnerId", LevelId);

            var result = await Connection.QueryAsync<GetLevelListDto>(query, dynamicParameters);

            return result.ToList();
        }
    }
}
