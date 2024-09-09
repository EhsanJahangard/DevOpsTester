using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.TestResult;


namespace TestPersistence.Impelementations.Repositories.Read;

public class TestResultReadRepository : ReadOnlyRepository, ITestResultReadRepository
{
    private readonly IDistributedCache _redisCache;
    public TestResultReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
    {
        _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

    }
    public void Dispose()
    {

    }
    public async Task<List<GetTestResultListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "TestResultgetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @" SELECT TOP 100 convert(nvarchar(40),[Id]) as TestResultId,
                                                 [PersonId], DateExam, [TestId],[Grade],
                                                 [Description] FROM [dbo].[TestResults] ";
                               var result = await Connection.QueryAsync<GetTestResultListDto>(query);
                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();
    }

    public async Task<GetTestResultListDto> GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}