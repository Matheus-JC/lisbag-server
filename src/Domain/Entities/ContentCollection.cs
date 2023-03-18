namespace LisbagServer.Domain.Entities;

public class ContentCollection : BaseEntity
{
    public string Name { get; set; }

	public List<Content> Contents { get; set; }

	public ContentCollection(string name)
	{
		Name = name;
        Contents = new List<Content>();
    }
}
