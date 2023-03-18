using LisbagServer.Domain.Entities;
using LisbagServer.Domain.Exceptions;

namespace LisbagServer.Tests.Unit.Domain;

public class LinkFacts
{
    public class UrlProperty
    {
        [Fact]
        public void WithInvalidFormat_ThrowsDomainException()
        {
            string contentName = "Content Test";
            string url = "http:www.google.com";

            Assert.Throws<DomainException>(() =>
            {
                var link = new Link(contentName, url);
            });

        }
    }
}
