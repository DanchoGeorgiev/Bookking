namespace Bookking;

class Program
{
    static void Main(string[] args)
    {
        BookingMethods bookingMethods = new BookingMethods();
        
        Console.Write("Hello User, what is your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"====================Welcome to BookKings {name}====================");
        while (true)
        {
            Console.WriteLine("=====================================================================");
            Console.WriteLine("1. Create an Offer");
            Console.WriteLine("2. Book an Offer");
            Console.WriteLine("3. View Currents Offers");
            Console.WriteLine("4. View Current Booked Offers");
            Console.WriteLine("5. Search Offers");
            Console.WriteLine("6. Search For Currently Booked Offers");
            Console.WriteLine("7. View Customer List");
            Console.WriteLine("8. Exit");
            Console.WriteLine("=====================================================================");
            Console.Write("Enter your choice: ");
            int choice;

            while (true)
            {
                choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("1. Create an Offer");
                    Console.WriteLine("2. Book an Offer");
                    Console.WriteLine("3. View Currents Offers");
                    Console.WriteLine("4. View Current Booked Offers");
                    Console.WriteLine("5. Search Offers");
                    Console.WriteLine("6. Search For Currently Booked Offers");
                    Console.WriteLine("7. View Customer List");
                    Console.WriteLine("8. Exit");
                    Console.WriteLine("=====================================================================");
                    Console.Write("Enter your choice: ");
                }
            }
            
            if (choice == 1)
            {
                while (true)
                {
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("What type of booking you would like to create:");
                    Console.WriteLine("1. Hotel");
                    Console.WriteLine("2. Restaurant");
                    Console.WriteLine("3. Service");
                    Console.WriteLine("4. Ticket");
                    Console.WriteLine("5. Return to Main Menu");
                    Console.WriteLine("=====================================================================");
                    Console.Write("Enter your choice: ");
                    int choice2;
                    
                    
                    while (true)
                    {
                            choice2 = int.Parse(Console.ReadLine());
                            if (choice2 >= 1 && choice2 <= 5)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid choice");
                                Console.WriteLine("Press any key to continue: ");
                                Console.ReadLine();
                                Console.WriteLine("=====================================================================");
                                Console.WriteLine("1. Hotel");
                                Console.WriteLine("2. Restaurant");
                                Console.WriteLine("3. Service");
                                Console.WriteLine("4. Ticket");
                                Console.WriteLine("5. Return to Main Menu");
                                Console.WriteLine("=====================================================================");
                                Console.Write("Enter your choice: ");
                            }
                    }

                    if (choice2 == 1)
                    {
                            Booking booking = new Booking();
                            Console.WriteLine("=====================================================================");
                            booking.setBookingType("Hotel");
                            Console.Write("What is the name of the booking: ");
                            string bookingName = Console.ReadLine();
                            booking.setBookingName(bookingName);
                            Console.Write("Enter an ID of the booking: ");
                            int bookingID = int.Parse(Console.ReadLine());
                            booking.setBookingId(bookingID);
                            Console.Write("Set a capacity of the booking: ");
                            int bookingCapacity = int.Parse(Console.ReadLine());
                            booking.setCapacity(bookingCapacity);
                            Console.Write("Set the price of the booking: ");
                            int bookingPrice = int.Parse(Console.ReadLine());
                            booking.setBookingPrice(bookingPrice);
                            BookingMethods.createBooking(booking);
                            Console.WriteLine("=====================================================================");
                            Console.WriteLine("Booking successfully created!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                    }
                    else if (choice2 == 2)
                    {
                            Booking booking = new Booking();
                            Console.WriteLine("=====================================================================");
                            booking.setBookingType("Restaurant");
                            Console.Write("What is the name of the booking: ");
                            string bookingName = Console.ReadLine();
                            booking.setBookingName(bookingName);
                            Console.Write("Enter an ID of the booking: ");
                            int bookingID = int.Parse(Console.ReadLine());
                            booking.setBookingId(bookingID);
                            Console.Write("Set a capacity of the booking: ");
                            int bookingCapacity = int.Parse(Console.ReadLine());
                            booking.setCapacity(bookingCapacity);
                            Console.Write("Set the price of the booking: ");
                            int bookingPrice = int.Parse(Console.ReadLine());
                            booking.setBookingPrice(bookingPrice);
                            BookingMethods.createBooking(booking);
                            Console.WriteLine("=====================================================================");
                            Console.WriteLine("Booking successfully created!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                    }
                    else if (choice2 == 3)
                    {
                            Booking booking = new Booking();
                            Console.WriteLine("=====================================================================");
                            booking.setBookingType("Service");
                            Console.Write("What is the name of the booking: ");
                            string bookingName = Console.ReadLine();
                            booking.setBookingName(bookingName);
                            Console.Write("Enter an ID of the booking: ");
                            int bookingID = int.Parse(Console.ReadLine());
                            booking.setBookingId(bookingID);
                            Console.Write("Set a capacity of the booking: ");
                            int bookingCapacity = int.Parse(Console.ReadLine());
                            booking.setCapacity(bookingCapacity);
                            Console.Write("Set the price of the booking: ");
                            int bookingPrice = int.Parse(Console.ReadLine());
                            booking.setBookingPrice(bookingPrice);
                            BookingMethods.createBooking(booking);
                            Console.WriteLine("=====================================================================");
                            Console.WriteLine("Booking successfully created!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                    }
                    else if (choice2 == 4)
                    {
                            Booking booking = new Booking();
                            Console.WriteLine("=====================================================================");
                            booking.setBookingType("Ticket");
                            Console.Write("What is the name of the booking: ");
                            string bookingName = Console.ReadLine();
                            booking.setBookingName(bookingName);
                            Console.Write("Enter an ID of the booking: ");
                            int bookingID = int.Parse(Console.ReadLine());
                            booking.setBookingId(bookingID);
                            Console.Write("Set a capacity of the booking: ");
                            int bookingCapacity = int.Parse(Console.ReadLine());
                            booking.setCapacity(bookingCapacity);
                            Console.Write("Set the price of the booking: ");
                            int bookingPrice = int.Parse(Console.ReadLine());
                            booking.setBookingPrice(bookingPrice);
                            BookingMethods.createBooking(booking);
                            Console.WriteLine("=====================================================================");
                            Console.WriteLine("Booking successfully created!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                    }
                    else if (choice2 == 5)
                    { 
                        break;
                    }
                }
            }
            else if (choice == 2)
            {
                while (true)
                {
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("Is it your first time here?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.WriteLine("=====================================================================");
                    Console.Write("Enter your choice: ");

                    int choiceCustomer;

                    while (true)
                    {
                        choiceCustomer = int.Parse(Console.ReadLine());
                        if (choiceCustomer >= 1 && choiceCustomer <= 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid choice");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            Console.WriteLine("=====================================================================");
                            Console.WriteLine("1. Yes");
                            Console.WriteLine("2. No");
                            Console.WriteLine("=====================================================================");
                            Console.Write("Enter your choice: ");
                        }
                    }

                    if (choiceCustomer == 2)
                    {
                        Console.WriteLine("=====================================================================");
                        Console.Write("Enter the phone number of the customer: ");
                        int phoneNumber;
                        while (true)
                        {
                            phoneNumber = int.Parse(Console.ReadLine());
                            Customer buff = new Customer();
                            foreach (Customer customer1 in BookingMethods.listOfCustomers)
                            {
                                buff = customer1;
                            }
                            if (phoneNumber == buff.Telephone)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("The given phone number is either invalid or it doesn't exist." +
                                                  "Please enter a valid phone number.");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                Console.WriteLine("=====================================================================");
                                Console.Write("Enter the phone number of the customer: ");
                            }
                        }
                        Customer customer = BookingMethods.findCustomer(phoneNumber);
                        BookingMethods.listOfCustomers.Add(customer);
                        Console.WriteLine("=====================================================================");
                        Console.WriteLine($"Hello {customer.FirstName} {customer.LastName}! What type of booking would you like: ");
                        Console.WriteLine("1. Hotel");
                        Console.WriteLine("2. Restaurant");
                        Console.WriteLine("3. Service");
                        Console.WriteLine("4. Ticket");
                        Console.WriteLine("5. Return to Main Menu");
                        Console.WriteLine("=====================================================================");
                        Console.Write("Enter your choice: ");
                        
                        int choiceCustomer1;
                        while (true)
                        {
                            choiceCustomer1 = int.Parse(Console.ReadLine());
                            if (choiceCustomer1 >= 1 && choiceCustomer1 <= 5)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid choice");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                Console.WriteLine("=====================================================================");
                                Console.WriteLine("1. Hotel");
                                Console.WriteLine("2. Restaurant");
                                Console.WriteLine("3. Service");
                                Console.WriteLine("4. Ticket");
                                Console.WriteLine("5. Return to Main Menu");
                                Console.WriteLine("=====================================================================");
                                Console.Write("Enter your choice: ");

                            }
                        }

                        if (choiceCustomer1 == 1)
                        {
                            Console.WriteLine("============================================================");
                            Console.WriteLine("Here is a list of currently available hotel offers: ");
                            BookingMethods.listOfFreeHotels();
                            Console.WriteLine("============================================================");
                            Console.Write("To choose an offer, please enter the offer's ID: ");
                            int offerID;
                            while (true)
                            {
                                offerID = int.Parse(Console.ReadLine());
                                Booking buff = new Booking();
                                foreach (Booking booking in BookingMethods.bookingsHotels)
                                {
                                    buff = booking;
                                }
                                if (buff.BookingId == offerID)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid offer's ID");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine("============================================================");
                                    BookingMethods.listOfFreeHotels();
                                    Console.WriteLine("============================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                }
                            }
                            Dates date  = new Dates();
                            while (true)
                            {
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a month of the booking: ");
                                int month;
                                while (true)
                                {
                                    month = int.Parse(Console.ReadLine());
                                    if (month >= 1 && month <= 12)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid month");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine("==========================================================");
                                        Console.Write("Set a month of the booking: ");
                                    }
                                }
                                date.setMonth(month);
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a starting day of the booking: ");
                                
                                int startDay;

                                while (true)
                                {
                                    startDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (startDay >= 1 && startDay <= 31)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (startDay >= 1 && startDay <= 30)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (startDay >= 1 && startDay <= 28)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                }
                                date.setStartDate(startDay);
                                
                                Console.WriteLine("=======================================================");
                                Console.Write("Set a ending day of the booking: ");
                                int endDay;

                                while (true)
                                {
                                    endDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (endDay >= 1 && endDay <= 31 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (endDay >= 1 && endDay <= 30 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (endDay >= 1 && endDay <= 28 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                }
                                date.setEndDate(endDay);
                                Console.WriteLine($"Dates are: {date.Month}, sd{date.StartDate}, ed{date.EndDate}");
                                if (BookingMethods.bookOffer(offerID, customer, date))
                                {
                                    Console.WriteLine("Offer is booked on these days");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine("========================================================");
                            Console.WriteLine("You have successfully booked an offer!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (choiceCustomer1 == 2)
                        {
                            Console.WriteLine("============================================================");
                            Console.WriteLine("Here is a list of currently available restaurant offers: ");
                            BookingMethods.listOfFreeRestaurants();
                            Console.WriteLine("============================================================");
                            Console.Write("To choose an offer, please enter the offer's ID: ");
                            int offerID;
                            while (true)
                            {
                                offerID = int.Parse(Console.ReadLine());
                                Booking buff = new Booking();
                                foreach (Booking booking in BookingMethods.bookingsRestaurants)
                                {
                                    buff = booking;
                                }
                                if (buff.BookingId == offerID)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid offer's ID");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine("============================================================");
                                    BookingMethods.listOfFreeRestaurants();
                                    Console.WriteLine("============================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                }
                            }
                            Dates date  = new Dates();
                            while (true)
                            {
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a month of the booking: ");
                                int month;
                                while (true)
                                {
                                    month = int.Parse(Console.ReadLine());
                                    if (month >= 1 && month <= 12)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid month");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine("==========================================================");
                                        Console.Write("Set a month of the booking: ");
                                    }
                                }
                                date.setMonth(month);
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a starting day of the booking: ");
                                int startDay;

                                while (true)
                                {
                                    startDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (startDay >= 1 && startDay <= 31)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (startDay >= 1 && startDay <= 30)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (startDay >= 1 && startDay <= 28)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                }
                                date.setStartDate(startDay);
                                
                                Console.WriteLine("=======================================================");
                                Console.Write("Set a ending day of the booking: ");
                                int endDay;

                                while (true)
                                {
                                    endDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (endDay >= 1 && endDay <= 31 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (endDay >= 1 && endDay <= 30 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (endDay >= 1 && endDay <= 28 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                }
                                date.setEndDate(endDay);
                                break;
                            }
                            BookingMethods.bookOffer(offerID, customer, date);
                            Console.WriteLine("========================================================");
                            Console.WriteLine("You have successfully booked an offer!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (choiceCustomer1 == 3)
                        {
                            Console.WriteLine("============================================================");
                            Console.WriteLine("Here is a list of currently available service offers: ");
                            BookingMethods.listOfFreeServices();
                            Console.WriteLine("============================================================");
                            Console.Write("To choose an offer, please enter the offer's ID: ");
                            int offerID;
                            while (true)
                            {
                                offerID = int.Parse(Console.ReadLine());
                                Booking buff = new Booking();
                                foreach (Booking booking in BookingMethods.bookingsServices)
                                {
                                    buff = booking;
                                }
                                if (buff.BookingId == offerID)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid offer's ID");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine("============================================================");
                                    BookingMethods.listOfFreeHotels();
                                    Console.WriteLine("============================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                }
                            }
                            Dates date  = new Dates();
                            while (true)
                            {
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a month of the booking: ");
                                int month;
                                while (true)
                                {
                                    month = int.Parse(Console.ReadLine());
                                    if (month >= 1 && month <= 12)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid month");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine("==========================================================");
                                        Console.Write("Set a month of the booking: ");
                                    }
                                }
                                date.setMonth(month);
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a starting day of the booking: ");
                                int startDay;

                                while (true)
                                {
                                    startDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (startDay >= 1 && startDay <= 31)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (startDay >= 1 && startDay <= 30)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (startDay >= 1 && startDay <= 28)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                }
                                date.setStartDate(startDay);
                                
                                Console.WriteLine("=======================================================");
                                Console.Write("Set a ending day of the booking: ");
                                int endDay;

                                while (true)
                                {
                                    endDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (endDay >= 1 && endDay <= 31 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (endDay >= 1 && endDay <= 30 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (endDay >= 1 && endDay <= 28 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                }
                                date.setEndDate(endDay);
                                break;
                            }
                            BookingMethods.bookOffer(offerID, customer, date);
                            Console.WriteLine("========================================================");
                            Console.WriteLine("You have successfully booked an offer!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (choiceCustomer1 == 4)
                        {
                            Console.WriteLine("============================================================");
                            Console.WriteLine("Here is a list of currently available ticket offers: ");
                            BookingMethods.listOfFreeHotels();
                            Console.WriteLine("============================================================");
                            Console.Write("To choose an offer, please enter the offer's ID: ");
                            int offerID;
                            while (true)
                            {
                                offerID = int.Parse(Console.ReadLine());
                                Booking buff = new Booking();
                                foreach (Booking booking in BookingMethods.bookingsTickets)
                                {
                                    buff = booking;
                                }
                                if (buff.BookingId == offerID)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid offer's ID");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine("============================================================");
                                    BookingMethods.listOfFreeHotels();
                                    Console.WriteLine("============================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                }
                            }
                            Dates date  = new Dates();
                            while (true)
                            {
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a month of the booking: ");
                                int month;
                                while (true)
                                {
                                    month = int.Parse(Console.ReadLine());
                                    if (month >= 1 && month <= 12)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid month");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine("==========================================================");
                                        Console.Write("Set a month of the booking: ");
                                    }
                                }
                                date.setMonth(month);
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a starting day of the booking: ");
                                int startDay;

                                while (true)
                                {
                                    startDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (startDay >= 1 && startDay <= 31)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (startDay >= 1 && startDay <= 30)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (startDay >= 1 && startDay <= 28)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                }
                                date.setStartDate(startDay);
                                
                                Console.WriteLine("=======================================================");
                                Console.Write("Set a ending day of the booking: ");
                                int endDay;

                                while (true)
                                {
                                    endDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (endDay >= 1 && endDay <= 31 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (endDay >= 1 && endDay <= 30 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (endDay >= 1 && endDay <= 28 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                }
                                date.setEndDate(endDay);
                                break;
                            }
                            BookingMethods.bookOffer(offerID, customer, date);
                            Console.WriteLine("========================================================");
                            Console.WriteLine("You have successfully booked an offer!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (choiceCustomer1 == 5)
                        {
                            break;
                        }
                    }
                    else if (choiceCustomer == 1)
                    {
                        Customer newCustomer = new Customer();
                        Console.WriteLine("========================================================");
                        Console.WriteLine("Welcome to BookKing!");
                        Console.WriteLine("What is your first name?");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("What is your last name?");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("What is your phone number?");
                        int phoneNumber = int.Parse(Console.ReadLine());
                        newCustomer.setFirstName(firstName);
                        newCustomer.setLastName(lastName);
                        newCustomer.setTelephone(phoneNumber);
                        Console.WriteLine("Congratulations! You have just become a member of the BookKing!");
                        BookingMethods.listOfCustomers.Add(newCustomer);
                        Console.WriteLine("=====================================================================");
                        Console.WriteLine($"Hello {newCustomer.FirstName} {newCustomer.LastName}! What type of booking would you like: ");
                        Console.WriteLine("1. Hotel");
                        Console.WriteLine("2. Restaurant");
                        Console.WriteLine("3. Service");
                        Console.WriteLine("4. Ticket");
                        Console.WriteLine("5. Return to Main Menu");
                        Console.WriteLine("=====================================================================");
                        Console.Write("Enter your choice: ");
                        
                        int choiceCustomer2;
                        while (true)
                        {
                            choiceCustomer2 = int.Parse(Console.ReadLine());
                            if (choiceCustomer2 >= 1 && choiceCustomer2 <= 5)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid choice");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                Console.WriteLine("=====================================================================");
                                Console.WriteLine("1. Hotel");
                                Console.WriteLine("2. Restaurant");
                                Console.WriteLine("3. Service");
                                Console.WriteLine("4. Ticket");
                                Console.WriteLine("5. Return to Main Menu");
                                Console.WriteLine("=====================================================================");
                                Console.Write("Enter your choice: ");

                            }
                        }

                        if (choiceCustomer2 == 1)
                        {
                            Console.WriteLine("============================================================");
                            Console.WriteLine("Here is a list of currently available hotel offers: ");
                            BookingMethods.listOfFreeHotels();
                            Console.WriteLine("============================================================");
                            Console.Write("To choose an offer, please enter the offer's ID: ");
                            int offerID;
                            while (true)
                            {
                                offerID = int.Parse(Console.ReadLine());
                                Booking buff = new Booking();
                                foreach (Booking booking in BookingMethods.bookingsHotels)
                                {
                                    buff = booking;
                                }
                                if (buff.BookingId == offerID)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid offer's ID");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine("============================================================");
                                    BookingMethods.listOfFreeHotels();
                                    Console.WriteLine("============================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                }
                            }
                            Dates date  = new Dates();
                            while (true)
                            {
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a month of the booking: ");
                                int month;
                                while (true)
                                {
                                    month = int.Parse(Console.ReadLine());
                                    if (month >= 1 && month <= 12)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid month");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine("==========================================================");
                                        Console.Write("Set a month of the booking: ");
                                    }
                                }
                                date.setMonth(month);
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a starting day of the booking: ");
                                int startDay;

                                while (true)
                                {
                                    startDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (startDay >= 1 && startDay <= 31)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (startDay >= 1 && startDay <= 30)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (startDay >= 1 && startDay <= 28)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                }
                                date.setStartDate(startDay);
                                
                                Console.WriteLine("=======================================================");
                                Console.Write("Set a ending day of the booking: ");
                                int endDay;

                                while (true)
                                {
                                    endDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (endDay >= 1 && endDay <= 31 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (endDay >= 1 && endDay <= 30 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (endDay >= 1 && endDay <= 28 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                }
                                date.setEndDate(endDay);

                                if (BookingMethods.bookOffer(offerID, newCustomer, date)) 
                                {
                                    Console.WriteLine("Offer is booked on these days!");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine("========================================================");
                            Console.WriteLine("You have successfully booked an offer!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (choiceCustomer2 == 2)
                        {
                            Console.WriteLine("============================================================");
                            Console.WriteLine("Here is a list of currently available restaurant offers: ");
                            BookingMethods.listOfFreeRestaurants();
                            Console.WriteLine("============================================================");
                            Console.Write("To choose an offer, please enter the offer's ID: ");
                            int offerID;
                            while (true)
                            {
                                offerID = int.Parse(Console.ReadLine());
                                Booking buff = new Booking();
                                foreach (Booking booking in BookingMethods.bookingsRestaurants)
                                {
                                    buff = booking;
                                }
                                if (buff.BookingId == offerID)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid offer's ID");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine("============================================================");
                                    BookingMethods.listOfFreeRestaurants();
                                    Console.WriteLine("============================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                }
                            }
                            Dates date  = new Dates();
                            while (true)
                            {
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a month of the booking: ");
                                int month;
                                while (true)
                                {
                                    month = int.Parse(Console.ReadLine());
                                    if (month >= 1 && month <= 12)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid month");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine("==========================================================");
                                        Console.Write("Set a month of the booking: ");
                                    }
                                }
                                date.setMonth(month);
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a starting day of the booking: ");
                                int startDay;

                                while (true)
                                {
                                    startDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (startDay >= 1 && startDay <= 31)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (startDay >= 1 && startDay <= 30)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (startDay >= 1 && startDay <= 28)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                }
                                date.setStartDate(startDay);
                                
                                Console.WriteLine("=======================================================");
                                Console.Write("Set a ending day of the booking: ");
                                int endDay;

                                while (true)
                                {
                                    endDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (endDay >= 1 && endDay <= 31 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (endDay >= 1 && endDay <= 30 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (endDay >= 1 && endDay <= 28 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                }
                                date.setEndDate(endDay);
                                break;
                            }
                            BookingMethods.bookOffer(offerID, newCustomer, date);
                            Console.WriteLine("========================================================");
                            Console.WriteLine("You have successfully booked an offer!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (choiceCustomer2 == 3)
                        {
                            Console.WriteLine("============================================================");
                            Console.WriteLine("Here is a list of currently available service offers: ");
                            BookingMethods.listOfFreeServices();
                            Console.WriteLine("============================================================");
                            Console.Write("To choose an offer, please enter the offer's ID: ");
                            int offerID;
                            while (true)
                            {
                                offerID = int.Parse(Console.ReadLine());
                                Booking buff = new Booking();
                                foreach (Booking booking in BookingMethods.bookingsServices)
                                {
                                    buff = booking;
                                }
                                if (buff.BookingId == offerID)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid offer's ID");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine("============================================================");
                                    BookingMethods.listOfFreeHotels();
                                    Console.WriteLine("============================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                }
                            }
                            Dates date  = new Dates();
                            while (true)
                            {
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a month of the booking: ");
                                int month;
                                while (true)
                                {
                                    month = int.Parse(Console.ReadLine());
                                    if (month >= 1 && month <= 12)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid month");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine("==========================================================");
                                        Console.Write("Set a month of the booking: ");
                                    }
                                }
                                date.setMonth(month);
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a starting day of the booking: ");
                                int startDay;

                                while (true)
                                {
                                    startDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (startDay >= 1 && startDay <= 31)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (startDay >= 1 && startDay <= 30)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (startDay >= 1 && startDay <= 28)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                }
                                date.setStartDate(startDay);
                                
                                Console.WriteLine("=======================================================");
                                Console.Write("Set a ending day of the booking: ");
                                int endDay;

                                while (true)
                                {
                                    endDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (endDay >= 1 && endDay <= 31 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (endDay >= 1 && endDay <= 30 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (endDay >= 1 && endDay <= 28 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                }
                                date.setEndDate(endDay);
                                break;
                            }
                            BookingMethods.bookOffer(offerID, newCustomer, date);
                            Console.WriteLine("========================================================");
                            Console.WriteLine("You have successfully booked an offer!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (choiceCustomer2 == 4)
                        {
                            Console.WriteLine("============================================================");
                            Console.WriteLine("Here is a list of currently available ticket offers: ");
                            BookingMethods.listOfFreeHotels();
                            Console.WriteLine("============================================================");
                            Console.Write("To choose an offer, please enter the offer's ID: ");
                            int offerID;
                            while (true)
                            {
                                offerID = int.Parse(Console.ReadLine());
                                Booking buff = new Booking();
                                foreach (Booking booking in BookingMethods.bookingsTickets)
                                {
                                    buff = booking;
                                }
                                if (buff.BookingId == offerID)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid offer's ID");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine("============================================================");
                                    BookingMethods.listOfFreeHotels();
                                    Console.WriteLine("============================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                }
                            }
                            Dates date  = new Dates();
                            while (true)
                            {
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a month of the booking: ");
                                int month;
                                while (true)
                                {
                                    month = int.Parse(Console.ReadLine());
                                    if (month >= 1 && month <= 12)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid month");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine("==========================================================");
                                        Console.Write("Set a month of the booking: ");
                                    }
                                }
                                date.setMonth(month);
                                Console.WriteLine("==========================================================");
                                Console.Write("Set a starting day of the booking: ");
                                int startDay;

                                while (true)
                                {
                                    startDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (startDay >= 1 && startDay <= 31)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (startDay >= 1 && startDay <= 30)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (startDay >= 1 && startDay <= 28)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid starting day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set a starting day of the booking: ");
                                        }
                                    }
                                }
                                date.setStartDate(startDay);
                                
                                Console.WriteLine("=======================================================");
                                Console.Write("Set a ending day of the booking: ");
                                int endDay;

                                while (true)
                                {
                                    endDay = int.Parse(Console.ReadLine());
                                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                        month == 10 || month == 12)
                                    {
                                        if (endDay >= 1 && endDay <= 31 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if(month == 4 || month == 6 || month == 9 || month == 11)
                                    {
                                        if (endDay >= 1 && endDay <= 30 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                    
                                    else if (month == 2)
                                    {
                                        if (endDay >= 1 && endDay <= 28 && endDay >= startDay)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending day cannot be lower than the starting day");
                                            Console.WriteLine("Please enter a valid ending day");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine("==========================================================");
                                            Console.Write("Set an ending day of the booking: ");
                                        }
                                    }
                                }
                                date.setEndDate(endDay);
                                break;
                            }
                            BookingMethods.bookOffer(offerID, newCustomer, date);
                            Console.WriteLine("========================================================");
                            Console.WriteLine("You have successfully booked an offer!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (choiceCustomer2 == 5)
                        {
                            break;
                        }
                        
                    }
                }
            }
            else if (choice == 4)
            {
                BookingMethods.currentBookedOffers();
            }
        }
    }
}