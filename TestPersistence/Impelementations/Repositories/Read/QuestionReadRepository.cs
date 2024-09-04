using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Question;
using TestDomain.Models;


namespace TestPersistence.Impelementations.Repositories.Read;

public class QuestionReadRepository : ReadOnlyRepository, IQuestionReadRepository
{
    private readonly IDistributedCache _redisCache;
    public QuestionReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
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


    public Task<GetQuestionListDto> GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<GetQuestionListDto> GetByLetter(string Text, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GetQuestionListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "questiongetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @"SELECT TOP 100 convert(nvarchar(40),[Id]) as QuestionId,[Letter],[Answer] FROM [dbo].[Questions]";
                               var result = await Connection.QueryAsync<GetQuestionListDto>(query);

                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();
    }


}