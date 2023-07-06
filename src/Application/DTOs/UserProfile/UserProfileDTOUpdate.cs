namespace LisbagServer.Application.DTOs.UserProfile;

public record UserProfileDTOUpdate
{
    public required int Id { get; set; }
    public required string Name { get; set; } = string.Empty;
    public required string Surname { get; set; } = string.Empty;
    public required string Email { get; set; } = string.Empty;
    public string? DateOfBirth { get; set; }
}
