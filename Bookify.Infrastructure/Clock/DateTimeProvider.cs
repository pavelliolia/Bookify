using Bookify.Application.Abstrastions.Clock;

namespace Bookify.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}