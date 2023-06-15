﻿using AutoMapper;
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

    public IEnumerable<UserProfileDTO> GetAll()
    {
        var userProfiles = _userProfileRepository.GetAll();
        return _mapper.Map<IEnumerable<UserProfileDTO>>(userProfiles);
    }

    public UserProfileDTO Get(int id)
    {
        var userProfileEntity = _userProfileRepository.Get(id);
        return _mapper.Map<UserProfileDTO>(userProfileEntity);
    }

    public void Create(UserProfileDTO userProfileDTO)
    {
        var userProfileEntity = _mapper.Map<UserProfile>(userProfileDTO);
        _userProfileRepository.Create(userProfileEntity);
    }

    public void Update(UserProfileDTO userProfileDTO)
    {
        var userProfileEntity = _mapper.Map<UserProfile>(userProfileDTO);
        _userProfileRepository.Update(userProfileEntity);
    }

    public void Delete(int id)
    {
        var userProfileEntity = _userProfileRepository.Get(id);
        _userProfileRepository.Delete(userProfileEntity);
    }
}
