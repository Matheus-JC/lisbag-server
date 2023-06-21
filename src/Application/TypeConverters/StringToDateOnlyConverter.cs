using AutoMapper;

namespace LisbagServer.Application.TypeConverters;

public class StringToDateOnlyConverter : ITypeConverter<string, DateOnly?>
{
    public DateOnly? Convert(string source, DateOnly? destination, ResolutionContext context)
    {
        if (string.IsNullOrEmpty(source))
        {
            return null;
        }

        return DateOnly.ParseExact(source, "yyyy-MM-dd");
    }
}