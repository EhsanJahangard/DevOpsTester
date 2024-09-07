using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Test;


namespace TestPersistence.Impelementations.Repositories.Read;

public class TestReadRepository : ReadOnlyRepository, ITestReadRepository
{
    private readonly IDistributedCache _redisCache;
    public TestReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
    {
        _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

    }
    public void Dispose()
    {

    }



    public Task<GetTestListDto> GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }


    public async Task<List<GetTestListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "Testgetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @"SELECT TOP 100 convert(nvarchar(40),[Id]) as TestId,[Title] FROM [dbo].[Tests]";
                               var result = await Connection.QueryAsync<GetTestListDto>(query);

                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();
    }

    public Task<GetTestListDto> GetByQuestionId(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<GetTestListDto> GetByTestId(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}