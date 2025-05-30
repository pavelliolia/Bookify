namespace Bookify.Domain.Abstractions;

public record Error(string Code, string Name)
{
    public static Error None = new(string.Empty, string.Empty);

    public static Error NullError = new("Error.NullValue", "Null value was provided");
}