using LisbagServer.Domain.Entities.ContentAggregate;
using LisbagServer.Domain.Exceptions;

namespace LisbagServer.Tests.Unit.Domain.Entities.ContentAggregate;

public class LinkFacts
{
    public class UrlProperty
    {
        [Fact]
        public void WithInvalidFormat_ThrowsDomainException()
        {
            string contentName = "Content Test";
            string wrongUrl = "http:www.google.com";

            Assert.Throws<DomainException>(() =>
            {
                var link = new Link(contentName, wrongUrl);
            });
        }
    }
}
