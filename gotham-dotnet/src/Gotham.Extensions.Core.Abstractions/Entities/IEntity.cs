namespace Gotham.Extensions.Core.Entities;

public interface IEntity;

public interface IEntity<out TEntityKey> : IEntity
{
	TEntityKey Id { get; }
}