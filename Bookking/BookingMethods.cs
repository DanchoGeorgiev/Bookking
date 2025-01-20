namespace Bookking;

public class BookingMethods
{
    public static List<Booking> bookingsHotels = new();
    public static List<Booking> bookingsRestaurants = new();
    public static List<Booking> bookingsServices = new();
    public static List<Booking> bookingsTickets = new();
    
    public static List<Booking> bookingsHotelsBooked = new(); 
    public static List<Booking> bookingsRestaurantsBooked = new();
    public static List<Booking> bookingsServicesBooked = new();
    public static List<Booking> bookingsTicketsBooked = new();
    
    public static List<Customer> listOfCustomers = new();

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

    public static bool areDatesAvailable(Dates date, Dates date1)
    {
        int start1 = date.checkStartDate();
        int end1 = date.checkEndDate();
        int start2 = date1.checkStartDate();
        int end2 = date1.checkEndDate();

        if (date.Month == date1.Month)
        {
            Console.WriteLine($"Dates of first {date.Month} sd {start1} ed {end1}. Date of second {date1.Month} sd {start2} ed {end2}.");
            if (start1 < start2 && end2 < end1 && end2 > start2 && end1 > start1)
            {
                return true;
            }
            else if (start2 < start1 && end2 < end1 && start1 < end2 && end2 > start2 && end1 > start1)
            {
                return true;
            }
            else if (start1 < start2 && end1 < end2 && end1 > start2 && end2 > start2 && end1 > start1)
            {
                return true;
            }
            else if (start2 < start1 && end1 < end2 && end2 > start2 && end1 > start1) //
            {
                return true;
            }
            else if (start1 == start2 && end1 == end2 && end1 > start1 && end2 > start2) //
            {
                return true;
            }
            else if (start1 < start2 && end1 < end2 && end2 > start2 && end1 < start2 && end2 > start2 &&
                     end1 > start1) //
            {
                return false;
            }
            else if (start1 > start2 && end1 > end2 && start1 > end2 && start1 < end1 && end2 > start2) //
            {
                return false;
            }
            
        }
        else
        {
            Console.WriteLine("Dates were checked");
            return false;
        }
        return default;
    }
    
