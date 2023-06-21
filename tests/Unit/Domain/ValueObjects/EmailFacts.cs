using LisbagServer.Domain.Exceptions;
using LisbagServer.Domain.ValueObjects;

namespace LisbagServer.Tests.Unit.Domain.ValueObjects;

public class EmailFacts
{
    [Fact]
    public void Value_WithValidFormat_ReturnSuccess()
    {
        string correctEmail = "xpto@test.com";

        var email = new Email(correctEmail);

        Assert.IsType<Email>(email);
    }

    [Theory]
    [InlineData("xpto")]
    [InlineData("xpto@")]
    [InlineData("xpto@test")]
    public void Value_WithInvalidFormat_ThrowsDomainException(string wrongEmail)
    {
        Assert.Throws<DomainException>(() =>
        {
            var email = new Email(wrongEmail);
        });
    }
}