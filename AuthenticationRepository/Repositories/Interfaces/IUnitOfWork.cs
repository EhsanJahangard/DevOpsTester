namespace AuthenticationRepository.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
