namespace Bookking;

public class BookingMethods
{
    static List<Booking> bookingsHotels = new();
    static List<Booking> bookingsRestaurants = new();
    static List<Booking> bookingsServices = new();
    static List<Booking> bookingsTickets = new();
    
    static List<Booking> bookingsHotelsBooked = new();
    static List<Booking> bookingsRestaurantsBooked = new();
    static List<Booking> bookingsServicesBooked = new();
    static List<Booking> bookingsTicketsBooked = new();

    public static void createBooking(Booking booking)
    {
        if (booking.BookingType == BookingTypes.Hotel)
        {
            bookingsHotels.Add(booking);
        }

        if (booking.BookingType == BookingTypes.Restaurant)
        {
            bookingsRestaurants.Add(booking);
        }

        if (booking.BookingType == BookingTypes.Service)
        {
            bookingsServices.Add(booking);
        }

        if (booking.BookingType == BookingTypes.Ticket)
        {
            bookingsTickets.Add(booking);
        }
    }

    public static void bookOffer(Booking booking)
    {
        if (booking.BookingDate != null && booking.BookingOwner != null && booking.BookingType == BookingTypes.Hotel)
        {
            int hotelId = booking.BookingId;
            BookingMethods.removeBookingHotel(hotelId);
            Booking booking1 = booking;
            bookingsHotelsBooked.Add(booking);
        }

        if (booking.BookingDate != null && booking.BookingOwner != null &&
            booking.BookingType == BookingTypes.Restaurant)
        {
            bookingsRestaurantsBooked.Add(booking);
        }

        if (booking.BookingDate != null && booking.BookingOwner != null && booking.BookingType == BookingTypes.Service)
        {
            bookingsServicesBooked.Add(booking);
        }

        if (booking.BookingDate != null && booking.BookingOwner != null && booking.BookingType == BookingTypes.Ticket)
        {
            bookingsTicketsBooked.Add(booking);
        }

    }

    public static void removeBookingHotel(int bookingId)
    {
        foreach (Booking booking in bookingsHotels)
        {
            if (booking.BookingId == bookingId)
            {
                bookingsHotels.Remove(booking);
            }
        }
    }
    
    public static void removeBookingRestaurants(int bookingId)
    {
        foreach (Booking booking in bookingsRestaurants)
        {
            if (booking.BookingId == bookingId)
            {
                bookingsHotels.Remove(booking);
            }
        }
    }
    
    public static void removeBookingServices(int bookingId)
    {
        foreach (Booking booking in bookingsServices)
        {
            if (booking.BookingId == bookingId)
            {
                bookingsHotels.Remove(booking);
            }
        }
    }
    
    public static void removeBookingTickets(int bookingId)
    {
        foreach (Booking booking in bookingsTickets)
        {
            if (booking.BookingId == bookingId)
            {
                bookingsHotels.Remove(booking);
            }
        }
    }
}