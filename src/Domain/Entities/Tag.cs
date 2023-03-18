namespace LisbagServer.Domain.Entities;

public class Tag : BaseEntity
{
    public string Name { get; set; }

	public Tag(string name)
	{
		Name = name;
	}
}
