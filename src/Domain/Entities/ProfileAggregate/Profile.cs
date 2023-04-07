namespace LisbagServer.Domain.Entities.ProfileAggregate;

public class Profile
{
    public int Id { get; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string? Email { get; private set; }
    public DateOnly? DateOfBirth { get; private set; }
    public DateTime CreatedDate { get; private set; } = DateTime.Now;
    public DateTime LastModified { get; private set; } = DateTime.Now;

    public ICollection<Address> Addresses { get; private set; }
    public ICollection<Phone> Phones { get; private set; }

    public Profile(string name, string surname)
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
