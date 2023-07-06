namespace LisbagServer.Application.DTOs.UserProfile;

public record UserProfileDTO
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? DateOfBirth { get; set; }
}
