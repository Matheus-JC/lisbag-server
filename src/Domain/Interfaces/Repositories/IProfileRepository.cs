using LisbagServer.Domain.Entities.ProfileAggregate;

namespace LisbagServer.Domain.Interfaces.Repositories;
public interface IProfileRepository
{
    Profile Get(int id);
    void Add(Profile entity);
}