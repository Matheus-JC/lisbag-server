using System.Text.RegularExpressions;

namespace LisbagServer.Domain.ValueObjects;

public class PostalCode
{
    public PostalCode(string code)
    {
        Code = PostalCode.IsValid(code)
            ? code
            : throw new Exception("Postal Code is not valid");
    }

    public string Code { get; private set; }

    public static bool IsValid(string postalCode)
    {
        Regex postalCodeValidation = new Regex(@"^[0234567]\d{4}$");
        return postalCodeValidation.Match(postalCode).Success;
    }
}