using System.Text.RegularExpressions;
using LisbagServer.Domain.Exceptions;

namespace LisbagServer.Domain.ValueObjects;

public class Email
{
    public string Value { get; private set; } = string.Empty;

    protected Email()
    {
    }

    public Email(string email)
    {
        Value = IsValid(email)
            ? email
            : throw new DomainException("Email is not valid");
    }

    public static bool IsValid(string email)
    {
        string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        var regex = new Regex(pattern);
        return regex.IsMatch(email);
    }
}