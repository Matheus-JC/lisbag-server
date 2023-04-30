using LisbagServer.Domain.Entities.UserProfileAggregate;

namespace LisbagServer.Application.DTOs;

public class UserProfileDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? LastModified { get; set; }
    public ICollection<Address>? Addresses { get; set; }
    public ICollection<Phone>? Phones { get; set; }
}
