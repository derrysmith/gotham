using Gotham.Extensions.Core.Handlers;
using Gotham.Extensions.Core.Messages;
using Wolverine;

namespace Gotham.Extensions.Core.Wolverine.Handlers;

public abstract class IntegrationEventHandler<TEvent> : IIntegrationEventHandler<TEvent>, IWolverineHandler
	where TEvent : IIntegrationEvent;