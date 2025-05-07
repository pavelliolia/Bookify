namespace Bookify.Domain.Apartments;

public record Currency
{
    internal static readonly Currency None = new(""); // `internal` is not available outside the `Domain` project
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");
    public static readonly IReadOnlyCollection<Currency> All = [Usd, Eur];

    private Currency(string code) => Code = code;

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(x => x.Code == code)
               ?? throw new ApplicationException($"Currency with code {code} not found");
    }

    public string Code { get; init; }
}