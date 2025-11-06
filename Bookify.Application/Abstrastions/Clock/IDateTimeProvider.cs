namespace Bookify.Application.Abstrastions.Clock;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}