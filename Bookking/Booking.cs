namespace Bookking;

public class Booking
{
    BookingTypes bookingType;
    private string bookingName;
    int bookingId;
    Dates bookingDate;
    Customer bookingOwner;
    private int capacity;
    int bookingPrice;
    string description;
    

    public BookingTypes BookingType
    {
        get => bookingType;
        set => bookingType = value;
    }

    public string BookingName
    {
        get => bookingName;
        set => bookingName = value;
    }

    public int BookingId
    {
        get => bookingId;
        set => bookingId = value;
    }

    public int BookingPrice
    {
        get => bookingPrice;
        set => bookingPrice = value;
    }

    public Dates BookingDate
    {
        get => bookingDate;
        set => bookingDate = value;
    }

    public Customer BookingOwner
    {
        get => bookingOwner;
        set => bookingOwner = value;
    }

    public int Capacity
    {
        get => capacity;
        set => capacity = value;
    }
    
    public Booking(BookingTypes bookingType = default, string bookingName = default, int bookingId = default, int bookingPrice = 0, int capacity = default, Dates bookingDate = null, Customer bookingOwner = null)
    {
        this.BookingType = bookingType;
        this.BookingName = bookingName;
        this.BookingId = bookingId;
        this.BookingPrice = bookingPrice;
        this.BookingDate = bookingDate;
        this.Capacity = capacity;
        this.BookingOwner = bookingOwner;
    }
    
    public int checkStartDate()
    {
        int datesDays = BookingDate.StartDate;
        return datesDays;
    }

    public int checkEndDate()
    {
        int datesDays = BookingDate.EndDate;
        return datesDays;
    }
    
    public int checkDatesMonth()
    {
        int datesMonth = BookingDate.Month;
        return datesMonth;
    }

    public void setBookingType(string bookingType)
    {
        switch (bookingType)
        {
            case "Hotel":
                this.BookingType = BookingTypes.Hotel;
                break;
            case "Restaurant":
                this.BookingType = BookingTypes.Restaurant;
                break;
            case "Service":
                this.BookingType = BookingTypes.Service;
                break;
            case "Ticket":
                this.BookingType = BookingTypes.Ticket;
                break;
            default:
                Console.WriteLine("Invalid booking type");
                break;
        }
    }

    public void setBookingName(string bookingName)
    {
        this.BookingName = bookingName;
    }

    public void setBookingId(int bookingId)
    {
        this.BookingId = bookingId;
    }

    public void setBookingPrice(int bookingPrice)
    {
        this.BookingPrice = bookingPrice;
    }
    
    public void setBookingDates(Dates bookingDate)
    {
        this.BookingDate = bookingDate;
    }
    
    public void setBookingOwner(Customer bookingOwner)
    {
        this.BookingOwner = bookingOwner;
    }

    public void setCapacity(int capacity)
    {
        this.Capacity = capacity;
    }

    public void printBookingDetails1()
    {
        Console.WriteLine($"Booking Details: \nBooking Name: {BookingName} \nBookingID: {BookingId} \nBooking Price: {BookingPrice} \n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    }

    public void printBookingDetails2()
    {
        Console.WriteLine($"Booking Details: \nBooking Name: {BookingName} \nBookingID: {BookingId} \nCustomer: {BookingOwner} \nDates: from {BookingDate.StartDate} to {BookingDate.EndDate} in month {BookingDate.Month} \nPrice: {BookingPrice} \n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    }
    
    
}