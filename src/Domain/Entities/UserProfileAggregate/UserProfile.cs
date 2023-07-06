using LisbagServer.Domain.Exceptions;
using LisbagServer.Domain.ValueObjects;

namespace LisbagServer.Domain.Entities.UserProfileAggregate;

public class UserProfile
{
    public DateOnly? _dateOfBirth;

    public int Id { get; private set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public DateTime CreatedDate { get; private set; } = DateTime.UtcNow;
    public DateTime LastModified { get; private set; } = DateTime.UtcNow;
    public ICollection<Address> Addresses { get; private set; } = new List<Address>();
    public ICollection<Phone> Phones { get; private set; } = new List<Phone>();
    public required Email Email { get; set; }
    public DateOnly? DateOfBirth
    {
        get { return _dateOfBirth; }
        set { SetDateOfBirth(value); }
    }

    // protected UserProfile()
    // {
    // }

    // public UserProfile(string name, string surname, string email)
    // {
    //     Name = name;
    //     Surname = surname;
    //     Email = new Email(email);
    // }

    public void AddAddress(Address address)
    {
        Addresses.Add(address);
    }

    public void AddPhone(Phone phone)
    {
        Phones.Add(phone);
    }

    private void SetDateOfBirth(DateOnly? dateOfBirth)
    {
        if (dateOfBirth != null)
        {
            if (dateOfBirth?.Year >= DateTime.Now.Year)
            {
                throw new DomainException("the year of the date of birth cannot be greater than or equal to the current year");
            }

            _dateOfBirth = dateOfBirth;
        }
    }
}
