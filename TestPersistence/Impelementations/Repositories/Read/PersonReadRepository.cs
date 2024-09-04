using Dapper;
using InfrastructureService;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.DTOs.Person;
using TestDomain.Models;


namespace TestPersistence.Impelementations.Repositories.Read;

public class PersonReadRepository : ReadOnlyRepository, IPersonReadRepository
{
    private readonly IDistributedCache _redisCache;
    public PersonReadRepository(IConfiguration configuration, IDistributedCache redisCache) : base(configuration)
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
    public async Task<List<GetPersonListDto>> GetAll(CancellationToken cancellationToken)
    {
        var cacheKey = "persongetall";

        var cacheOptions = new DistributedCacheEntryOptions()
           .SetAbsoluteExpiration(TimeSpan.FromMinutes(20))
           .SetSlidingExpiration(TimeSpan.FromMinutes(10));

        var res = await _redisCache.GetOrSetAsync(cacheKey,
                           async () =>
                           {
                               // logger.LogInformation("cache miss. fetching data for key: {CacheKey} from database.", cacheKey);
                               string query = @"SELECT TOP 3 convert(nvarchar(40),[Id]) as PersonId,[Name],[Family],[Age],[Mobile] FROM [dbo].[People]";
                               var result = await Connection.QueryAsync<GetPersonListDto>(query);

                               return result.ToList();
                           }, cacheOptions)!;


        return res.ToList();


    }


    public Task<GetPersonListDto> GetByFamily(string Family, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<GetPersonListDto> GetById(string Id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<GetPersonListDto> GetByTitle(string title, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }


}
