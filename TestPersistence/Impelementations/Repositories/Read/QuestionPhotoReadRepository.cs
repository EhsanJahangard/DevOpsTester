using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.QuestionPhoto;


namespace TestPersistence.Impelementations.Repositories.Read;

public class QuestionPhotoReadRepository : ReadOnlyRepository, IQuestionPhotoReadRepository
{
    private readonly IDistributedCache _redisCache;
    public QuestionPhotoReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
    {
        _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

    }
    public void Dispose()
    {

    }


    public async Task<List<GetQuestionPhotoListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "QuestionPhotogetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @"SELECT TOP 100 convert(nvarchar(40),[Id]) as QuestionPhotoId,[Title],QuestionId FROM [dbo].[QuestionPhotos]";
                               var result = await Connection.QueryAsync<GetQuestionPhotoListDto>(query);

                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();
    }

    public async Task<GetQuestionPhotoListDto> GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

   
}
