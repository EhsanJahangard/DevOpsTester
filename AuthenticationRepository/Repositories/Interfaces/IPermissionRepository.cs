using AuthenticationDomain;

namespace AuthenticationRepository.Repositories.Interfaces
{
    public interface IPermissionRepository : IRepository<Permission>    
    {
        Task<List<Permission>> GetAllAsync();

        Task<Permission> GetByIdAsync(Guid id);

        Task<List<Permission>> GetByIdsAsync(List<string> permissionIds);

        Task AddAsync(Permission permission);

        void Delete(Permission permission);
    }
}
