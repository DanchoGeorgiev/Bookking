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
            else if (start1 < start2 && end2 < end1 && end2 < start2 && end1 < start1)////
            {
                return true;
            }
            else if (start2 < start1 && end2 < end1 && start1 < end2 && end2 < start2 && end1 < start1)
            {
                return true;
            }
            else if (start1 < start2 && end1 < end2 && end1 > start2 && end2 < start2 && end1 < start1)
            {
                return true;
            }
            else if (start2 < start1 && end1 < end2 && end2 < start2 && end1 < start1) //
            {
                return true;
            }
            else if (start1 == start2 && end1 == end2 && end1 < start1 && end2 < start2) //
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
            else if (start1 < start2 && end1 < end2 && end2 > start2 && end1 < start2 && end2 < start2 &&
                     end1 < start1) ////
            {
                return false;
            }
            else if (start1 > start2 && end1 > end2 && start1 > end2 && start1 > end1 && end2 < start2) //
            {
                return false;
            }
        }
        else
        {
            return false;
        }
        return default;
    }
    
    public static bool bookOffer(int bookingId, Customer customer, Dates dates) // TODO нещо не е наред тук
    {
        Booking booking1 = createBooking1(bookingId); // В C Sharp като създавам по този начин обект, неговата памет си остава с него, затова винаги като трябва да клонирам нещо създавам цялостно нов обект, като сложа параметрите с точка от единия на другия
        Booking booking2 = new Booking(booking1.BookingType, booking1.BookingName, booking1.BookingId, booking1.BookingPrice, booking1.Capacity, dates, customer);
        if (booking2.BookingType == BookingTypes.Hotel)
        {
            if (bookingsHotelsBooked.Count == 0)
            {
                booking2.Capacity -= 1;
                bookingsHotelsBooked.Add(booking2);
                return false;
            }
            else
            {
                foreach (Booking bookingHotel in bookingsHotelsBooked)
                {
                    if (bookingHotel.BookingId == booking2.BookingId && 
                        bookingHotel.BookingDate.Month == booking2.BookingDate.Month)
                    {
                        if (areDatesAvailable(booking2.BookingDate, bookingHotel.BookingDate) && bookingHotel.Capacity == 0)
                        {
                            return true;
                        }
                        else if (bookingHotel.Capacity > 0)
                        {
                            bookingHotel.Capacity -= 1;
                            booking2.Capacity = bookingHotel.Capacity;
                            bookingsHotelsBooked.Add(booking2);
                            return false;
                        }
                    }
                    else if (bookingHotel.BookingId == booking2.BookingId && bookingHotel.BookingDate.Month != booking2.BookingDate.Month)
                    {
                        booking2.Capacity -= 1;
                        bookingsHotelsBooked.Add(booking2);
                        return false;
                    }
                    else if (bookingHotel.BookingId != booking2.BookingId)
                    {
                        booking2.Capacity -= 1;
                        bookingsHotelsBooked.Add(booking2);
                        return false;
                    }
                }
            }
        }
        
        if (booking1.BookingType == BookingTypes.Restaurant)
        {
            if (bookingsRestaurantsBooked.Count == 0)
            {
                booking2.Capacity -= 1;
                bookingsRestaurantsBooked.Add(booking2);
                return false;
            }
            else
            {
                foreach (Booking bookingRestaurant in bookingsRestaurantsBooked)
                {
                    if (bookingRestaurant.BookingId == booking2.BookingId && 
                        bookingRestaurant.BookingDate.Month == booking2.BookingDate.Month)
                    {
                        if (areDatesAvailable(booking2.BookingDate, bookingRestaurant.BookingDate) && bookingRestaurant.Capacity == 0)
                        {
                            return true;
                        }
                        else if (bookingRestaurant.Capacity > 0)
                        {
                            bookingRestaurant.Capacity -= 1;
                            booking2.Capacity = bookingRestaurant.Capacity;
                            bookingsRestaurantsBooked.Add(booking2);
                            
                            return false;
                        }
                    }
                    else if (bookingRestaurant.BookingId == booking2.BookingId && bookingRestaurant.BookingDate.Month != booking2.BookingDate.Month)
                    {
                        booking2.Capacity -= 1;
                        bookingsRestaurantsBooked.Add(booking2);
                        return false;
                    }
                    else if (bookingRestaurant.BookingId != booking2.BookingId)
                    {
                        booking2.Capacity -= 1;
                        bookingsRestaurantsBooked.Add(booking2);
                        return false;
                    }
                }
            }
        }
        
        if (booking1.BookingType == BookingTypes.Service)
        {
            if (bookingsServicesBooked.Count == 0)
            {
                booking2.Capacity -= 1;
                bookingsServicesBooked.Add(booking2);
                return false;
            }
            else
            {
                foreach (Booking bookingService in bookingsServicesBooked)
                {
                    if (bookingService.BookingId == booking2.BookingId && 
                        bookingService.BookingDate.Month == booking2.BookingDate.Month)
                    {
                        if (areDatesAvailable(booking2.BookingDate, bookingService.BookingDate) && bookingService.Capacity == 0)
                        {
                            return true;
                        }
                        else if (bookingService.Capacity > 0)
                        {
                            bookingService.Capacity -= 1;
                            booking2.Capacity = bookingService.Capacity;
                            bookingsServicesBooked.Add(booking2);
                            return false;
                        }
                    }
                    else if (bookingService.BookingId == booking2.BookingId && bookingService.BookingDate.Month != booking2.BookingDate.Month)
                    {
                        booking2.Capacity -= 1;
                        bookingsServicesBooked.Add(booking2);
                        return false;
                    }
                    else if (bookingService.BookingId != booking2.BookingId)
                    {
                        booking2.Capacity -= 1;
                        bookingsServicesBooked.Add(booking2);
                        return false;
                    }
                }
            }
        }
        
        if (booking1.BookingType == BookingTypes.Ticket)
        {
            if (bookingsTicketsBooked.Count == 0)
            {
                booking2.Capacity -= 1;
                bookingsTicketsBooked.Add(booking2);
                return false;
            }
            else
            {
                foreach (Booking bookingTicket in bookingsTicketsBooked)
                {
                    if (bookingTicket.BookingId == booking2.BookingId && 
                        bookingTicket.BookingDate.Month == booking2.BookingDate.Month)
                    {
                        if (areDatesAvailable(booking2.BookingDate, bookingTicket.BookingDate) && bookingTicket.Capacity == 0)
                        {
                            return true;
                        }
                        else if (bookingTicket.Capacity > 0)
                        {
                            bookingTicket.Capacity -= 1;
                            booking2.Capacity = bookingTicket.Capacity;
                            bookingsTicketsBooked.Add(booking2);
                            return false;
                        }
                    }
                    else if (bookingTicket.BookingId == booking2.BookingId && bookingTicket.BookingDate.Month != booking2.BookingDate.Month)
                    {
                        booking2.Capacity -= 1;
                        bookingsTicketsBooked.Add(booking2);
                        return false;
                    }
                    else if (bookingTicket.BookingId != booking2.BookingId)
                    {
                        booking2.Capacity -= 1;
                        bookingsTicketsBooked.Add(booking2);
                        return false;
                    }
                }
            }
        }

        return default;
    }

    public static bool checkIfIdAvailable(int bookingId)
    {
        foreach (Booking hotel in bookingsHotels)
        {
            if (hotel.BookingId == bookingId)
            {
                return true;
            }
        }

        foreach (Booking restaurant in bookingsRestaurants)
        {
            if (restaurant.BookingId == bookingId)
            {
                return true;
            }
        }

        foreach (Booking service in bookingsServices)
        {
            if (service.BookingId == bookingId)
            {
                return true;
            }
        }

        foreach (Booking ticket in bookingsTickets)
        {
            if (ticket.BookingId == bookingId)
            {
                return true;
            }
        }
        return false;
    }

    public static bool checkIfCustomerExists(int phoneNumber)
    {
        foreach (Customer customer in listOfCustomers)
        {
            if (customer.Telephone == phoneNumber)
            {
                return true;
            }
        }
        return false;
    }
    
    public static void removeBooking(int ID)
    {
        foreach (Booking hotel in bookingsHotels)
        {
            if (hotel.BookingId == ID)
            {
                bookingsHotels.Remove(hotel);
                break;
            }
        }

        foreach (Booking restaurant in bookingsRestaurants)
        {
            if (restaurant.BookingId == ID)
            {
                bookingsRestaurants.Remove(restaurant);
                break;
            }
        }

        foreach (Booking service in bookingsServices)
        {
            if (service.BookingId == ID)
            {
                bookingsServices.Remove(service);
                break;
            }
        }

        foreach (Booking ticket in bookingsTickets)
        {
            if (ticket.BookingId == ID)
            {
                bookingsTickets.Remove(ticket);
                break;
            }
        }
    }

    public static void cancelBooking(int bookingId, int startDate, int endDate, int month, int phoneNumber)
    {
        foreach (Booking hotel in bookingsHotelsBooked)
        {
            if (hotel.BookingId == bookingId && hotel.BookingDate.StartDate == startDate && hotel.BookingDate.EndDate == endDate && hotel.BookingDate.Month == month && hotel.BookingOwner.Telephone == phoneNumber)
            {
                bookingsHotelsBooked.Remove(hotel);
                break;
            }
        }
        
        foreach (Booking restaurant in bookingsRestaurantsBooked)
        {
            if (restaurant.BookingId == bookingId && restaurant.BookingDate.StartDate == startDate && restaurant.BookingDate.EndDate == endDate && restaurant.BookingDate.Month == month && restaurant.BookingOwner.Telephone == phoneNumber)
            {
                bookingsRestaurantsBooked.Remove(restaurant);
                break;
            }
        }
        
        foreach (Booking service in bookingsServicesBooked)
        {
            if (service.BookingId == bookingId && service.BookingDate.StartDate == startDate && service.BookingDate.EndDate == endDate && service.BookingDate.Month == month && service.BookingOwner.Telephone == phoneNumber)
            {
                bookingsServicesBooked.Remove(service);
                break;
            }
        }
        
        foreach (Booking ticket in bookingsHotelsBooked)
        {
            if (ticket.BookingId == bookingId && ticket.BookingDate.StartDate == startDate && ticket.BookingDate.EndDate == endDate && ticket.BookingDate.Month == month && ticket.BookingOwner.Telephone == phoneNumber)
            {
                bookingsTicketsBooked.Remove(ticket);
                break;
            }
        }
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

    public static void searchForBookedBookings(int phoneNumber)
    {
        foreach (Booking hotel in bookingsHotelsBooked)
        {
            if (hotel.BookingOwner.Telephone == phoneNumber)
            {
                hotel.printBookingDetails2();
            }
        }

        foreach (Booking restaurant in bookingsRestaurantsBooked)
        {
            if (restaurant.BookingOwner.Telephone == phoneNumber)
            {
                restaurant.printBookingDetails2();
            }
        }

        foreach (Booking service in bookingsServicesBooked)
        {
            if (service.BookingOwner.Telephone == phoneNumber)
            {
                service.printBookingDetails2();
            }
        }

        foreach (Booking ticket in bookingsTicketsBooked)
        {
            if (ticket.BookingOwner.Telephone == phoneNumber)
            {
                ticket.printBookingDetails2();
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

    public static void searchForAnOffer(string offerName)
    {
        foreach (Booking booking in bookingsHotels)
        {
            if (booking.BookingName == offerName)
            {
                booking.printBookingDetails1();
            }
        }

        foreach (Booking booking in bookingsRestaurants)
        {
            if (booking.BookingName == offerName)
            {
                booking.printBookingDetails1();
            }
        }

        foreach (Booking booking in bookingsServices)
        {
            if (booking.BookingName == offerName)
            {
                booking.printBookingDetails1();
            }
        }

        foreach (Booking booking in bookingsTickets)
        {
            if (booking.BookingName == offerName)
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

    public static bool goThroughBookings(string offerName) //Проверява според иметодали съществува букинга в небукнатите оферти
    {
        foreach (Booking hotel in bookingsHotels)
        {
            if (hotel.BookingName == offerName)
            {
                return true; // Като направя да ден метод с return statement, връща когато види return;
            }
        }

        foreach (Booking restaurant in bookingsRestaurants)
        {
            if (restaurant.BookingName == offerName)
            {
                return true;
            }
        }

        foreach (Booking services in bookingsServices)
        {
            if (services.BookingName == offerName)
            {
                return true;
            }
        }

        foreach (Booking ticket in bookingsTickets)
        {
            if (ticket.BookingName == offerName)
            {
                return true;
            }
        }
        return false;
    }

    public static bool goThroughBookedBookings(int phoneNumber) // Проверява според телефонни номер на клиента дали даден букинг съществува във вече букнатите оферти
    {
        foreach (Booking hotel in bookingsHotelsBooked)
        {
            if (hotel.BookingOwner.Telephone == phoneNumber)
            {
                return true;
            }
        }

        foreach (Booking restaurant in bookingsRestaurantsBooked)
        {
            if (restaurant.BookingOwner.Telephone == phoneNumber)
            {
                return true;
            }
        }

        foreach (Booking services in bookingsServicesBooked)
        {
            if (services.BookingOwner.Telephone == phoneNumber)
            {
                return true;
            }
        }

        foreach (Booking ticket in bookingsTicketsBooked)
        {
            if (ticket.BookingOwner.Telephone == phoneNumber)
            {
                return true;
            }
        }
        return false;
    }
}