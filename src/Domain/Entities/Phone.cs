namespace LisbagServer.Domain.Entities;

public class Phone : BaseEntity
{
    public int InternationalAreaCode { get; private set; }
    public int Prefix { get; private set; }
    public int Number { get; private set; }

    public Phone(int internationalAreaCode, int prefix, int number)
    {
        InternationalAreaCode = internationalAreaCode;
        Prefix = prefix;
        Number = number;
    }
}
