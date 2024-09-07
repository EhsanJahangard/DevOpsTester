using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Master;
using TestDomain.Models;


namespace TestPersistence.Impelementations.Repositories.Read;

public class MasterReadRepository : ReadOnlyRepository, IMasterReadRepository
{
    private readonly IDistributedCache _redisCache;
    public MasterReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
    {
        _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

    }
    public void Dispose()
    {

    }

    public async Task<List<GetMasterListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "Mastergetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @"SELECT TOP 3 convert(nvarchar(40),[Id]) as MasterId,[Name],[Family],[DateBirth],[Mobile] FROM [dbo].[Masters]";
                               var result = await Connection.QueryAsync<GetMasterListDto>(query);

                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();


    }


    public async Task<GetMasterListDto>  GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
