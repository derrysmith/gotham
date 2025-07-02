namespace Gotham.Extensions.Core.UseCases;

public interface IUseCaseRequestHandler<in TRequest, T> where TRequest : IUseCaseRequest<T>;