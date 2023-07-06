using AutoMapper;
using LisbagServer.Application.DTOs.UserProfile;
using LisbagServer.Domain.Entities.UserProfileAggregate;

namespace LisbagServer.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<UserProfile, UserProfileDTO>().ReverseMap();
        CreateMap<UserProfile, UserProfileDTOUpdate>().ReverseMap();
    }
}
