using LisbagServer.Application.DTOs.UserProfile;

namespace LisbagServer.Application.Interfaces;

public interface IUserProfileService
{
    IEnumerable<UserProfileDTO> GetAll();
    UserProfileDTO Get(int id);
    void Create(UserProfileDTO userProfileDTO);
    void Update(UserProfileDTOUpdate userProfileDTO);
    void Delete(int id);
}
