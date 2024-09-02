using Dapper;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Level;
using TestDomain.Models;

namespace TestPersistence.Impelementations.Repositories.Read
{
    public class LevelReadRepository : ReadOnlyRepository, ILevelReadRepository
    {
        private readonly IDistributedCache _redisCache;
        public LevelReadRepository(IConfiguration configuration,IDistributedCache redisCache) : base(configuration)
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

        public async Task<List<Level>> GetAll(CancellationToken cancellationToken)
        {
            return null;
        }

        public async Task<IEnumerable<GetLevelListDto>> GetAllAsync(Guid LevelId)
        {
            //var basket = await _redisCache.GetStringAsync(LevelId.ToString()) ;
            //await _redisCache.SetStringAsync(basket.UserName, JsonConvert.SerializeObject(basket));
            //            await _redisCache.RemoveAsync(userName);


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
