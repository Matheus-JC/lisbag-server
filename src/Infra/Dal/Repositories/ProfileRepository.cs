using LisbagServer.Domain.Entities.ProfileAggregate;
using LisbagServer.Domain.Interfaces.Repositories;
using LisbagServer.Infra.Dal.Context;

namespace LisbagServer.Infra.Dal.Repositories;

public class ProfileRepository : IProfileRepository
{
    private readonly ProfileDbContext _profileContext;

    public ProfileRepository(ProfileDbContext profileContext)
    {
        _profileContext = profileContext;
    }
    public void Add(Profile profile)
    {
        _profileContext.Add(profile);
    }

    public Profile Get(int id)
    {
        var profile = _profileContext.Profiles.Find(id);

        return profile ?? throw new Exception("test exception");
    }
}
