using LisbagServer.Domain.Entities.UserProfileAggregate;

namespace LisbagServer.Application.DTOs;

public record UserProfileDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? DateOfBirth { get; set; }
    public ICollection<Address>? Addresses { get; set; }
    public ICollection<Phone>? Phones { get; set; }
}
