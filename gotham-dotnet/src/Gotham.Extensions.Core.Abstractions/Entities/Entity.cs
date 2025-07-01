namespace Gotham.Extensions.Core.Entities;

public abstract class Entity<TEntityKey> : IEntity<TEntityKey>
{
	public virtual TEntityKey Id { get; protected set; } = default!;
}