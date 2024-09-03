using Dapper;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Level;
using TestDomain.Models;

namespace TestPersistence.Impelementations.Repositories.Read
{
    public class LevelReadRepository : ReadOnlyRepository, ILevelReadRepository
    {
        private readonly IDistributedCache _redisCache;
        public LevelReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

        }
        public void Dispose()
        {

        }

        public async Task<Level> Get(Guid id, CancellationToken cancellationToken)
        {
            return null;
        }
        public async Task<List<GetLevelListDto>> GetAll(CancellationToken cancellationToken)
        
        {
            var levelAll = await _redisCache.GetStringAsync("levelgetall");

            if (String.IsNullOrEmpty(levelAll))
            {
                string query = @"
                            SELECT * from Levels
                            ";

              

                var result = await Connection.QueryAsync<GetLevelListDto>(query);

                await _redisCache.SetStringAsync("levelgetall", JsonConvert.SerializeObject(result));


                return result.ToList();
            }
            return JsonConvert.DeserializeObject<List<GetLevelListDto>>(levelAll).ToList();
        }

        public async Task<IEnumerable<GetLevelListDto>> GetAllAsync(Guid LevelId)
        {
           

            var levelAll = await _redisCache.GetStringAsync("levelgetall");

            if (String.IsNullOrEmpty(levelAll))
            {
                string query = @"
                            SELECT * from Levels
                              where Id=@Id
                            ";

                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Id", LevelId);

                var result = await Connection.QueryAsync<GetLevelListDto>(query, dynamicParameters);

                await _redisCache.SetStringAsync("levelgetall", JsonConvert.SerializeObject(result));


                return result.ToList();
            }
            return JsonConvert.DeserializeObject<List<GetLevelListDto>>(levelAll).ToList();

           
        }

        public Task<GetLevelListDto> GetByTitle(string title, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

       
    }
}
