namespace PickleBall.Domain.Abstractions;

public class Entity<T> : IEntity<T>
{
    public T Id { get; set; }
    public bool IsDeleted { get; protected set; }
}