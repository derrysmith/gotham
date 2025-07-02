using Gotham.Extensions.Core.Messages;

namespace Gotham.Extensions.Core.Handlers;

public interface IIntegrationEventHandler<in TEvent> where TEvent : IIntegrationEvent;