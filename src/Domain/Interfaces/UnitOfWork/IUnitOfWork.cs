namespace LisbagServer.Domain.Interfaces.UnitOfWork;

public interface IUnitOfWork
{
    void Commit();
    void Rollback();
}
