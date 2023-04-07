namespace LisbagServer.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; protected set; }
    public DateTime CreatedDate { get; private set; } = DateTime.Now;
    public DateTime LastModified { get; private set; } = DateTime.Now;
}
