using Gotham.Extensions.Core.Messages;

namespace Gotham.Extensions.Core.Handlers;

public interface IDomainEventHandler<in TEvent> where TEvent : IDomainEvent;