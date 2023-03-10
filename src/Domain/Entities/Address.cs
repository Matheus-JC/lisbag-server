using LisbagServer.Domain.Enums;

namespace LisbagServer.Domain.Entities;

public class Address
{
    public string Name { get; set; }
    public int PostalCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public AddressType Type { get; set; }

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