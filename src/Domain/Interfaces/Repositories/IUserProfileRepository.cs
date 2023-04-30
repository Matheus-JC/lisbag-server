using LisbagServer.Domain.Entities.UserProfileAggregate;

namespace LisbagServer.Domain.Interfaces.Repositories;
public interface IUserProfileRepository
{
    UserProfile Get(int id);
    void Create(UserProfile userProfile);
    void Update(UserProfile userProfile);
    void Delete(UserProfile userProfile);
}