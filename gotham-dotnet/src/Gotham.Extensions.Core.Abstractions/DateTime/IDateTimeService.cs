namespace Gotham.Extensions.Core.DateTime;

public interface IDateTimeService
{
	DateTimeOffset Now    { get; }
	DateTimeOffset UtcNow { get; }
}