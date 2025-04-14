using ResortsAPI.Models;

namespace ResortsAPI.Repositories;

public interface IBookingRepository
{
    List<Booking> GetAllBookings();

    Booking AddBooking(Booking booking);

    bool SaveBookings(List<Booking> bookings);

    Booking Update(Booking booking);
}