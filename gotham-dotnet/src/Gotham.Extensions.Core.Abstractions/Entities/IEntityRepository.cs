namespace Gotham.Extensions.Core.Entities;

public interface IEntityRepository<TEntity, in TEntityKey>
	where TEntity : IEntity<TEntityKey>
{
	Task<TEntity?> FindByIdAsync(TEntityKey id, CancellationToken ct = default);

	Task<TEntity> GetByIdAsync(TEntityKey id, CancellationToken ct = default);

	void Append(TEntity entity);

	void Update(TEntity entity);

	void Remove(TEntityKey id);
}