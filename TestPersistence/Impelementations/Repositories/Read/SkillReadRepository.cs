using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Skill;
using TestDomain.Models;


namespace TestPersistence.Impelementations.Repositories.Read;

public class SkillReadRepository : ReadOnlyRepository, ISkillReadRepository
{
    private readonly IDistributedCache _redisCache;
    public SkillReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
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


    public Task<GetSkillListDto> GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<GetSkillListDto> GetByLetter(string Text, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GetSkillListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "Skillgetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @"SELECT TOP 100 convert(nvarchar(40),[Id]) as SkillId,[Title] FROM [dbo].[Skills]";
                               var result = await Connection.QueryAsync<GetSkillListDto>(query);

                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();
    }


}