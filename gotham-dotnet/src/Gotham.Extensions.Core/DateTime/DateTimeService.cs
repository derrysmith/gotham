namespace Gotham.Extensions.Core.DateTime;

public sealed class DateTimeService : IDateTimeService
{
	public DateTimeOffset Now    => DateTimeOffset.Now;
	public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
}