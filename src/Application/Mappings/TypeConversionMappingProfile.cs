using AutoMapper;
using LisbagServer.Application.TypeConverters;

namespace LisbagServer.Application.Mappings;

public class TypeConversionMappingProfile : Profile
{
    public TypeConversionMappingProfile()
    {
        CreateMap<string, DateOnly?>().ConvertUsing<StringToDateOnlyConverter>();
    }
}
