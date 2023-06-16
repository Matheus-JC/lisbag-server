namespace LisbagServer.Domain.Entities.UserProfileAggregate;

public class UserProfile
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string? Email { get; private set; }
    public DateOnly? DateOfBirth { get; private set; }
    public DateTime CreatedDate { get; private set; } = DateTime.UtcNow;
    public DateTime LastModified { get; private set; } = DateTime.UtcNow;
    public ICollection<Address> Addresses { get; private set; }
    public ICollection<Phone> Phones { get; private set; }

    public UserProfile(string name, string surname)
    {
        Name = name;
        Surname = surname;
        Addresses = new List<Address>();
        Phones = new List<Phone>();
    }

    public void AddAddress(Address address)
    {
        Addresses.Add(address);
    }

    public void AddPhone(Phone phone)
    {
        Phones.Add(phone);
    }
}
