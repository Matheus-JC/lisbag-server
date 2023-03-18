namespace LisbagServer.Domain.Entities;

public class Profile : BaseEntity
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public List<Address> Addresses { get; set; }
    public List<Phone> Phones { get; set; }

    public Profile(string name, string surname)
    {
        Name = name;
        Surname = surname;
        Addresses = new List<Address>();
        Phones = new List<Phone>();
    }
}
