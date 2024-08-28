namespace IdentityApplication.Contracts.UnitOfWork;

public interface IUnitOfWork
{
    Task Save(CancellationToken cancellationToken);
}
