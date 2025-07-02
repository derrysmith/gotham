using Gotham.Extensions.Core.UseCases;
using Wolverine;

namespace Gotham.Extensions.Core.Wolverine.UseCases;

public abstract class UseCaseHandler<TCommand> : IUseCaseCommandHandler<TCommand>, IWolverineHandler
	where TCommand : IUseCaseCommand;

public abstract class UseCaseHandler<TRequest, T> : IUseCaseRequestHandler<TRequest, T>, IWolverineHandler
	where TRequest : IUseCaseRequest<T>;