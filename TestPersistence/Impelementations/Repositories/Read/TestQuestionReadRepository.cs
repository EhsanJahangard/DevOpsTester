using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.TestQuestion;


namespace TestPersistence.Impelementations.Repositories.Read;

public class TestQuestionReadRepository : ReadOnlyRepository, ITestQuestionReadRepository
{
    private readonly IDistributedCache _redisCache;
    public TestQuestionReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
    {
        _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

    }
    public void Dispose()
    {

    }

  

    public Task<GetTestQuestionListDto> GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }


    public async Task<List<GetTestQuestionListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "TestQuestiongetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @"SELECT TOP 100 convert(nvarchar(40),[Id]) as TestQuestionId,[Title] FROM [dbo].[TestQuestions]";
                               var result = await Connection.QueryAsync<GetTestQuestionListDto>(query);

                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();
    }

    public Task<GetTestQuestionListDto> GetByQuestionId(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<GetTestQuestionListDto> GetByTestId(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}