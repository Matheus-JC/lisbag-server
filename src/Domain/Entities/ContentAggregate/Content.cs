using LisbagServer.Domain.Entities.TagAggregate;

namespace LisbagServer.Domain.Entities.ContentAggregate;

public class Content
{
    public string Name { get; private set; }
    public bool IsFavorite { get; private set; }
    public ICollection<Tag> Tags { get; private set; }

    public Content(string name)
    {
        Name = name;
        IsFavorite = false;
        Tags = new List<Tag>();
    }
}
