using LisbagServer.Domain.Enums;
using LisbagServer.Domain.ValueObjects;

namespace LisbagServer.Domain.Entities.UserProfileAggregate;

public class Address
{
    public int Id { get; }
    public string Name { get; private set; } = string.Empty;
    public PostalCode PostalCode { get; private set; } = null!;
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public AddressType Type { get; set; }
    public DateTime CreatedDate { get; private set; } = DateTime.UtcNow;
    public DateTime LastModified { get; private set; } = DateTime.UtcNow;

    protected Address()
    {
    }

    public Address(string name, string postalCode)
    {
        Name = name;
        PostalCode = new PostalCode(postalCode);
    }
}