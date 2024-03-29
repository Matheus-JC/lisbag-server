using LisbagServer.Domain.Enums;

namespace LisbagServer.Domain.Entities.ProfileAggregate;

public class Address
{
    public int Id { get; }
    public string Name { get; set; }
    public int PostalCode { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public AddressType? Type { get; set; }
    public DateTime CreatedDate { get; private set; } = DateTime.Now;
    public DateTime LastModified { get; private set; } = DateTime.Now;

    public Address(string name, int postalCode)
    {
        Name = name;
        PostalCode = postalCode;
    }

    public Address(string name, int postalCode, string city, string state,
        string country, AddressType type)
    {
        Name = name;
        PostalCode = postalCode;
        City = city;
        State = state;
        Country = country;
        Type = type;
    }
}