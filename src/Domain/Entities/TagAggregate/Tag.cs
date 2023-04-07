using LisbagServer.Domain.Entities.ContentAggregate;

namespace LisbagServer.Domain.Entities.TagAggregate;

public class Tag
{
    public string Name { get; set; }

    public ICollection<Content>? Contents { get; set; }

    public Tag(string name)
    {
        Name = name;
    }
}
