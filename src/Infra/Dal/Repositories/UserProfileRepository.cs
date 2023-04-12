using LisbagServer.Domain.Entities.UserProfileAggregate;
using LisbagServer.Domain.Interfaces.Repositories;
using LisbagServer.Infra.Dal.Context;

namespace LisbagServer.Infra.Dal.Repositories;

public class UserProfileRepository : IUserProfileRepository
{
    private readonly UserProfileDbContext _userProfileContext;

    public UserProfileRepository(UserProfileDbContext profileContext)
    {
        _userProfileContext = profileContext;
    }

    public void Create(UserProfile userProfile)
    {
        _userProfileContext.Add(userProfile);
        _userProfileContext.SaveChanges();
    }

    public UserProfile Get(int id)
    {
        var userProfile = _userProfileContext.UserProfiles.Find(id);

        return userProfile ?? throw new Exception("not found exception");
    }
}
