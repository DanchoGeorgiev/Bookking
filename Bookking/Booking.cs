namespace Bookking;

public class Booking
{
    BookingTypes bookingType;
    private string bookingName;
    int bookingId;
    Dates bookingDate;
    Customer bookingOwner;
    private int capacity;
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

    public Dates BookingDate
    {
        get => bookingDate;
        set => bookingDate = value;
    }

    public Customer BookingOwner
    {
        get => bookingOwner;
        set => bookingOwner = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Capacity
    {
        get => capacity;
        set => capacity = value;
    }
    
    public Booking(BookingTypes bookingType = default, string bookingName = default, int bookingId = default, Dates bookingDate = null, int capacity = default, Customer bookingOwner = null)
    {
        this.BookingType = bookingType;
        this.BookingName = bookingName;
        this.BookingId = bookingId;
        this.BookingDate = bookingDate;
        this.Capacity = capacity;
        this.BookingOwner = bookingOwner;
    }
}