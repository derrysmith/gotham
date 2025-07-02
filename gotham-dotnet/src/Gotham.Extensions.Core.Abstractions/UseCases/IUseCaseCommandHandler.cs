namespace Gotham.Extensions.Core.UseCases;

public interface IUseCaseCommandHandler<in TCommand> where TCommand : IUseCaseCommand;