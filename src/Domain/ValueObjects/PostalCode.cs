using System.Text.RegularExpressions;
using LisbagServer.Domain.Exceptions;

namespace LisbagServer.Domain.ValueObjects;

public class PostalCode
{
    public string Value { get; private set; } = string.Empty;

    protected PostalCode()
    {
    }

    public PostalCode(string postalCode)
    {
        Value = IsValid(postalCode)
            ? postalCode
            : throw new DomainException("Postal Code is not valid");
    }

    public static bool IsValid(string postalCode)
    {
        string pattern = @"^[0234567]\d{4}$";
        var postalCodeValidation = new Regex(pattern);
        return postalCodeValidation.IsMatch(postalCode);
    }
}