    public static bool bookOffer(int bookingId, Customer customer, Dates dates) // TODO нещо не е наред тук
    {
        Booking booking = createBooking1(bookingId);
        booking.setBookingDates(dates);
        booking.setBookingOwner(customer);
        if (booking.BookingType == BookingTypes.Hotel)
        {
            if (bookingsHotelsBooked.Count == 0)
            {
                //TODO
                bookingsHotelsBooked.Add(booking);
                return false;
            }
            else
            {
                foreach (Booking bookingHotel in bookingsHotelsBooked)
                {
                    if (bookingHotel.BookingId == booking.BookingId && bookingHotel.Capacity > 0)
                    {
                        if (areDatesAvailable(booking.BookingDate, bookingHotel.BookingDate))
                        {
                            Console.WriteLine($"The month has been set to {booking.BookingDate.Month}");
                            return true;
                        }
                        else
                        {
                            booking.Capacity -= 1;
                            bookingsHotelsBooked.Add(booking);
                            Console.WriteLine("Booking hotel capacity: " + booking.Capacity);
                            return false;
                        }
                    }
                    /*else if (bookingHotel.BookingId == booking.BookingId && bookingHotel.Capacity > 0)
                    {
                        booking.Capacity -= 1;
                        bookingsHotelsBooked.Add(booking);
                        Console.WriteLine("Booking hotel capacity: " + booking.Capacity);
                        return false;
                    }*/
                }
            }
        }
        
        if (booking.BookingType == BookingTypes.Restaurant)
        {
            foreach (Booking bookingRestaurant in bookingsRestaurantsBooked)
            {
                if (bookingRestaurant.BookingId == booking.BookingId &&
                    bookingRestaurant.BookingDate.Month == booking.BookingDate.Month && bookingRestaurant.Capacity > 0)
                {
                    int start1 = booking.BookingDate.checkStartDate();
                    int end1 = booking.BookingDate.checkEndDate();
                    int start2 = bookingRestaurant.BookingDate.checkStartDate();
                    int end2 = bookingRestaurant.BookingDate.checkEndDate();

                    if (start1 < start2 && end2 < end1 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start2 < start1 && end2 < end1 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start1 < start2 && end1 < end2 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start2 < start1 && end1 < end2 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start1 == start2 && end1 == end2 && end1 > start1 && end2 > start2)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start1 == start2 && end1 == end2 && end1 > start1 && end2 > start2)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start1 < start2 && end1 < end2 && end2 > start2 && end1 < start2)
                    {
                        booking.Capacity -= 1;
                        bookingsRestaurantsBooked.Add(booking);
                    }
                    else if(start1 > start2 && end1 > end2 && start1 < end1 && end2 > start2)
                    {
                        booking.Capacity -= 1;
                        bookingsRestaurantsBooked.Add(booking);
                    }
                }
                else if (bookingRestaurant.BookingId == booking.BookingId &&
                         bookingRestaurant.BookingDate.Month != booking.BookingDate.Month)
                {
                    booking.Capacity -= 1;
                    bookingsHotelsBooked.Add(booking);
                }
            }
        }
        
        if (booking.BookingType == BookingTypes.Service)
        {
            foreach (Booking bookingService in bookingsServicesBooked)
            {
                if (bookingService.BookingId == booking.BookingId &&
                    bookingService.BookingDate.Month == booking.BookingDate.Month && bookingService.Capacity > 0)
                {
                    int start1 = booking.BookingDate.checkStartDate();
                    int end1 = booking.BookingDate.checkEndDate();
                    int start2 = bookingService.BookingDate.checkStartDate();
                    int end2 = bookingService.BookingDate.checkEndDate();

                    if (start1 < start2 && end2 < end1 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start2 < start1 && end2 < end1 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start1 < start2 && end1 < end2 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start2 < start1 && end1 < end2 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start1 == start2 && end1 == end2 && end1 > start1 && end2 > start2)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if(start1 < start2 && end1 < end2 && end2 > start2 && end1 < start2)
                    {
                        booking.Capacity -= 1;
                        bookingsServicesBooked.Add(booking);
                    }
                    else if(start1 > start2 && end1 > end2 && start1 < end1 && end2 > start2)
                    {
                        booking.Capacity -= 1;
                        bookingsServicesBooked.Add(booking);
                    }
                }
                else if (bookingService.BookingId == booking.BookingId &&
                         bookingService.BookingDate.Month != booking.BookingDate.Month)
                {
                    booking.Capacity -= 1;
                    bookingsServicesBooked.Add(booking);
                }
            }
        }
        
        if (booking.BookingType == BookingTypes.Ticket)
        {
            foreach (Booking bookingTicket in bookingsTicketsBooked)
            {
                if (bookingTicket.BookingId == booking.BookingId &&
                    bookingTicket.BookingDate.Month == booking.BookingDate.Month && bookingTicket.Capacity > 0)
                {
                    int start1 = booking.BookingDate.checkStartDate();
                    int end1 = booking.BookingDate.checkEndDate();
                    int start2 = bookingTicket.BookingDate.checkStartDate();
                    int end2 = bookingTicket.BookingDate.checkEndDate();

                    if (start1 < start2 && end2 < end1 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start2 < start1 && end2 < end1 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start1 < start2 && end1 < end2 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start2 < start1 && end1 < end2 && end2 > start2 && end1 > start1)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if (start1 == start2 && end1 == end2 && end1 > start1 && end2 > start2)
                    {
                        Console.WriteLine("Room is booked on these days");
                    }
                    else if(start1 < start2 && end1 < end2 && end2 > start2 && end1 < start2)
                    {
                        booking.Capacity -= 1;
                        bookingsTicketsBooked.Add(booking);
                    }
                    else if(start1 > start2 && end1 > end2 && start1 < end1 && end2 > start2)
                    {
                        booking.Capacity -= 1;
                        bookingsTicketsBooked.Add(booking);
                    }
                }
                else if (bookingTicket.BookingId == booking.BookingId &&
                         bookingTicket.BookingDate.Month != booking.BookingDate.Month)
                {
                    booking.Capacity -= 1;
                    bookingsTicketsBooked.Add(booking);
                }
            }
        }

        return default;
    }
    
    public static Booking createBooking1(int bookingId)
    {
        
        foreach (Booking booking in bookingsHotels)
        {
            if (booking.BookingId == bookingId)
            {
                return booking;
            }
        }

        foreach (Booking booking in bookingsRestaurants)
        {
            if (booking.BookingId == bookingId)
            {
                return booking;
            }
        }

        foreach (Booking booking in bookingsServices)
        {
            if (booking.BookingId == bookingId)
            {
                return booking;
            }
        }

        foreach (Booking booking in bookingsTickets)
        {
            if (booking.BookingId == bookingId)
            {
                return booking;
            }
        }
        return null;
    }

    public static void removeBookingHotelsBooked(int phoneNumber, int bookingId)
    {
        foreach (Booking booking in bookingsHotelsBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber && booking.BookingType == BookingTypes.Hotel && booking.BookingId == bookingId)
            {
                bookingsHotelsBooked.Remove(booking);
            }
            else
            {
                Console.WriteLine("Phone number doesn't exist");
            }
        }
    }
    
    public static void removeBookingRestaurantsBooked(int phoneNumber, int id)
    {
        foreach (Booking booking in bookingsRestaurantsBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber && booking.BookingType == BookingTypes.Restaurant && booking.BookingId == id)
            {
                bookingsRestaurantsBooked.Remove(booking);
            }
            else
            {
                Console.WriteLine("Phone number doesn't exist");
            }
        }
    }
    
    public static void removeBookingServicesBooked(int phoneNumber, int id)
    {
        foreach (Booking booking in bookingsServicesBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber && booking.BookingType == BookingTypes.Service && booking.BookingId == id)
            {
                bookingsServicesBooked.Remove(booking);
            }
            else
            {
                Console.WriteLine("Phone number doesn't exist");
            }
        }
    }
    
    public static void removeBookingTicketsBooked(int phoneNumber, int id)
    {
        foreach (Booking booking in bookingsTicketsBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber && booking.BookingType == BookingTypes.Ticket && booking.BookingId == id)
            {
                bookingsTicketsBooked.Remove(booking);
            }
            else
            {
                Console.WriteLine("Phone number doesn't exist");
            }
        }
    }

    public static void listOfCustomersPrint()
    {
        foreach (Customer customer in listOfCustomers)
        {
            Console.WriteLine(customer);
        }
    }

    public static void listOfFreeHotels()
    {
        foreach (Booking booking in bookingsHotels)
        {
            booking.printBookingDetails1();
        }
    }

    public static void listOfFreeRestaurants()
    {
        foreach (Booking booking in bookingsRestaurants)
        {
            booking.printBookingDetails1();
        }
    }

    public static void listOfFreeServices()
    {
        foreach (Booking booking in bookingsServices)
        {
            booking.printBookingDetails1();
        }
    }

    public static void listOfFreeTickets()
    {
        foreach (Booking booking in bookingsTickets)
        {
            booking.printBookingDetails1();
        }
    }

    public static void customerBookigs(int phoneNumber)
    {
        foreach (Booking booking in bookingsHotelsBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber)
            {
                booking.printBookingDetails2();
            }
        }

        foreach (Booking booking in bookingsRestaurantsBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber)
            {
                booking.printBookingDetails2();
            }
        }

        foreach (Booking booking in bookingsServicesBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber)
            {
                booking.printBookingDetails2();
            }
        }

        foreach (Booking booking in bookingsTicketsBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber)
            {
                booking.printBookingDetails2();
            }
        }
    }

    public static void searchForABookingBookedHotel(int phoneNumber)
    {
        foreach (Booking booking in bookingsHotels)
        {
            if (booking.BookingOwner.Telephone == phoneNumber)
            {
                booking.printBookingDetails1();
            }
        }
    }

    public static void searchForABookingBookedRestaurant(int phoneNumber)
    {
        foreach (Booking booking in bookingsRestaurants)
        {
            if (booking.BookingOwner.Telephone == phoneNumber)
            {
                booking.printBookingDetails1();
            }
        }
    }

    public static void searchForABookingBookedServices(int phoneNumber)
    {
        foreach (Booking booking in bookingsServicesBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber)
            {
                booking.printBookingDetails1();
            }
        }
    }

    public static void searchForABookingBookedTickets(int phoneNumber)
    {
        foreach (Booking booking in bookingsTicketsBooked)
        {
            if (booking.BookingOwner.Telephone == phoneNumber)
            {
                booking.printBookingDetails1();
            }
        }
    }

    public static void currentBookedOffers()
    {
        foreach (Booking booking in bookingsHotelsBooked)
        {
            booking.printBookingDetails2();
        }

        foreach (Booking booking in bookingsRestaurantsBooked)
        {
            booking.printBookingDetails2();
        }

        foreach (Booking booking in bookingsServicesBooked)
        {
            booking.printBookingDetails2();
        }

        foreach (Booking booking in bookingsTicketsBooked)
        {
            booking.printBookingDetails2();
        }
    }

    public static void searchForAnOffer(int bookingId)
    {
        foreach (Booking booking in bookingsHotels)
        {
            if (booking.BookingId == bookingId)
            {
                booking.printBookingDetails1();
            }
        }

        foreach (Booking booking in bookingsRestaurantsBooked)
        {
            if (booking.BookingId == bookingId)
            {
                booking.printBookingDetails1();
            }
        }

        foreach (Booking booking in bookingsServicesBooked)
        {
            if (booking.BookingId == bookingId)
            {
                booking.printBookingDetails1();
            }
        }

        foreach (Booking booking in bookingsTicketsBooked)
        {
            if (booking.BookingId == bookingId)
            {
                booking.printBookingDetails1();
            }
        }
    }

    public static Customer findCustomer(int phoneNumber)
    {
        Customer customer = new Customer();
        foreach (Customer customer1 in listOfCustomers)
        {
            if (customer1.Telephone == phoneNumber)
            {
                customer = customer1;
            }
            else
            {
                Console.WriteLine("No Customer Found");
            }
        }
        return customer;
    }
    
}