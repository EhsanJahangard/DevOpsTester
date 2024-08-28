namespace IdentityApplication.Contracts.UnitOfWork;

public interface IUnitOfWork
{
    Task<int> Save();
}
