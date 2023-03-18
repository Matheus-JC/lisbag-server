namespace LisbagServer.Domain.Entities;

public class Content : BaseEntity
{
    public string Name { get; private set; }
    public bool IsFavorite { get; private set; }
    public List<Tag> Tags { get; private set; }

    public Content(string name)
    {
        Name = name;
        IsFavorite = false;
        Tags = new List<Tag>();
    }
}
