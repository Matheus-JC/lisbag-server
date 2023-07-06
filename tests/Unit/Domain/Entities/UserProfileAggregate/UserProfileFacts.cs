using LisbagServer.Domain.Entities.UserProfileAggregate;
using LisbagServer.Domain.Exceptions;
using LisbagServer.Domain.ValueObjects;

namespace LisbagServer.Tests.Unit.Domain.Entities.UserProfileAggregate;

public class UserProfileFacts
{
    public static UserProfile GetUserProfileForTest()
    {
        return new UserProfile
        {
            Name = "Xpto",
            Surname = "Test",
            Email = new Email("xpto@test.com")
        };
    }

    public class TheDateOfBirthProperty
    {
        [Fact]
        public void Teste_ThrowsDomainException()
        {
            var userProfile = GetUserProfileForTest();
            int yearOfBirth = DateTime.Now.Year - 25;

            userProfile.DateOfBirth = new DateOnly(yearOfBirth, 1, 1);
            Assert.IsType<DateOnly>(userProfile.DateOfBirth);
        }

        [Fact]
        public void WithCurrentYear_ThrowsDomainException()
        {
            var userProfile = GetUserProfileForTest();
            int yearOfBirth = DateTime.Now.Year;

            Assert.Throws<DomainException>(() =>
            {
                userProfile.DateOfBirth = new DateOnly(yearOfBirth, 1, 1);
            });
        }

        [Fact]
        public void WithAYearGreaterThanTheCurrentOne_ThrowsDomainException()
        {
            var userProfile = GetUserProfileForTest();
            int yearOfBirth = DateTime.Now.Year + 1;

            Assert.Throws<DomainException>(() =>
            {
                userProfile.DateOfBirth = new DateOnly(yearOfBirth, 1, 1);
            });
        }
    }
}