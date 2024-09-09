using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.PersonSkill;


namespace TestPersistence.Impelementations.Repositories.Read;

public class PersonSkillReadRepository : ReadOnlyRepository, IPersonSkillReadRepository
{
    private readonly IDistributedCache _redisCache;
    public PersonSkillReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
    {
        _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));

    }
    public void Dispose()
    {

    }



   


    public async Task<List<GetPersonSkillListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "PersonSkillgetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @"SELECT TOP 100 convert(nvarchar(40),[Id]) as PersonSkillId,[PersonId],SkillId,LevelId FROM [dbo].[PersonSkills]";
                               var result = await Connection.QueryAsync<GetPersonSkillListDto>(query);

                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();
    }

    public Task<GetPersonSkillListDto> GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<GetPersonSkillListDto> GetByQuestionId(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<GetPersonSkillListDto> GetByTestId(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
