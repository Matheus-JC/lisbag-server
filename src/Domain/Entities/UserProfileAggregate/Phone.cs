namespace LisbagServer.Domain.Entities.UserProfileAggregate;

public class Phone
{
    public int Id { get; }
    public int InternationalAreaCode { get; private set; }
    public int Prefix { get; private set; }
    public int Number { get; private set; }
    public DateTime CreatedDate { get; private set; } = DateTime.Now;
    public DateTime LastModified { get; private set; } = DateTime.Now;

    public Phone(int internationalAreaCode, int prefix, int number)
    {
        InternationalAreaCode = internationalAreaCode;
        Prefix = prefix;
        Number = number;
    }
}
