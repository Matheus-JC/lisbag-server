﻿using LisbagServer.Application.DTOs;

namespace LisbagServer.Application.Interfaces;

public interface IUserProfileService
{
    UserProfileDTO Get(int id);
    void Create(UserProfileDTO userProfileDTO);
}