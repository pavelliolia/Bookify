using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public static class BookingError
{
    public static Error NotFound = new(
        "Booking.NotFound",
        "Booking with specified ID was not found");

    public static Error Overlap = new(
        "Booking.Overlap",
        "The current booking is overlapping with the existing one");

    public static Error NotReserved = new(
        "Booking.NotReserved",
        "The booking is not pending");

    public static Error NotConfirmed = new(
        "Booking.NotConfirmed",
        "The booking is not confirmed");

    public static Error AlreadyStarted = new(
        "Booking.AlreadyStarted",
        "The booking has already been started");
}