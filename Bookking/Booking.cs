namespace Bookking;

public class Booking
{
    BookingTypes bookingType;
    private string bookingName;
    int bookingId;
    private int bookingTime;
    Customer bookingOwner;
    bool booked = false;

    public BookingTypes BookingType
    {
        get => bookingType;
        set => bookingType = value;
    }

    public string BookingName
    {
        get => bookingName;
        set => bookingName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int BookingId
    {
        get => bookingId;
        set => bookingId = value;
    }

    public int BookingTime
    {
        get => bookingTime;
        set => bookingTime = value;
    }

    public Customer BookingOwner
    {
        get => bookingOwner;
        set => bookingOwner = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Booking(BookingTypes bookingType, string bookingName = default, int bookingId = default, int bookingTime = default, Customer bookingOwner = null)
    {
        this.BookingType = bookingType;
        this.BookingName = bookingName;
        this.BookingId = bookingId;
        this.BookingTime = bookingTime;
        this.BookingOwner = bookingOwner;
    }
}