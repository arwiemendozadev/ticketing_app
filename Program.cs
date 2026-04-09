public class Program
{
    static void Main()
    {
        string response = "";

        while (response != "X")
        {
            DisplayMenu();

            Console.Write("Please enter menu choice: ");

            response = Console.ReadLine() ?? "";

            if (response == "1")
            {
                Console.WriteLine("\n--- Customers List ---");

                for (int i = 0; i < CustomerData.Customers.Count; i++)
                {
                    var customer = CustomerData.Customers[i];

                    Console.WriteLine($"{ i + 1 }. { customer.FirstName } { customer.LastName }");
                    Console.WriteLine($"Date of birth: {customer.BirthDate: d MMMM yyyy}");
                    Console.WriteLine($"Email: { customer.Email } \n");
                }

                Console.WriteLine();
            }
            else if (response == "2")
            {
                Console.WriteLine("\n--- Events List ---");

                for (int i = 0; i < EventData.Events.Count; i++)
                {
                    var ev = EventData.Events[i];
                    string ageRestrictionLabel = ev.AgeRestriction == 0 ? "None" : $"{ ev.AgeRestriction } years old";

                    Console.WriteLine($"{ i + 1 }. { ev.Name }");
                    Console.WriteLine($"Age Restriction: { ageRestrictionLabel }");
                    Console.WriteLine($"Happening on: {ev.EventDate: d MMMM yyyy}");
                    Console.WriteLine($"Capacity: { ev.Capacity }");
                    Console.WriteLine($"Tickets sold: { ev.TicketsSold }\n");
                }

                Console.WriteLine();
            }
            else if (response == "3")
            {
                Console.WriteLine("\n--- Customers' Events List ---");

                for (int i = 0; i < CustomerData.Customers.Count; i++)
                {
                    var customer = CustomerData.Customers[i];
                    var customerEvents = GetCustomerEvents(customer.Id);

                    Console.WriteLine($"{ i + 1 }. { customer.FirstName } { customer.LastName }");

                    int customerEventsCount = customerEvents.Count;

                    if (customerEventsCount != 0)
                    {
                        Console.WriteLine("\n===== Purchased tickets =====\n");

                        for (int j = 0; j < customerEventsCount; j++)
                        {
                            var ev = customerEvents[j];
                            char letter = (char)('a' + j);

                            Console.WriteLine($"{ letter }. { ev.EventName }");
                            Console.WriteLine($"Tickets bought: { ev.TicketsBought }\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n===== No purchased tickets yet =====\n");
                    }
                }

                Console.WriteLine();
            }
            else if (response == "4")
            {
                Console.WriteLine("");

                foreach (var ev in EventData.Events)
                {
                    Console.WriteLine($"{ ev.Name } - Available tickets: { ev.Capacity - ev.TicketsSold }\n");
                }
            }
            else if (response != "X")
            {
                Console.WriteLine("\n===============================================");
                Console.WriteLine(" Invalid response. Please try again (1-4 or X)");
                Console.WriteLine("===============================================\n");
            }
        }

        Console.WriteLine("\n=== Thank you for using the ticketing system! ===\n");
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("===== WELCOME TO SELWYN EVENT TICKETING SYSTEM =====");
        Console.WriteLine(" 1 - List Customers");
        Console.WriteLine(" 2 - List Events");
        Console.WriteLine(" 3 - List Customers' Events");
        Console.WriteLine(" 4 - Future Events with available tickets");
        Console.WriteLine(" X = Exit the program");
    }

    private static List<CustomerEventInfo> GetCustomerEvents(int customerId)
    {
        List<CustomerEventInfo> result = new List<CustomerEventInfo>();

        foreach (var ev in EventData.Events)
        {
            foreach (var customer in ev.Customers)
            {
                if (customer.CustomerId == customerId)
                {
                    result.Add(new CustomerEventInfo
                    {
                        EventName = ev.Name,
                        TicketsBought = customer.BoughtTickets
                    });
                }
            }
        }

        return result;
    }
}
