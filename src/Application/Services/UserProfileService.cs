using AutoMapper;
using LisbagServer.Application.DTOs;
using LisbagServer.Application.Interfaces;
using LisbagServer.Domain.Entities.UserProfileAggregate;
using LisbagServer.Domain.Interfaces.Repositories;

namespace LisbagServer.Application.Services;

public class UserProfileService : IUserProfileService
{
    private readonly IUserProfileRepository _userProfileRepository;
    private readonly IMapper _mapper;

    public UserProfileService(IUserProfileRepository userProfileRepository, IMapper mapper)
    {
        _userProfileRepository = userProfileRepository;
        _mapper = mapper;
    }

    public void Create(UserProfileDTO userProfileDTO)
    {
        var userProfileEntity = _mapper.Map<UserProfile>(userProfileDTO);
        _userProfileRepository.Create(userProfileEntity);
    }

    public UserProfileDTO Get(int id)
    {
        var userProfileEntity = _userProfileRepository.Get(id);
        return _mapper.Map<UserProfileDTO>(userProfileEntity);
    }
}
