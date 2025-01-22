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
            Console.WriteLine("8. Remove an Offer");
            Console.WriteLine("9. Cancel a Booking");
            Console.WriteLine("10. Exit");
            Console.WriteLine("=====================================================================");
            Console.Write("Enter your choice: ");
            int choice;

            while (true)
            {
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter only numbers");
                    }
                }
                
                if (choice >= 1 && choice <= 10)
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
                        while (true)
                        {
                            if (int.TryParse(Console.ReadLine(), out choice2))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter only numbers");
                            }
                        }
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
                            while (true)
                            {
                                int bookingID;
                                while (true)
                                {
                                    if (int.TryParse(Console.ReadLine(), out bookingID))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter only numbers");
                                    }
                                }

                                if (BookingMethods.checkIfIdAvailable(bookingID))
                                {
                                    Console.WriteLine("ID Already exists");
                                    Console.WriteLine("Try Again");
                                }
                                else
                                {
                                    booking.setBookingId(bookingID);
                                    break;
                                }
                            }
                            Console.Write("Set a capacity of the booking: ");
                            int bookingCapacity;
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out bookingCapacity))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
                            booking.setCapacity(bookingCapacity);
                            Console.Write("Set the price of the booking: ");
                            double bookingPrice;
                            while (true)
                            {
                                if (double.TryParse(Console.ReadLine(), out bookingPrice))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
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
                            while (true)
                            {
                                int bookingID;
                                while (true)
                                {
                                    if (int.TryParse(Console.ReadLine(), out bookingID))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter only numbers");
                                    }
                                }

                                if (BookingMethods.checkIfIdAvailable(bookingID))
                                {
                                    Console.WriteLine("ID Already exists");
                                    Console.WriteLine("Try Again");
                                }
                                else
                                {
                                    booking.setBookingId(bookingID);
                                    break;
                                }
                            }

                            Console.Write("Set a capacity of the booking: ");
                            int bookingCapacity;
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out bookingCapacity))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
                            booking.setCapacity(bookingCapacity);
                            Console.Write("Set the price of the booking: ");
                            double bookingPrice;
                            while (true)
                            {
                                if (double.TryParse(Console.ReadLine(), out bookingPrice))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
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
                            while (true)
                            {
                                int bookingID;
                                while (true)
                                {
                                    if (int.TryParse(Console.ReadLine(), out bookingID))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter only numbers");
                                    }
                                }

                                if (BookingMethods.checkIfIdAvailable(bookingID))
                                {
                                    Console.WriteLine("ID Already exists");
                                    Console.WriteLine("Try Again");
                                }
                                else
                                {
                                    booking.setBookingId(bookingID);
                                    break;
                                }
                            }
                            Console.Write("Set a capacity of the booking: ");
                            int bookingCapacity;
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out bookingCapacity))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
                            booking.setCapacity(bookingCapacity);
                            Console.Write("Set the price of the booking: ");
                            double bookingPrice;
                            while (true)
                            {
                                if (double.TryParse(Console.ReadLine(), out bookingPrice))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
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
                            while (true)
                            {
                                int bookingID;
                                while (true)
                                {
                                    if (int.TryParse(Console.ReadLine(), out bookingID))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter only numbers");
                                    }
                                }

                                if (BookingMethods.checkIfIdAvailable(bookingID))
                                {
                                    Console.WriteLine("ID Already exists");
                                    Console.WriteLine("Try Again");
                                }
                                else
                                {
                                    booking.setBookingId(bookingID);
                                    break;
                                }
                            }
                            Console.Write("Set a capacity of the booking: ");
                            int bookingCapacity;
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out bookingCapacity))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
                            booking.setCapacity(bookingCapacity);
                            Console.Write("Set the price of the booking: ");
                            double bookingPrice;
                            while (true)
                            {
                                if (double.TryParse(Console.ReadLine(), out bookingPrice))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
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
                    if (BookingMethods.bookingsHotels.Count == 0 && BookingMethods.bookingsRestaurants.Count == 0 &&
                        BookingMethods.bookingsServices.Count == 0 && BookingMethods.bookingsTickets.Count == 0)
                    {
                        Console.WriteLine("There are currently no offers!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    }
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("Is it your first time here?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.WriteLine("=====================================================================");
                    Console.Write("Enter your choice: ");

                    int choiceCustomer;

                    while (true)
                    {
                        while (true)
                        {
                            if (int.TryParse(Console.ReadLine(), out choiceCustomer))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter only numbers");
                            }
                        }
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
                        if (BookingMethods.listOfCustomers.Count == 0)
                        {
                            Console.WriteLine("There are currently no customers!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (BookingMethods.listOfCustomers.Count > 0)
                        {
                            Console.WriteLine("=====================================================================");
                            Console.Write("Enter the phone number of the customer: ");
                            int phoneNumber;
                            while (true)
                            {
                                while (true)
                                {
                                    if (int.TryParse(Console.ReadLine(), out phoneNumber))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter only numbers");
                                    }
                                }
                                bool isPhoneNumberValid = true;
                                foreach (Customer customer69 in BookingMethods.listOfCustomers)
                                {
                                    if (customer69.Telephone == phoneNumber)
                                    {
                                        isPhoneNumberValid = true;
                                        break;
                                    }
                                }

                                if (isPhoneNumberValid)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("The given phone number is either invalid or it doesn't exist." +
                                                      "Please enter a valid phone number.");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Enter the phone number of the customer: ");
                                }
                            }

                            Customer customer = BookingMethods.findCustomer(phoneNumber);
                            Console.WriteLine("=====================================================================");
                            Console.WriteLine(
                                $"Hello {customer.FirstName} {customer.LastName}! What type of booking would you like: ");
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
                                while (true)
                                {
                                    if (int.TryParse(Console.ReadLine(), out choiceCustomer1))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter only numbers");
                                    }
                                }
                                if (choiceCustomer1 >= 1 && choiceCustomer1 <= 5)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid choice");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("1. Hotel");
                                    Console.WriteLine("2. Restaurant");
                                    Console.WriteLine("3. Service");
                                    Console.WriteLine("4. Ticket");
                                    Console.WriteLine("5. Return to Main Menu");
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Enter your choice: ");

                                }
                            }

                            if (choiceCustomer1 == 1)
                            {
                                if (BookingMethods.bookingsHotels.Count == 0)
                                {
                                    Console.WriteLine("There are currently no bookings!");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                                else if (BookingMethods.bookingsHotels.Count > 0)
                                {
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("Here is a list of currently available hotel offers: ");
                                    BookingMethods.listOfFreeHotels();
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                    int offerID;
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out offerID))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }

                                        if (BookingMethods.checkIfIdAvailable(offerID))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid offer's ID");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            BookingMethods.listOfFreeHotels();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("To choose an offer, please enter the offer's ID: ");
                                        }
                                    }

                                    Dates date1 = new Dates();
                                    while (true)
                                    {
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a month of the booking: ");
                                        int month;
                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out month))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
                                            if (month >= 1 && month <= 12)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid month");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a month of the booking: ");
                                            }
                                        }

                                        date1.setMonth(month);
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a starting day of the booking: ");

                                        int startDay;

                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out startDay))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
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
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set a starting day of the booking: ");
                                                }
                                            }

                                            else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                    Console.WriteLine(
                                                        "=====================================================================");
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
                                                        "=====================================================================");
                                                    Console.Write("Set a starting day of the booking: ");
                                                }
                                            }
                                        }

                                        date1.setStartDate(startDay);

                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a ending day of the booking: ");
                                        int endDay;

                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out endDay))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
                                            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                                month == 10 || month == 12)
                                            {
                                                if (endDay >= 1 && endDay <= 31)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }

                                            else if (month == 4 || month == 6 || month == 9 || month == 11)
                                            {
                                                if (endDay >= 1 && endDay <= 30)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }

                                            else if (month == 2)
                                            {
                                                if (endDay >= 1 && endDay <= 28)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }
                                        }

                                        date1.setEndDate(endDay);
                                        if (BookingMethods.bookOffer(offerID, customer, date1))
                                        {
                                            Console.WriteLine("Offer is booked on these days");
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("You have successfully booked an offer!");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            else if (choiceCustomer1 == 2)
                            {
                                if (BookingMethods.bookingsRestaurants.Count == 0)
                                {
                                    Console.WriteLine("There are currently no bookings!");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                                else if (BookingMethods.bookingsRestaurants.Count > 0)
                                {
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("Here is a list of currently available restaurant offers: ");
                                    BookingMethods.listOfFreeRestaurants();
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                    int offerID;
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out offerID))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (BookingMethods.checkIfIdAvailable(offerID))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid offer's ID");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            BookingMethods.listOfFreeRestaurants();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("To choose an offer, please enter the offer's ID: ");
                                        }
                                    }

                                    Dates date = new Dates();
                                    while (true)
                                    {
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a month of the booking: ");
                                        int month;
                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out month))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
                                            if (month >= 1 && month <= 12)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid month");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a month of the booking: ");
                                            }
                                        }

                                        date.setMonth(month);
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a starting day of the booking: ");
                                        int startDay;

                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out startDay))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
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
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set a starting day of the booking: ");
                                                }
                                            }

                                            else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                    Console.WriteLine(
                                                        "=====================================================================");
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
                                                        "=====================================================================");
                                                    Console.Write("Set a starting day of the booking: ");
                                                }
                                            }
                                        }

                                        date.setStartDate(startDay);

                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a ending day of the booking: ");
                                        int endDay;

                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out endDay))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
                                            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                                month == 10 || month == 12)
                                            {
                                                if (endDay >= 1 && endDay <= 31)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }

                                            else if (month == 4 || month == 6 || month == 9 || month == 11)
                                            {
                                                if (endDay >= 1 && endDay <= 30)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }

                                            else if (month == 2)
                                            {
                                                if (endDay >= 1 && endDay <= 28)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }
                                        }

                                        date.setEndDate(endDay);
                                        if (BookingMethods.bookOffer(offerID, customer, date))
                                        {
                                            Console.WriteLine("Offer is booked on these days");
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("You have successfully booked an offer!");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            else if (choiceCustomer1 == 3)
                            {
                                if (BookingMethods.bookingsServices.Count == 0)
                                {
                                    Console.WriteLine("There are currently no bookings!");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                                else if (BookingMethods.bookingsServices.Count > 0)
                                {
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("Here is a list of currently available service offers: ");
                                    BookingMethods.listOfFreeServices();
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                    int offerID;
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out offerID))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (BookingMethods.checkIfIdAvailable(offerID))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid offer's ID");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            BookingMethods.listOfFreeServices();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("To choose an offer, please enter the offer's ID: ");
                                        }
                                    }

                                    Dates date = new Dates();
                                    while (true)
                                    {
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a month of the booking: ");
                                        int month;
                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out month))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
                                            if (month >= 1 && month <= 12)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid month");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a month of the booking: ");
                                            }
                                        }

                                        date.setMonth(month);
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a starting day of the booking: ");
                                        int startDay;

                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out startDay))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
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
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set a starting day of the booking: ");
                                                }
                                            }

                                            else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                    Console.WriteLine(
                                                        "=====================================================================");
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
                                                        "=====================================================================");
                                                    Console.Write("Set a starting day of the booking: ");
                                                }
                                            }
                                        }

                                        date.setStartDate(startDay);

                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a ending day of the booking: ");
                                        int endDay;

                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out endDay))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
                                            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                                month == 10 || month == 12)
                                            {
                                                if (endDay >= 1 && endDay <= 31)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }

                                            else if (month == 4 || month == 6 || month == 9 || month == 11)
                                            {
                                                if (endDay >= 1 && endDay <= 30)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }

                                            else if (month == 2)
                                            {
                                                if (endDay >= 1 && endDay <= 28)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }
                                        }

                                        date.setEndDate(endDay);
                                        if (BookingMethods.bookOffer(offerID, customer, date))
                                        {
                                            Console.WriteLine("Offer is booked on these days");
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("You have successfully booked an offer!");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            else if (choiceCustomer1 == 4)
                            {
                                if (BookingMethods.bookingsTickets.Count == 0)
                                {
                                    Console.WriteLine("There are currently no bookings!");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                                else if (BookingMethods.bookingsTickets.Count > 0)
                                {
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("Here is a list of currently available ticket offers: ");
                                    BookingMethods.listOfFreeTickets();
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("To choose an offer, please enter the offer's ID: ");
                                    int
                                        offerID; // Всичко, което съм инициализирал в даден блок от код си остава в този блок от код и НЕ МОЖЕ да се използва извън него
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out offerID))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (BookingMethods.checkIfIdAvailable(offerID))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid offer's ID");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            BookingMethods.listOfFreeTickets();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("To choose an offer, please enter the offer's ID: ");
                                        }
                                    }

                                    Dates date = new Dates();
                                    while (true)
                                    {
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a month of the booking: ");
                                        int month;
                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out month))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
                                            if (month >= 1 && month <= 12)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid month");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a month of the booking: ");
                                            }
                                        }

                                        date.setMonth(month);
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a starting day of the booking: ");
                                        int startDay;

                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out startDay))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
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
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set a starting day of the booking: ");
                                                }
                                            }

                                            else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                    Console.WriteLine(
                                                        "=====================================================================");
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
                                                        "=====================================================================");
                                                    Console.Write("Set a starting day of the booking: ");
                                                }
                                            }
                                        }

                                        date.setStartDate(startDay);

                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("Set a ending day of the booking: ");
                                        int endDay;

                                        while (true)
                                        {
                                            while (true)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out endDay))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter only numbers");
                                                }
                                            }
                                            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                                month == 10 || month == 12)
                                            {
                                                if (endDay >= 1 && endDay <= 31)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }

                                            else if (month == 4 || month == 6 || month == 9 || month == 11)
                                            {
                                                if (endDay >= 1 && endDay <= 30)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine(
                                                        "Ending day cannot be lower than the starting day");
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }

                                            else if (month == 2)
                                            {
                                                if (endDay >= 1 && endDay <= 28)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please enter a valid ending day");
                                                    Console.WriteLine("Press any key to continue...");
                                                    Console.ReadLine();
                                                    Console.WriteLine(
                                                        "=====================================================================");
                                                    Console.Write("Set an ending day of the booking: ");
                                                }
                                            }
                                        }

                                        date.setEndDate(endDay);
                                        if (BookingMethods.bookOffer(offerID, customer, date))
                                        {
                                            Console.WriteLine("Offer is booked on these days");
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.WriteLine("You have successfully booked an offer!");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            else if (choiceCustomer1 == 5)
                            {
                                break;
                            }
                        }
                    }
                    else if (choiceCustomer == 1)
                    {
                        Customer newCustomer = new Customer();
                        Console.WriteLine("=====================================================================");
                        Console.WriteLine("Welcome to BookKing!");
                        Console.WriteLine("What is your first name?");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("What is your last name?");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("What is your phone number?");
                        int phoneNumber;
                        while (true)
                        {
                            if (int.TryParse(Console.ReadLine(), out phoneNumber))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter only numbers");
                            }
                        }
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
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out choiceCustomer2))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }
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
                            if (BookingMethods.bookingsHotels.Count == 0)
                            {
                                Console.WriteLine("There are currently no bookings!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (BookingMethods.bookingsHotels.Count > 0)
                            {
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("Here is a list of currently available hotel offers: ");
                                BookingMethods.listOfFreeHotels();
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.Write("To choose an offer, please enter the offer's ID: ");
                                int offerID;
                                while (true)
                                {
                                    while (true)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out offerID))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter only numbers");
                                        }
                                    }
                                    if (BookingMethods.checkIfIdAvailable(offerID))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid offer's ID");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine(
                                            "=====================================================================");
                                        BookingMethods.listOfFreeHotels();
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("To choose an offer, please enter the offer's ID: ");
                                    }
                                }

                                Dates date = new Dates();
                                while (true)
                                {
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a month of the booking: ");
                                    int month;
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out month))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month >= 1 && month <= 12)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid month");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("Set a month of the booking: ");
                                        }
                                    }

                                    date.setMonth(month);
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a starting day of the booking: ");
                                    int startDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out startDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
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
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                Console.WriteLine(
                                                    "=====================================================================");
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
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }
                                    }

                                    date.setStartDate(startDay);

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a ending day of the booking: ");
                                    int endDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out endDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                            month == 10 || month == 12)
                                        {
                                            if (endDay >= 1 && endDay <= 31)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                                        {
                                            if (endDay >= 1 && endDay <= 30)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 2)
                                        {
                                            if (endDay >= 1 && endDay <= 28)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
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

                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("You have successfully booked an offer!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (choiceCustomer2 == 2)
                        {
                            if (BookingMethods.bookingsRestaurants.Count == 0)
                            {
                                Console.WriteLine("There are currently no bookings!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (BookingMethods.bookingsRestaurants.Count > 0)
                            {
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("Here is a list of currently available restaurant offers: ");
                                BookingMethods.listOfFreeRestaurants();
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.Write("To choose an offer, please enter the offer's ID: ");
                                int offerID;
                                while (true)
                                {
                                    while (true)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out offerID))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter only numbers");
                                        }
                                    }
                                    if (BookingMethods.checkIfIdAvailable(offerID))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid offer's ID");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine(
                                            "=====================================================================");
                                        BookingMethods.listOfFreeRestaurants();
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("To choose an offer, please enter the offer's ID: ");
                                    }
                                }

                                Dates date = new Dates();
                                while (true)
                                {
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a month of the booking: ");
                                    int month;
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out month))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month >= 1 && month <= 12)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid month");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("Set a month of the booking: ");
                                        }
                                    }

                                    date.setMonth(month);
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a starting day of the booking: ");
                                    int startDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out startDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
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
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                Console.WriteLine(
                                                    "=====================================================================");
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
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }
                                    }

                                    date.setStartDate(startDay);

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a ending day of the booking: ");
                                    int endDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out endDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                            month == 10 || month == 12)
                                        {
                                            if (endDay >= 1 && endDay <= 31)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                                        {
                                            if (endDay >= 1 && endDay <= 30)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 2)
                                        {
                                            if (endDay >= 1 && endDay <= 28)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }
                                    }

                                    date.setEndDate(endDay);
                                    if (BookingMethods.bookOffer(offerID, newCustomer, date))
                                    {
                                        Console.WriteLine("Offer is booked on these days");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("You have successfully booked an offer!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (choiceCustomer2 == 3)
                        {
                            if (BookingMethods.bookingsServices.Count == 0)
                            {
                                Console.WriteLine("There are currently no bookings!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (BookingMethods.bookingsServices.Count > 0)
                            {
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("Here is a list of currently available service offers: ");
                                BookingMethods.listOfFreeServices();
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.Write("To choose an offer, please enter the offer's ID: ");
                                int offerID;
                                while (true)
                                {
                                    while (true)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out offerID))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter only numbers");
                                        }
                                    }
                                    if (BookingMethods.checkIfIdAvailable(offerID))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid offer's ID");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine(
                                            "=====================================================================");
                                        BookingMethods.listOfFreeServices();
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("To choose an offer, please enter the offer's ID: ");
                                    }
                                }

                                Dates date = new Dates();
                                while (true)
                                {
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a month of the booking: ");
                                    int month;
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out month))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month >= 1 && month <= 12)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid month");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("Set a month of the booking: ");
                                        }
                                    }

                                    date.setMonth(month);
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a starting day of the booking: ");
                                    int startDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out startDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
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
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                Console.WriteLine(
                                                    "=====================================================================");
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
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }
                                    }

                                    date.setStartDate(startDay);

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a ending day of the booking: ");
                                    int endDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out endDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                            month == 10 || month == 12)
                                        {
                                            if (endDay >= 1 && endDay <= 31)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                                        {
                                            if (endDay >= 1 && endDay <= 30)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 2)
                                        {
                                            if (endDay >= 1 && endDay <= 28)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }
                                    }

                                    date.setEndDate(endDay);
                                    if (BookingMethods.bookOffer(offerID, newCustomer, date))
                                    {
                                        Console.WriteLine("Offer is booked on these days");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("You have successfully booked an offer!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (choiceCustomer2 == 4)
                        {
                            if (BookingMethods.bookingsTickets.Count == 0)
                            {
                                Console.WriteLine("There are currently no bookings!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                            else if (BookingMethods.bookingsTickets.Count > 0)
                            {
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("Here is a list of currently available ticket offers: ");
                                BookingMethods.listOfFreeTickets();
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.Write("To choose an offer, please enter the offer's ID: ");
                                int offerID;
                                while (true)
                                {
                                    while (true)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out offerID))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter only numbers");
                                        }
                                    }
                                    if (BookingMethods.checkIfIdAvailable(offerID))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid offer's ID");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadLine();
                                        Console.WriteLine(
                                            "=====================================================================");
                                        BookingMethods.listOfFreeTickets();
                                        Console.WriteLine(
                                            "=====================================================================");
                                        Console.Write("To choose an offer, please enter the offer's ID: ");
                                    }
                                }

                                Dates date = new Dates();
                                while (true)
                                {
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a month of the booking: ");
                                    int month;
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out month))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month >= 1 && month <= 12)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid month");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("Set a month of the booking: ");
                                        }
                                    }

                                    date.setMonth(month);
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a starting day of the booking: ");
                                    int startDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out startDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
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
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                Console.WriteLine(
                                                    "=====================================================================");
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
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }
                                    }

                                    date.setStartDate(startDay);

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Set a ending day of the booking: ");
                                    int endDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out endDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                            month == 10 || month == 12)
                                        {
                                            if (endDay >= 1 && endDay <= 31)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                                        {
                                            if (endDay >= 1 && endDay <= 30)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 2)
                                        {
                                            if (endDay >= 1 && endDay <= 28)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }
                                    }

                                    date.setEndDate(endDay);
                                    if (BookingMethods.bookOffer(offerID, newCustomer, date))
                                    {
                                        Console.WriteLine("Offer is booked on these days");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("You have successfully booked an offer!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (choiceCustomer2 == 5)
                        {
                            break;
                        }
                        
                    }
                }
            }
            else if (choice == 3)
            {
                if (BookingMethods.bookingsHotels.Count == 0 && BookingMethods.bookingsRestaurants.Count == 0 &&
                    BookingMethods.bookingsServices.Count == 0 && BookingMethods.bookingsTickets.Count == 0)
                {
                    Console.WriteLine("There are currently no offers!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                Console.WriteLine(
                    "=====================================================================");
                BookingMethods.listOfFreeHotels();
                BookingMethods.listOfFreeRestaurants();
                BookingMethods.listOfFreeServices();
                BookingMethods.listOfFreeTickets();
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
            else if (choice == 4)
            {
                if (BookingMethods.bookingsHotelsBooked.Count == 0 && BookingMethods.bookingsRestaurantsBooked.Count == 0 &&
                    BookingMethods.bookingsServicesBooked.Count == 0 && BookingMethods.bookingsTicketsBooked.Count == 0)
                {
                    Console.WriteLine("There are currently no booked offers!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                BookingMethods.currentBookedOffers();
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
            else if (choice == 5)
            {
                while (true)
                {
                    if (BookingMethods.bookingsHotels.Count > 0 || BookingMethods.bookingsRestaurants.Count > 0 ||
                        BookingMethods.bookingsServices.Count > 0 || BookingMethods.bookingsTickets.Count > 0)
                    {
                        Console.WriteLine("=====================================================================");
                        Console.WriteLine("Enter 0, if you want to go back, or: ");
                        Console.Write("Enter the name of the booking you are searching for: ");
                        string nameOfBooking;
                        bool doesNameExist = true;
                        while (true)
                        {
                            nameOfBooking = Console.ReadLine();
                            if (nameOfBooking == "0")
                            {
                                break;
                            }
                            else if (BookingMethods.goThroughBookings(nameOfBooking))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Name doesn't exist!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("Enter 0, if you want to go back, or: ");
                                Console.Write("Enter the name of the booking you are searching for: ");
                            }
                        }

                        if (nameOfBooking == "0")
                        {
                            break;
                        }
                        else
                        {
                            BookingMethods.searchForAnOffer(nameOfBooking);
                        }
                    }
                    else if (BookingMethods.bookingsHotels.Count == 0 &&
                             BookingMethods.bookingsRestaurants.Count == 0 &&
                             BookingMethods.bookingsServices.Count == 0 && BookingMethods.bookingsTickets.Count == 0)
                    {
                        Console.WriteLine("There are currently no offers!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                }
            }
            else if (choice == 6)
            {
                while (true)
                {
                    if (BookingMethods.bookingsHotelsBooked.Count > 0 ||
                        BookingMethods.bookingsRestaurantsBooked.Count > 0 ||
                        BookingMethods.bookingsServicesBooked.Count > 0 ||
                        BookingMethods.bookingsTicketsBooked.Count > 0)
                    {
                        Console.WriteLine("=====================================================================");
                        Console.WriteLine("Enter 0, if you want to go back, or: ");
                        Console.Write("Enter the phone number of the client: ");
                        int phoneNumber;
                        bool doesNameExist = true;
                        while (true)
                        {
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out phoneNumber))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }

                            if (phoneNumber == 0)
                            {
                                break;
                            }
                            else if (BookingMethods.goThroughBookedBookings(phoneNumber))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Name doesn't exist!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                Console.WriteLine(
                                    "=====================================================================");
                                Console.WriteLine("Enter 0, if you want to go back, or: ");
                                Console.Write("Enter the name of the booking you are searching for: ");
                            }
                        }

                        if (phoneNumber == 0)
                        {
                            break;
                        }
                        else
                        {
                            BookingMethods.searchForBookedBookings(phoneNumber);
                        }
                    }
                    else if (BookingMethods.bookingsHotelsBooked.Count == 0 &&
                             BookingMethods.bookingsRestaurantsBooked.Count == 0 &&
                             BookingMethods.bookingsServicesBooked.Count == 0 &&
                             BookingMethods.bookingsTicketsBooked.Count == 0)
                    {
                        Console.WriteLine("There are currently no booked offers!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else if (choice == 7)
            {
                BookingMethods.listOfCustomersPrint();
                if (BookingMethods.listOfCustomers.Count == 0)
                {
                    Console.WriteLine ("There are no customers!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
            }
            else if (choice == 8)
            {
                while (true)
                {
                    if (BookingMethods.bookingsHotels.Count == 0 &&
                             BookingMethods.bookingsRestaurants.Count == 0 &&
                             BookingMethods.bookingsServices.Count == 0 &&
                             BookingMethods.bookingsTickets.Count == 0)
                    {
                        Console.WriteLine("There are currently no offers!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    }
                    else if (BookingMethods.bookingsHotels.Count > 0 ||
                             BookingMethods.bookingsRestaurants.Count > 0 ||
                             BookingMethods.bookingsServices.Count > 0 ||
                             BookingMethods.bookingsTickets.Count > 0)
                    {
                        Console.WriteLine(
                            "=====================================================================");
                        Console.WriteLine("Here is a list of the current offers: ");
                        BookingMethods.listOfFreeHotels();
                        BookingMethods.listOfFreeRestaurants();
                        BookingMethods.listOfFreeServices();
                        BookingMethods.listOfFreeTickets();
                        Console.WriteLine(
                            "=====================================================================");
                        Console.WriteLine("Enter 0, if you want to go back, or: ");
                        Console.Write("Enter the ID of the booking you would like to remove: ");
                        int bookingID;
                        while (true)
                        {
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out bookingID))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }

                            if (BookingMethods.checkIfIdAvailable(bookingID))
                            { 
                                break;
                            }
                            else if (bookingID == 0)
                            {
                                break;
                            }
                            else
                            { 
                                Console.WriteLine("The ID you entered does not exist!");
                            }
                        }
                        BookingMethods.removeBooking(bookingID);
                        break;
                    }
                }
            }
            else if (choice == 9)
            {
                while (true)
                {
                    if (BookingMethods.bookingsHotelsBooked.Count == 0 &&
                             BookingMethods.bookingsRestaurantsBooked.Count == 0 &&
                             BookingMethods.bookingsServicesBooked.Count == 0 &&
                             BookingMethods.bookingsTicketsBooked.Count == 0)
                    {
                        Console.WriteLine("There are currently no booked offers!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    }
                    else if (BookingMethods.bookingsHotelsBooked.Count > 0 ||
                             BookingMethods.bookingsRestaurantsBooked.Count > 0 ||
                             BookingMethods.bookingsServicesBooked.Count > 0 ||
                             BookingMethods.bookingsTicketsBooked.Count > 0)
                    {
                        Console.WriteLine(
                            "=====================================================================");
                        Console.WriteLine("Here is a list of the current booked offers: ");
                        BookingMethods.currentBookedOffers();
                        Console.WriteLine(
                            "=====================================================================");
                        Console.WriteLine("Enter 0, if you want to go back, or: ");
                        Console.Write("Enter the ID of the booking you would like to remove: ");
                        int bookingID;
                        while (true)
                        {
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out bookingID))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }

                            if (BookingMethods.checkIfIdAvailable(bookingID))
                            { 
                                break;
                            }
                            else if (bookingID == 0)
                            {
                                break;
                            }
                            else
                            { 
                                Console.WriteLine("The ID you entered does not exist!");
                            }
                        }

                        if (bookingID == 0)
                        {
                            break;
                        }
                        Console.WriteLine("Enter the phone number of the cusomer!");
                        int phoneNumber;
                        while (true)
                        {
                            while (true)
                            {
                                if (int.TryParse(Console.ReadLine(), out phoneNumber))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter only numbers");
                                }
                            }

                            if (BookingMethods.checkIfCustomerExists(phoneNumber))
                            { 
                                break;
                            }
                            else if (bookingID == 0)
                            {
                                break;
                            }
                            else
                            { 
                                Console.WriteLine("The phone number you entered does not exist!");
                            }
                        }
                        
                        
                        Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Enter the month of the booking you would like to remove: ");
                                    int month;
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out month))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month >= 1 && month <= 12)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter a valid month");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadLine();
                                            Console.WriteLine(
                                                "=====================================================================");
                                            Console.Write("Set a month of the booking: ");
                                        }
                                    }

                                    
                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Enter the starting day of the booking you would like to remove: ");
                                    int startDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out startDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
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
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
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
                                                Console.WriteLine(
                                                    "=====================================================================");
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
                                                    "=====================================================================");
                                                Console.Write("Set a starting day of the booking: ");
                                            }
                                        }
                                    }

                                    

                                    Console.WriteLine(
                                        "=====================================================================");
                                    Console.Write("Enter the ending day of the booking you would like to remove: ");
                                    int endDay;

                                    while (true)
                                    {
                                        while (true)
                                        {
                                            if (int.TryParse(Console.ReadLine(), out endDay))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter only numbers");
                                            }
                                        }
                                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
                                            month == 10 || month == 12)
                                        {
                                            if (endDay >= 1 && endDay <= 31)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                                        {
                                            if (endDay >= 1 && endDay <= 30)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }

                                        else if (month == 2)
                                        {
                                            if (endDay >= 1 && endDay <= 28)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid ending day");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    "=====================================================================");
                                                Console.Write("Set an ending day of the booking: ");
                                            }
                                        }
                                    }

                                  
                                    
                        
                        BookingMethods.cancelBooking(bookingID, startDay, endDay, month, phoneNumber);
                        Console.WriteLine("Booking successfully cancelled!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else if (choice == 10)
            {
                Console.Write("Goodbye!");
                break;
            }
        }
    }
}