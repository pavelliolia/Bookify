using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Apartments;

public sealed class Apartment(Guid id) : Entity(id)
{
    public string Name { get; private set; }

    public string Description { get; private set; }

    public string Country { get; private set; }

    public string State { get; private set; }

    public string ZipCode { get; private set; }

    public string Street { get; private set; }

    public decimal Price { get; private set; }

    public string PriceCurrency { get; private set; }

    public decimal CleaningFeeAmount { get; private set; }

    public string CleaningFeeCurrency { get; private set; }

    public DateTime? LastBookedOnUtc { get; private set; }

    public List<Amenity> Amenities { get; private set; } = new();
}