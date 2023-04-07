using LisbagServer.Domain.Entities.ContentAggregate;

namespace LisbagServer.Domain.Entities.ContentCollectionAggregate;

public class ContentCollection
{
    public string Name { get; set; }

    public ICollection<Content> Contents { get; set; }

    public ContentCollection(string name)
    {
        Name = name;
        Contents = new List<Content>();
    }
}
