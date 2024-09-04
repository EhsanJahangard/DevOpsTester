using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Level;
using TestDomain.Models;


namespace TestPersistence.Impelementations.Repositories.Read;

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
        var cacheKey = "levelgetall";
        
        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
       async () =>
       {
           // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
           string query = @"SELECT TOP 3 convert(nvarchar(40),[Id]) as LevelId,[UserCreate],[Title] FROM [dbo].[Levels]";
           var result = await Connection.QueryAsync<GetLevelListDto>(query);

           return result.ToList();
       }, cacheOptions)!;


        return res.ToList();


    }

    public async Task<IEnumerable<GetLevelListDto>> GetAllAsync(Guid LevelId)
    {


      
        return null;

    }

    public Task<GetLevelListDto> GetByTitle(string title, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }


}
