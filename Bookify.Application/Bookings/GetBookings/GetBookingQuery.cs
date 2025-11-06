using Bookify.Application.Abstrastions.Messaging;

namespace Bookify.Application.Bookings.GetBookings;

public record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;